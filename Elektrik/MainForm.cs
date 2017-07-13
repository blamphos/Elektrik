/*
 * Created by SharpDevelop.
 * User: RTM
 * Date: 3.7.2017
 * Time: 18:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Elektrik
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	
		readonly List<string> Months = new List<string> { "Tammi", "Helmi", "Maalis", "Huhti", "Touko", "Kesä", "Heinä", "Elo", "Syys", "Loka", "Marras", "Joulu" };		

		int _currentMonth;
		RecordCollection _data;
		ProgressForm _progressForm = new ProgressForm();
			
		public MainForm()
		{
			InitializeComponent();						
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			_data = new RecordCollection();				
			_data.CsvFileName = Directory.GetFiles(Application.StartupPath, "*.csv").FirstOrDefault();
			
			if (string.IsNullOrEmpty(_data.CsvFileName))
		    {
				MessageBox.Show("CSV-file not found from startup path!");
				return;
		    }
			
			Text += " - " + Path.GetFileNameWithoutExtension(_data.CsvFileName);
						
			_progressForm.DoWork += _progressForm_DoWork;
			_progressForm.Argument = _data;
			_progressForm.StartPosition = FormStartPosition.CenterScreen;
			
			var result = _progressForm.ShowDialog();
			switch (result) {
				case DialogResult.Cancel:
					return;
				case DialogResult.Abort:
					MessageBox.Show(_progressForm.Result.Error.Message);
					return;
				case DialogResult.OK:
					break;
			}

			InitGui();
								
			foreach (var year in _data.Years)
			{
				var yearLabel = year.ToString();
				
				// Total per year			
				chart1.Series[0].Points.AddXY(yearLabel, _data.YearTotalKwh(year));

				// Total per month	
				var series = new Series(yearLabel);				
				series.ChartType = SeriesChartType.Column;						
				//series.IsValueShownAsLabel = true;
				chart2.Series.Add(series);
				
				for (var i = 1; i <= 12; i++)
				{
					series.Points.AddXY(Months[i - 1], _data.MonthlyTotalKwh(year, i));
				}
			}	

			WindowState = FormWindowState.Maximized;
		}
		
		static void _progressForm_DoWork(ProgressForm sender, DoWorkEventArgs e)
		{
		    var myArgument = e.Argument as RecordCollection;
		 
			try 
			{
				var lines = File.ReadAllLines(myArgument.CsvFileName);
								
				var i = 0;
				var header = false;
				foreach(var line in lines)
				{
					if (!header)
					{
						header = true;
						continue;
					}
					
					var arr = line.Split(';');
					var dt = DateTime.Parse(arr[0] + " " + arr[1]);
					var kwh = Convert.ToDouble(arr[2]);
					var temp = Convert.ToDouble(arr[3]);
					
					myArgument.Items.Add(new Record(dt, kwh, temp));
					i++;
					
			        if (sender.CancellationPending)
			        {
			            e.Cancel = true;
			            return;
			        }	
			        
			        if (i % 1000 == 0)
			        {
			        	sender.SetProgress(i, "Step " + i + " / " + lines.Count());
			        	System.Threading.Thread.Sleep(5);
			        }						
				}
			} 
			catch (Exception ex)
			{
				MessageBox.Show("ReadCsvFile", ex.Message);
			}			
		}		
		
		void InitGui()
		{
			chart1.Legends.Clear();
			chart1.ChartAreas[0].AxisY.Title = "kWh";
			chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
			chart1.Titles.Add(new Title("Vuosikulutus"));
			chart1.Series[0].IsValueShownAsLabel = true;
			
			chart2.Series.Clear();
			chart2.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
			//chart2.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
			chart2.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep45;
			chart2.ChartAreas[0].AxisY.Title = "kWh";
			chart2.Titles.Add(new Title("Kuukausikulutus"));
			
			chart3.Series.Clear();
			chart3.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
			chart3.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep45;
			chart3.ChartAreas[0].AxisY.Title = "kWh";
			chart3.Titles.Add(new Title("Päiväkulutus"));
			
			chart4.Series.Clear();
			chart4.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
			chart4.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep45;
			chart4.ChartAreas[0].AxisY.Title = "kWh";
			chart4.Titles.Add(new Title("Tuntikulutus"));			

			UpdateMonthChart(DateTime.Now.Month);
		}
		
		void UpdateMonthChart(int month)
		{		
			chart3.Series.Clear();			
			chart3.Titles[0].Text = "Päiväkulutus / " + Months[month - 1] + "kuu";
			
			foreach (var year in _data.Years)
			{
				var yearLabel = year.ToString();
				
				var monthData = _data.GetMonthData(year, month);
				var dayCount = monthData.Select(x => x.Timestamp.Day).Distinct().Count();

				// Total per month	
				var series = new Series(yearLabel);
				series.ChartType = SeriesChartType.Column;
				//series.BorderWidth = 12;
				//series.IsValueShownAsLabel = true;
				chart3.Series.Add(series);
				
				for (var i = 1; i <= dayCount; i++)
				{
					series.Points.AddXY(i.ToString(), _data.DailyTotalKwh(year, month, i));
				}
			}	

    		_currentMonth = month;
			UpdateDayChart(1);
		}		
		
		void UpdateDayChart(int day)
		{		
			chart4.Series.Clear();			
			chart4.Titles[0].Text = "Tuntikulutus / " + day + ". päivä";
			
			foreach (var year in _data.Years)
			{
				var yearLabel = year.ToString();

				// Total per month	
				var series = new Series(yearLabel);
				series.ChartType = SeriesChartType.Column;
				//series.BorderWidth = 12;
				//series.IsValueShownAsLabel = true;
				chart4.Series.Add(series);
				
				var hours = _data.GetDayData(year, _currentMonth, day);
				if (hours.Count == 0)
				{
					continue;
				}
				
				for (var i = 1; i <= 24; i++)
				{
					series.Points.AddXY(i.ToString("00"), hours[i - 1].KwhTotal);
				}
			}				
		}
		
		void Chart2MouseDown(object sender, MouseEventArgs e)
		{
		    var result = chart2.HitTest(e.X, e.Y);		        		  
		    
		    if (result.ChartElementType == ChartElementType.DataPoint)
		    {
			    var labelStr = result.Series.Points[result.PointIndex].AxisLabel;
			    for (var i = 0; i < Months.Count; i++)
			    {
			    	if (Months[i].Equals(labelStr))
			    	{
			    		UpdateMonthChart(i + 1);
			    		return;
			    	}
			    }
		    }		
		}
		void Chart3MouseDown(object sender, MouseEventArgs e)
		{
		    var result = chart3.HitTest(e.X, e.Y);		        		  
		    
		    if (result.ChartElementType == ChartElementType.DataPoint)
		    {
			    var labelStr = result.Series.Points[result.PointIndex].AxisLabel;
			    var day = Convert.ToInt32(labelStr);
			    UpdateDayChart(day);
		    }	
		}		
	}
}

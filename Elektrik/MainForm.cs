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
		string _csvFileName;
		RecordCollection _data;
		readonly List<string> Months = new List<string> { "Tammi", "Helmi", "Maalis", "Huhti", "Touko", "Kesä", "Heinä", "Elo", "Syys", "Loka", "Marras", "Joulu" };
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
						
			_csvFileName = Directory.GetFiles(Application.StartupPath, "*.csv").FirstOrDefault();
			if (string.IsNullOrEmpty(_csvFileName))
		    {
				MessageBox.Show("CSV-file not found from startup path!");
				return;
		    }
			
			Text += " - " + Path.GetFileNameWithoutExtension(_csvFileName) + " (Riekonmarjatie 18 A 5)";
			
			_data = new RecordCollection();
			ReadCsvFile();
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
			
			// Comboboxes
			comboBoxMonth.SelectedIndexChanged -= ComboBoxMonthSelectedIndexChanged;
			comboBoxMonth.Items.AddRange(Months.ToArray());
			comboBoxMonth.SelectedIndex = DateTime.Now.Month - 1;
			comboBoxMonth.SelectedIndexChanged += ComboBoxMonthSelectedIndexChanged;

			UpdateDayChart(DateTime.Now.Month - 1);
		}
		
		void ReadCsvFile()
		{
			try 
			{
				using (var reader = new StreamReader(_csvFileName))
				{
					string line;
					var header = false;
					while ((line = reader.ReadLine()) != null)
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
						
						_data.Add(new Record(dt, kwh, temp));
					}
				}
			} 
			catch (Exception e)
			{
				MessageBox.Show("ReadCsvFile", e.Message);
			}
		}

		void UpdateDayChart(int month)
		{		
			chart3.Series.Clear();			
			
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
					//series.Points.AddXY(i.ToString(), _data.DailyAverageKwh(year, month, i));
				}
			}				
		}		
		
		void ComboBoxMonthSelectedIndexChanged(object sender, EventArgs e)
		{
			//UpdateDayChart(Com);
		}
		
		void Chart2MouseDown(object sender, MouseEventArgs e)
		{
		    var result = chart2.HitTest(e.X, e.Y);		        		  
		    
		    if (result.ChartElementType == ChartElementType.DataPoint)
		    {
			    var labelStr = result.Series.Points[result.PointIndex].AxisLabel;
			    for (var i = 0; i < Months.Count; i++)
			    {
			    	if (Months.Equals(labelStr))
			    	{
			    		
			    	}
			    }
		    }		
		}
	}
	
	public class Record
	{
		public DateTime Timestamp;
		public double KwhTotal;
		public double Temperature;
		
		public Record(DateTime dt, double kwh, double temp)
		{
			Timestamp = dt;
			KwhTotal = kwh;
			Temperature = temp;
		}
	}
	
	public sealed class RecordCollection
	{
		public List<Record> Items;
		
		public RecordCollection()
		{
			Items = new List<Record>();
		}
		
		public void Add(Record record)
		{
			Items.Add(record);
		}
		
		public List<int> Years
		{
			get
			{
				return Items.Select(x => x.Timestamp.Year).Distinct().ToList();	
			}			
		}
		
		public List<Record> GetYearData(int year)
		{
			return Items.Where(x => x.Timestamp.Year == year).ToList();
		}
		
		public List<Record> GetMonthData(int year, int month)
		{
			var yearData = GetYearData(year);	
			return yearData.Where(x => x.Timestamp.Month == month).ToList();
		}
		
		public List<Record> GetDayData(int year, int month, int day)
		{
			var monthlyData = GetMonthData(year, month);
			return monthlyData.Where(x => x.Timestamp.Day == day).ToList();
		}
		
		public double YearTotalKwh(int year)
		{
			return GetYearData(year).Sum(x => x.KwhTotal);
		}

		public double MonthlyTotalKwh(int year, int month)
		{						
			return GetMonthData(year, month).Sum(x => x.KwhTotal);
		}
		
		public double DailyTotalKwh(int year, int month, int day)
		{							
			return GetDayData(year, month, day).Sum(x => x.KwhTotal);
		}
		
		public double DailyAverageKwh(int year, int month, int day)
		{							
			return GetDayData(year, month, day).Average(x => x.KwhTotal);
		}
		
		public List<double> MonthlyTotalKwh(int year)
		{
			var yearData = GetYearData(year);
			
			var list = new List<double>();
			for (var i = 1; i <= 12; i++)
			{
				list.Add(yearData.Where(x => x.Timestamp.Month == i).Sum(x => x.KwhTotal));
			}
			
			return list;
		}
	}
}

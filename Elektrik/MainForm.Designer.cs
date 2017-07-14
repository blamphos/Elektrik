/*
 * Created by SharpDevelop.
 * User: RTM
 * Date: 3.7.2017
 * Time: 18:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Elektrik
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartYears;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDays;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartMonths;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartHours;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartYears = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.chartMonths = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.chartHours = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartDays = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartYears)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartMonths)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDays)).BeginInit();
			this.SuspendLayout();
			// 
			// chartYears
			// 
			chartArea1.Name = "ChartArea1";
			this.chartYears.ChartAreas.Add(chartArea1);
			this.chartYears.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.chartYears.Legends.Add(legend1);
			this.chartYears.Location = new System.Drawing.Point(3, 3);
			this.chartYears.Name = "chartYears";
			series1.ChartArea = "ChartArea1";
			series1.IsValueShownAsLabel = true;
			series1.LabelFormat = "####";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartYears.Series.Add(series1);
			this.chartYears.Size = new System.Drawing.Size(320, 216);
			this.chartYears.TabIndex = 0;
			this.chartYears.Text = "chart1";
			this.chartYears.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartYearsMouseDown);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.923F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.077F));
			this.tableLayoutPanel1.Controls.Add(this.chartMonths, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.chartYears, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 445);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// chartMonths
			// 
			chartArea2.Name = "ChartArea1";
			this.chartMonths.ChartAreas.Add(chartArea2);
			this.chartMonths.Dock = System.Windows.Forms.DockStyle.Fill;
			legend2.Name = "Legend1";
			this.chartMonths.Legends.Add(legend2);
			this.chartMonths.Location = new System.Drawing.Point(329, 3);
			this.chartMonths.Name = "chartMonths";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartMonths.Series.Add(series2);
			this.chartMonths.Size = new System.Drawing.Size(629, 216);
			this.chartMonths.TabIndex = 1;
			this.chartMonths.Text = "chart2";
			this.chartMonths.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartMonthsMouseDown);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel2.Controls.Add(this.chartHours, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.chartDays, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 225);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(955, 217);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// chartHours
			// 
			chartArea3.Name = "ChartArea1";
			this.chartHours.ChartAreas.Add(chartArea3);
			this.chartHours.Dock = System.Windows.Forms.DockStyle.Fill;
			legend3.Name = "Legend1";
			this.chartHours.Legends.Add(legend3);
			this.chartHours.Location = new System.Drawing.Point(528, 3);
			this.chartHours.Name = "chartHours";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.chartHours.Series.Add(series3);
			this.chartHours.Size = new System.Drawing.Size(424, 211);
			this.chartHours.TabIndex = 1;
			this.chartHours.Text = "chart4";
			this.chartHours.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartHoursMouseDown);
			// 
			// chartDays
			// 
			chartArea4.Name = "ChartArea1";
			this.chartDays.ChartAreas.Add(chartArea4);
			this.chartDays.Dock = System.Windows.Forms.DockStyle.Fill;
			legend4.Name = "Legend1";
			this.chartDays.Legends.Add(legend4);
			this.chartDays.Location = new System.Drawing.Point(3, 3);
			this.chartDays.Name = "chartDays";
			series4.ChartArea = "ChartArea1";
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			this.chartDays.Series.Add(series4);
			this.chartDays.Size = new System.Drawing.Size(519, 211);
			this.chartDays.TabIndex = 0;
			this.chartDays.Text = "chart3";
			this.chartDays.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartDaysMouseDown);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 445);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainForm";
			this.Text = "Elektrik";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.chartYears)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartMonths)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDays)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

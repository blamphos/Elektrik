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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainSummary;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDays;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartMonths;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLowerSummary;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartHours;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSummary;
		private System.Windows.Forms.TabPage tabPageAnalysis;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainAnalysis;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysis;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartYears = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tableLayoutPanelMainSummary = new System.Windows.Forms.TableLayoutPanel();
			this.chartMonths = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tableLayoutPanelLowerSummary = new System.Windows.Forms.TableLayoutPanel();
			this.chartHours = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartDays = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageSummary = new System.Windows.Forms.TabPage();
			this.tabPageAnalysis = new System.Windows.Forms.TabPage();
			this.tableLayoutPanelMainAnalysis = new System.Windows.Forms.TableLayoutPanel();
			this.chartAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.chartYears)).BeginInit();
			this.tableLayoutPanelMainSummary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartMonths)).BeginInit();
			this.tableLayoutPanelLowerSummary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDays)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageSummary.SuspendLayout();
			this.tabPageAnalysis.SuspendLayout();
			this.tableLayoutPanelMainAnalysis.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).BeginInit();
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
			this.chartYears.Size = new System.Drawing.Size(315, 200);
			this.chartYears.TabIndex = 0;
			this.chartYears.Text = "chart1";
			this.chartYears.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartYearsMouseDown);
			// 
			// tableLayoutPanelMainSummary
			// 
			this.tableLayoutPanelMainSummary.ColumnCount = 2;
			this.tableLayoutPanelMainSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.923F));
			this.tableLayoutPanelMainSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.077F));
			this.tableLayoutPanelMainSummary.Controls.Add(this.chartMonths, 1, 0);
			this.tableLayoutPanelMainSummary.Controls.Add(this.chartYears, 0, 0);
			this.tableLayoutPanelMainSummary.Controls.Add(this.tableLayoutPanelLowerSummary, 0, 1);
			this.tableLayoutPanelMainSummary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMainSummary.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelMainSummary.Name = "tableLayoutPanelMainSummary";
			this.tableLayoutPanelMainSummary.RowCount = 2;
			this.tableLayoutPanelMainSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMainSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMainSummary.Size = new System.Drawing.Size(947, 413);
			this.tableLayoutPanelMainSummary.TabIndex = 1;
			// 
			// chartMonths
			// 
			chartArea2.Name = "ChartArea1";
			this.chartMonths.ChartAreas.Add(chartArea2);
			this.chartMonths.Dock = System.Windows.Forms.DockStyle.Fill;
			legend2.Name = "Legend1";
			this.chartMonths.Legends.Add(legend2);
			this.chartMonths.Location = new System.Drawing.Point(324, 3);
			this.chartMonths.Name = "chartMonths";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartMonths.Series.Add(series2);
			this.chartMonths.Size = new System.Drawing.Size(620, 200);
			this.chartMonths.TabIndex = 1;
			this.chartMonths.Text = "chart2";
			this.chartMonths.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartMonthsMouseDown);
			// 
			// tableLayoutPanelLowerSummary
			// 
			this.tableLayoutPanelLowerSummary.ColumnCount = 2;
			this.tableLayoutPanelMainSummary.SetColumnSpan(this.tableLayoutPanelLowerSummary, 2);
			this.tableLayoutPanelLowerSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
			this.tableLayoutPanelLowerSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanelLowerSummary.Controls.Add(this.chartHours, 0, 0);
			this.tableLayoutPanelLowerSummary.Controls.Add(this.chartDays, 0, 0);
			this.tableLayoutPanelLowerSummary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLowerSummary.Location = new System.Drawing.Point(3, 209);
			this.tableLayoutPanelLowerSummary.Name = "tableLayoutPanelLowerSummary";
			this.tableLayoutPanelLowerSummary.RowCount = 1;
			this.tableLayoutPanelLowerSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLowerSummary.Size = new System.Drawing.Size(941, 201);
			this.tableLayoutPanelLowerSummary.TabIndex = 2;
			// 
			// chartHours
			// 
			chartArea3.Name = "ChartArea1";
			this.chartHours.ChartAreas.Add(chartArea3);
			this.chartHours.Dock = System.Windows.Forms.DockStyle.Fill;
			legend3.Name = "Legend1";
			this.chartHours.Legends.Add(legend3);
			this.chartHours.Location = new System.Drawing.Point(520, 3);
			this.chartHours.Name = "chartHours";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.chartHours.Series.Add(series3);
			this.chartHours.Size = new System.Drawing.Size(418, 195);
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
			this.chartDays.Size = new System.Drawing.Size(511, 195);
			this.chartDays.TabIndex = 0;
			this.chartDays.Text = "chart3";
			this.chartDays.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartDaysMouseDown);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageSummary);
			this.tabControl1.Controls.Add(this.tabPageAnalysis);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(961, 445);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPageSummary
			// 
			this.tabPageSummary.Controls.Add(this.tableLayoutPanelMainSummary);
			this.tabPageSummary.Location = new System.Drawing.Point(4, 22);
			this.tabPageSummary.Name = "tabPageSummary";
			this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSummary.Size = new System.Drawing.Size(953, 419);
			this.tabPageSummary.TabIndex = 0;
			this.tabPageSummary.Text = "Summary";
			this.tabPageSummary.UseVisualStyleBackColor = true;
			// 
			// tabPageAnalysis
			// 
			this.tabPageAnalysis.Controls.Add(this.tableLayoutPanelMainAnalysis);
			this.tabPageAnalysis.Location = new System.Drawing.Point(4, 22);
			this.tabPageAnalysis.Name = "tabPageAnalysis";
			this.tabPageAnalysis.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAnalysis.Size = new System.Drawing.Size(953, 419);
			this.tabPageAnalysis.TabIndex = 1;
			this.tabPageAnalysis.Text = "Analysis";
			this.tabPageAnalysis.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelMainAnalysis
			// 
			this.tableLayoutPanelMainAnalysis.ColumnCount = 2;
			this.tableLayoutPanelMainAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMainAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMainAnalysis.Controls.Add(this.chartAnalysis, 0, 1);
			this.tableLayoutPanelMainAnalysis.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanelMainAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMainAnalysis.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelMainAnalysis.Name = "tableLayoutPanelMainAnalysis";
			this.tableLayoutPanelMainAnalysis.RowCount = 2;
			this.tableLayoutPanelMainAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.53027F));
			this.tableLayoutPanelMainAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.46973F));
			this.tableLayoutPanelMainAnalysis.Size = new System.Drawing.Size(947, 413);
			this.tableLayoutPanelMainAnalysis.TabIndex = 0;
			// 
			// chartAnalysis
			// 
			chartArea5.Name = "ChartArea1";
			this.chartAnalysis.ChartAreas.Add(chartArea5);
			this.tableLayoutPanelMainAnalysis.SetColumnSpan(this.chartAnalysis, 2);
			this.chartAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
			legend5.Name = "Legend1";
			this.chartAnalysis.Legends.Add(legend5);
			this.chartAnalysis.Location = new System.Drawing.Point(3, 157);
			this.chartAnalysis.Name = "chartAnalysis";
			series5.ChartArea = "ChartArea1";
			series5.Legend = "Legend1";
			series5.Name = "Series1";
			this.chartAnalysis.Series.Add(series5);
			this.chartAnalysis.Size = new System.Drawing.Size(941, 253);
			this.chartAnalysis.TabIndex = 1;
			this.chartAnalysis.Text = "chart3";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(467, 148);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 445);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Elektrik";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.chartYears)).EndInit();
			this.tableLayoutPanelMainSummary.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartMonths)).EndInit();
			this.tableLayoutPanelLowerSummary.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDays)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPageSummary.ResumeLayout(false);
			this.tabPageAnalysis.ResumeLayout(false);
			this.tableLayoutPanelMainAnalysis.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartAnalysis)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

/*
 * Created by SharpDevelop.
 * User: RTM
 * Date: 11.7.2017
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Elektrik
{
	partial class ProgressForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Button buttonCancel;
		
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.labelStatus = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.progressBar, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelStatus, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 99);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// progressBar
			// 
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBar.Location = new System.Drawing.Point(3, 43);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(278, 14);
			this.progressBar.TabIndex = 0;
			// 
			// labelStatus
			// 
			this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelStatus.Location = new System.Drawing.Point(3, 0);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(278, 40);
			this.labelStatus.TabIndex = 1;
			this.labelStatus.Text = "label1";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCancel.Location = new System.Drawing.Point(3, 63);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(278, 34);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// ProgressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 99);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ProgressForm";
			this.Text = "ProgressForm";
			this.Load += new System.EventHandler(this.ProgressFormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}

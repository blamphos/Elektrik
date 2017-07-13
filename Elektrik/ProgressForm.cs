/*
 * Created by SharpDevelop.
 * User: RTM
 * Date: 11.7.2017
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Elektrik
{
	/// <summary>
	/// Description of ProgressForm.
	/// </summary>
	public partial class ProgressForm : Form
	{
	    int _lastPercent;
	    string _lastStatus;		
		BackgroundWorker _worker;
		
		public object Argument { get; set; }
		
		public delegate void DoWorkEventHandler(ProgressForm sender, DoWorkEventArgs e);
		public event DoWorkEventHandler DoWork;
	    public string CancellingText { get; set; }
	    public string DefaultStatusText { get; set; }
    
		public RunWorkerCompletedEventArgs Result { get; private set; }
		
		public ProgressForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
				
	        DefaultStatusText = "Please wait...";
	        CancellingText = "Cancelling operation...";
        
			_worker = new BackgroundWorker();
			_worker.WorkerReportsProgress = true;
			_worker.WorkerSupportsCancellation = true;
			_worker.DoWork += worker_DoWork;
			_worker.ProgressChanged += worker_ProgressChanged;
			_worker.RunWorkerCompleted += worker_RunWorkerCompleted;
		}
		
		void worker_DoWork(object sender, DoWorkEventArgs e)
		{
		    if (DoWork != null)
		    {
		    	DoWork(this, e);
		    }
		}

	    void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
	    {
		    if (e.ProgressPercentage >= progressBar.Minimum &&
		        e.ProgressPercentage <= progressBar.Maximum)
		    {
		        progressBar.Value = e.ProgressPercentage;
		    }
	    	
		    if (e.UserState != null)
		    {
		    	labelStatus.Text = e.UserState.ToString();
		    }
	    }
	    
	    void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	    {
	    	Result = e;
	    	
		    if (e.Error != null)
		    {
		    	DialogResult = DialogResult.Abort;
		    }
		    else if (e.Cancelled)
		    {
		    	DialogResult = DialogResult.Cancel;
		    }
		    else
		    {
		    	DialogResult = DialogResult.OK;
		    }
		    
		    Close();	    	
	    }
	        
		void ProgressFormLoad(object sender, EventArgs e)
		{
	        Result = null;
	        buttonCancel.Enabled = true;
	        progressBar.Value = progressBar.Minimum;
	        labelStatus.Text = DefaultStatusText;
	        _lastStatus = DefaultStatusText;
	        _lastPercent = progressBar.Minimum;
	        
	        _worker.RunWorkerAsync(Argument);
		}		
		
		void buttonCancel_Click(object sender, EventArgs e)
		{
	        _worker.CancelAsync();
	        
	        buttonCancel.Enabled = false;
	        labelStatus.Text = CancellingText;	
		}
		
	    public void SetProgress(string status)
	    {
	        if (status != _lastStatus && !_worker.CancellationPending)
	        {
	            _lastStatus = status;
	            _worker.ReportProgress(progressBar.Minimum - 1, status);
	        }
	    }
    
	    public void SetProgress(int percent)
		{
	       	if (percent != _lastPercent)
	        {
	            _lastPercent = percent;
	            _worker.ReportProgress(percent);
	        }
		}	
	    
	    public void SetProgress(int percent, string status)
	    {	        
	       if (percent != _lastPercent || (status != _lastStatus && !_worker.CancellationPending))
	       {
	           _lastPercent = percent;
	           _lastStatus = status;
	           _worker.ReportProgress(percent, status);
	       }
	    }	    

	    public bool CancellationPending
	    {
	        get { return _worker.CancellationPending; }
	    }	   	   
	}
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colordetector
{
    public partial class HiddenForm : Form
    {
        private bool paused = false;
        private ColorDetector colorDetector = new ColorDetector();
        private int interval = 1000; //default 1000ms
        public HiddenForm()
        {
            InitializeComponent();
            CaptureTimer.Start();
            //initialzie interval using config file if needed
        }


        private void HiddenForm_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Hide();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(paused)
            {
                pauseToolStripMenuItem.Text = "Pause";
                CaptureTimer.Start();

            }
            else
            {
                pauseToolStripMenuItem.Text = "Start";
                 CaptureTimer.Stop();
            }
            paused = !paused;
        }
        private void SetFrequency_Click(object sender,EventArgs e)
        {
            if (sender.Equals(refreshEvery1sToolStripMenuItem))
                interval = CaptureTimer.Interval = 1000;
            else if(sender.Equals(refreshEvery10sToolStripMenuItem))
                interval = CaptureTimer.Interval = 10000;
            else interval = CaptureTimer.Interval = 60000;
        }

        private void useConfigFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //read interval from a config file and set to captureTimer
        }

        private void CaptureTimer_Tick(object sender, EventArgs e)
        {
            var d = colorDetector;
            
            d.detect();
            try
            {

                CaptureTimer.Stop();
                using (var wb = new WebClient())
                {
                    //string get = "http://<rasspberry-pi-IP>/color.php?r=" + (d.R > 50 ? d.R : 0) + "g=" + (d.G > 50 ? d.G : 0) + "b=" + (d.B > 50 ? d.B : 0) + "id=<your id>";
                    string get = "http://localhost/color.php?r=" + (d.R > 50 ? d.R : 0) + "&g=" + (d.G > 50 ? d.G : 0) + "&b=" + (d.B > 50 ? d.B : 0) + "&id=124";
                    var response = wb.DownloadString(get);
                }
            }
            catch (Exception E)
            {
                DialogResult choice = MessageBox.Show("Retry in 30 seconds or Abort ?\nerror text :" + E.Message, "Retry or Abort", MessageBoxButtons.AbortRetryIgnore);
                if (choice == DialogResult.Retry)
                {
                    CaptureTimer.Interval = 30000;
                }
                else if (choice == DialogResult.Abort)
                {
                    CaptureTimer.Stop();
                    paused = true;
                    pauseToolStripMenuItem.Text = "Start";
                    //make icon gray if needed
                }
            }
            finally
            {
                if(!paused)
                    CaptureTimer.Start();
            }
           
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void photographicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textOnWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void HiddenForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class BusyForm : Form
    {
        public bool FlagGetResponse { get; set; }
        System.Timers.Timer myTimer = new System.Timers.Timer(1000);
        public BusyForm()
        {
            InitializeComponent();
            FlagGetResponse = false;
        }

        private void BusyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FlagGetResponse)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void BusyForm_Load(object sender, EventArgs e)
        {
            myTimer.Elapsed += UpdateLabel;
            myTimer.Start();
        }
        private void UpdateLabel(object sender, ElapsedEventArgs e)
        {
            this.label1.Text = this.label1.Text + "..";
        }

      

        
    }
}

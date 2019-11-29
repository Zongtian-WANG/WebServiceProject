using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private BusyForm busyForm;
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
            log.Info(string.Format("Log info {0}", 1));
            log.Debug(string.Format("Log debug {0}", 2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Info(string.Format("Log info {0}", 3));
            log.Debug(string.Format("Log debug {0}", 4));
            AsyncCallService service = new Controller.AsyncCallService();

            using (busyForm = new BusyForm())
            {
                Task<int> result = service.CallFibonacci(10, busyForm);
                busyForm.StartPosition = FormStartPosition.CenterParent;
                busyForm.ShowDialog();
                MessageBox.Show("result ==> " + result.Result);
            }
        }
                
    }
}

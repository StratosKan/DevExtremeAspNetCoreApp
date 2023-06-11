using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DevExtremeAspNetCoreApp1.Reports
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void tableCell8_BeforePrint(object sender, CancelEventArgs e)
        {
            Console.WriteLine("test");
        }
    }
}

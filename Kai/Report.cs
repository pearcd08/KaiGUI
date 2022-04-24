using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kai
{
    public partial class Report : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;
        public Report(DataModule dm, MainMenu mnu)
        {
            
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void iconReturn_Click(object sender, EventArgs e)
        {
            if (frmMenu == null)
            {
                frmMenu = new MainMenu();
            }
            frmMenu.ShowDialog();

        }

        private void iconReturn_Click_1(object sender, EventArgs e)
        {

            if (frmMenu == null)
            {
                frmMenu = new MainMenu();
            }
            frmMenu.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void iconPrint_Click(object sender, EventArgs e)
        {
            ppGenerateReport.PrintPreviewControl.Document = printEventReport;
            ppGenerateReport.PrintPreviewControl.Zoom = 1;
            ppGenerateReport.ShowDialog();

        }

        private void printEventReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         
        }
    }
}

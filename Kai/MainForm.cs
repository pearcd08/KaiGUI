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
    public partial class MainMenu : Form
    {
        private DataModule DM;
        private KaiMaintenance kaiForm;
        private Events eventsForm;
        private Whanau whanauForm;
        private Locations locationForm;
        private Registration registrationForm;  
        private Report reportForm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void iconKai_Click(object sender, EventArgs e)
        {
            if (kaiForm == null) 
            {
                kaiForm = new KaiMaintenance(DM, this);
                
            }
            kaiForm.ShowDialog();

        }

        private void iconEvents_Click(object sender, EventArgs e)
        {
            if (eventsForm == null) 
            {
                Events eForm = new Events();  

            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void iconKai_MouseHover(object sender, EventArgs e)
        {
            iconKai.BackColor = Color.Orange;
        }

        private void iconKai_MouseLeave(object sender, EventArgs e)
        {
            iconKai.BackColor = Color.Transparent;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconReport_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
            {
                reportForm = new Report(DM, this);

            }
            reportForm.ShowDialog();

        }

        private void IconWhanau_Click(object sender, EventArgs e)
        {
            if (whanauForm == null)
            {
                whanauForm = new Whanau(DM, this);

            }
            whanauForm.ShowDialog();

        }

        private void iconRegistration_Click(object sender, EventArgs e)
        {
            if (registrationForm == null) 
            {
                registrationForm = new Registration(DM, this);
            }
            registrationForm.ShowDialog();
        }
    }
}

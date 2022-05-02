using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kai
{
    public partial class MainMenu : Form
    {
        private DataModule DM;
        private KaiMaintenance kaiForm;
        private EventMaintenance eventsForm;
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
            kaiForm.Size = new Size(900, 600);
            kaiForm.ShowDialog();

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

        private void iconLocations_Click(object sender, EventArgs e)
        {
            if (locationForm == null)
            {
                locationForm = new Locations(DM, this);
            }
            locationForm.ShowDialog();
        }

        private void iconEvents_Click(object sender, EventArgs e)
        {
            if (eventsForm == null)
            {
                eventsForm = new EventMaintenance(DM, this);
            }
            eventsForm.ShowDialog();


        }
    }
}

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
        private WhanauMaintenance whanauForm;
        private LocationMaintenance locationForm;
        private FormRegistration registrationForm;
        private Report reportForm;
        public Size formSize;


        public MainMenu()
        {
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
            formSize = new Size(900, 600);
        }

        private void btnKai_Click(object sender, EventArgs e)
        {
            if (kaiForm == null)
            {
                kaiForm = new KaiMaintenance(DM, this);

            }
            kaiForm.Size = formSize;
            kaiForm.StartPosition = FormStartPosition.CenterScreen;
            kaiForm.MaximizeBox = false;
            kaiForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            kaiForm.ShowDialog();

        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            if (eventsForm == null)
            {
                eventsForm = new EventMaintenance(DM, this);
            }
            eventsForm.Size = formSize;
            eventsForm.StartPosition = FormStartPosition.CenterScreen;
            eventsForm.MaximizeBox = false;
            eventsForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            eventsForm.ShowDialog();


        }

        private void btnWhanau_Click(object sender, EventArgs e)
        {
            if (whanauForm == null)
            {
                whanauForm = new WhanauMaintenance(DM, this);

            }
            whanauForm.Size = formSize;
            whanauForm.StartPosition = FormStartPosition.CenterScreen;
            whanauForm.MaximizeBox = false;
            whanauForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            whanauForm.ShowDialog();

        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            if (locationForm == null)
            {
                locationForm = new LocationMaintenance(DM, this);
            }
            locationForm.Size = formSize;
            locationForm.StartPosition = FormStartPosition.CenterScreen;
            locationForm.MaximizeBox = false;
            locationForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            locationForm.ShowDialog();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (registrationForm == null)
            {
                registrationForm = new FormRegistration(DM, this);
            }
            registrationForm.Size = formSize;
            registrationForm.StartPosition = FormStartPosition.CenterScreen;
            registrationForm.MaximizeBox = false;
            registrationForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            registrationForm.ShowDialog();
        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
            {
                reportForm = new Report(DM, this);

            }
            reportForm.StartPosition = FormStartPosition.CenterScreen;
            reportForm.MaximizeBox = false;
            reportForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            reportForm.ShowDialog();

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace Kai
{
    public partial class Registration : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager cmEvent;
        private CurrencyManager cmWhanau;
        private CurrencyManager cmEventRegister;



        public Registration(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Event"];
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Whanau"];
            cmEventRegister = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EventRegister"];
            BindControls();

        }
        ///<Summary> method: BindControls()
        ///Binds the data grid views to the different tables
        ///</Summary> 
        private void BindControls()
        {
            dgvEvents.DataSource = DM.dsKaioordinate;
            dgvEvents.DataMember = "Event";

            dgvWhanau.DataSource = DM.dsKaioordinate;
            dgvWhanau.DataMember = "Whanau";

            dgvRegister.DataSource = DM.dsKaioordinate;
            dgvRegister.DataMember = "EventRegister";
        }



        ///<Summary> method: btnAdd_Click()
        ///Takes the ID from the event and whanau data grid view
        ///If an registration doesn't exist with both those ids
        ///Create a new one
        ///</Summary> 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string aEventID = dgvEvents["EventID", cmEvent.Position].Value.ToString();
            string aWhanauID = dgvWhanau["WhanauID", cmWhanau.Position].Value.ToString();

            DataRow newEventRegisterRow = DM.dtEventRegister.NewRow();
            DataRow[] whanauEventRow = DM.dtEventRegister.Select("EventID = " + aEventID + " AND WhanauID = " + aWhanauID);
            if (whanauEventRow.Length != 0)
            {
                MessageBox.Show("Whanau can only be registered to an event once.", "Error");
            }
            else
            {
                newEventRegisterRow["WhanauID"] = aWhanauID;
                newEventRegisterRow["EventID"] = aEventID;
                newEventRegisterRow["KaiPreparation"] = cboxKai.Checked;

                DM.dsKaioordinate.Tables["EventRegister"].Rows.Add(newEventRegisterRow);
                DM.UpdateEventRegister();
                MessageBox.Show("Entry added successfully", "Success");
            }

        }

        ///<Summary> method: btnDelete_Click()
        ///Takes the ID from event register data grid view
        ///Deletes the row with that id from eventregister table       
        ///</Summary> 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int regID = Convert.ToInt32(DM.dtEventRegister.Rows[cmEventRegister.Position]["RegistrationID"]);
                int row = 0;

                for (int i = 0; i < DM.dtEventRegister.Rows.Count; i++)
                {
                    int rID = Convert.ToInt32(DM.dtEventRegister.Rows[i]["RegistrationID"]);

                    if (regID == rID)
                    {
                        row = i;
                    }
                }

                DataRow deleteEventRegisterRow = DM.dsKaioordinate.Tables["EventRegister"].Rows[row];
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEventRegisterRow.Delete();
                    DM.UpdateEventRegister();
                    MessageBox.Show("Entry removed successfully", "Success");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Error");
            }
           

        }

        ///<Summary> method: btnReturn_Click()
        ///Closes the window       
        ///</Summary> 
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Registration_Load(object sender, EventArgs e)
        {

        }

    }


}

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
    public partial class Registration : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager cmEvent;
        private CurrencyManager cmWhanau;
        private CurrencyManager cmEventRegister;
        private CurrencyManager cmDT;
        

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

        private void BindControls() 
        {
            dgvEvents.DataSource = DM.dsKaioordinate;
            dgvEvents.DataMember = "Event";

            dgvWhanau.DataSource = DM.dsKaioordinate;
            dgvWhanau.DataMember = "Whanau";

            dgvRegister.DataSource = DM.dsKaioordinate;
            dgvRegister.DataMember = "EventRegister";
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRegisterRow = DM.dtEventRegister.Rows[cmEventRegister.Position];
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteEventRegisterRow.Delete();
                DM.UpdateEventRegister();
                MessageBox.Show("Entry removed successfully", "Success");

            }

        }
    }

        
    }

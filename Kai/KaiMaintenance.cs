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
     
    public partial class KaiMaintenance : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;
        


        public KaiMaintenance(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            
            
            
            //bindings for original panel
            txtKaiID.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiID");
            txtEvent.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.EventID");    
            txtKaiName.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiName");            
            txtPreperation.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationRequired");
            txtPreperationTime.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationMinutes");
            txtServingQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.ServeQuantity");
            
            //bindings for update panel
            cboEvent.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.EventID");            
            cbxPreparation.DataBindings.Add("Checked", DM.dsKaioordinate, "Kai.PreparationRequired");
            numPreparationTime.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationMinutes");
            numServingQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.ServeQuantity");
            //fills in the listbox with the kai name
            listBoxKai.DataSource = DM.dsKaioordinate;
            listBoxKai.DisplayMember = "Kai.KaiName";
            listBoxKai.ValueMember = "Kai.KaiID";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Kai"];



        }

      

        private void KaiMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteKaiRow = DM.dtKai.Rows[currencyManager.Position];
            DataRow[] eventKaiRow = DM.dtEventRegister.Select("EventID = " + txtEvent.Text);
            if (eventKaiRow.Length != 0) 
            {
                MessageBox.Show("You may only delete kai that have no event relation", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK) 
                {
                    deleteKaiRow.Delete();
                    DM.UpdateKai();
                }
                    

                
            }
        }

        private void iconAdd_Click(object sender, EventArgs e)
        {
            //make panel visible
            pnlAdd.Location = new Point(384, 37);
            pnlAdd.Visible = true;            
            //load data into combobox
            LoadEvents();
            //make fields invisible
            listBoxKai.Visible = false;
            listBoxKai.Enabled=false;            
            lblKaiID.Visible=false;
            txtKaiID.Visible = false;
            txtEvent.Visible = false;
            txtPreperation.Visible = false; 
            txtPreperationTime.Visible = false; 
            txtServingQuantity.Visible = false;
            //disable buttons
            btnUp.Visible = false;  
            btnDown.Visible = false;
            btnAdd.Enabled = false; 
            btnDelete.Enabled=false;    
            btnUpdate.Enabled=false;  
            btnReturn.Enabled=false;
            //clear data fields
            txtKaiNameAdd.Text = "";
           cbxPreparation.Checked = false;
          numPreparationTime.Value = 0;   
           numServingQuantity.Value = 0;          
            
           
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            //get the name
            txtKaiNameAdd.Text = txtKaiName.Text;
            //make panel visible
            pnlAdd.Location = new Point(384, 37);
            pnlAdd.Visible = true;
            //make fields invisible
            listBoxKai.Visible = false;
            lblKaiID.Visible = false;
            txtKaiID.Visible = false;
            txtEvent.Visible = false;
            txtPreperation.Visible = false;
            txtPreperationTime.Visible = false;
            txtServingQuantity.Visible = false;
            //disable buttons
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnReturn.Enabled = false;



        }

        private void iconUp_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0) 
            {
                --currencyManager.Position; 
            }
        }

        private void iconDown_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            
            //make panel invisible
            pnlAdd.Visible = false;
            //make fields visible
            listBoxKai.Visible = true;
            listBoxKai.Enabled = true;
            lblKaiID.Visible = true;
            txtKaiID.Visible = true;
            txtEvent.Visible = true;
            txtPreperation.Visible = true;
            txtPreperationTime.Visible = true;
            txtServingQuantity.Visible = true;
            //enable buttons
            btnUp.Visible = true;
            btnDown.Visible = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnReturn.Enabled = true;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow newKaiRow = DM.dtKai.NewRow();

            if ((txtKaiNameAdd.Text == ""))
            {
                MessageBox.Show("You must type in a Kai name", "Error");
            }
            else 
            {                
                    newKaiRow["EventID"] = cboEvent.Text;
                    newKaiRow["KaiName"] = txtKaiNameAdd.Text;
                    newKaiRow["PreparationRequired"] = cbxPreparation.Checked;
                    newKaiRow["PreparationMinutes"] = numPreparationTime.Text;
                    newKaiRow["ServeQuantity"] = numServingQuantity.Text;
                    DM.dtKai.Rows.Add(newKaiRow);
                    MessageBox.Show("Kai added successfully", "Success");
                    DM.UpdateKai();
                
            }
        }

        private void LoadEvents()
        {
            cboEvent.DataSource = DM.dsKaioordinate;
            cboEvent.DisplayMember = "Event.EventID";
            cboEvent.ValueMember = "Event.EventID";
        }

        private void iconReturn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}

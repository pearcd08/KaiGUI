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
        private CurrencyManager cmKai;
       



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
            txtEventID.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.EventID"); 
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

            cmKai = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Kai"];


        }

      

        private void KaiMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteKaiRow = DM.dtKai.Rows[cmKai.Position];
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
            txtEventID.Location = new Point(384, 37);
            txtEventID.Visible = true;            
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
            txtEventID.Location = new Point(384, 37);
            txtEventID.Visible = true;
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
            if (cmKai.Position > 0) 
            {
                --cmKai.Position; 
            }
        }

        private void iconDown_Click(object sender, EventArgs e)
        {
            if (cmKai.Position < cmKai.Count - 1)
            {
                ++cmKai.Position;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            
            //make panel invisible
            txtEventID.Visible = false;
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

        private void listBoxKai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEventID.Text != "") 
            {
                int eventValue = Convert.ToInt32(txtEventID.Text);
                int eventIndex = DM.eventView.Find(eventValue);

                if (eventIndex != -1)
                {
                    DataRow drEvent = DM.dtEvent.Rows[eventIndex];
                    txtEvent.Text = drEvent.ToString();
                }

            }
            
            
            
            

        }
    }
}

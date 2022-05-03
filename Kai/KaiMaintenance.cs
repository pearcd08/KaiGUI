using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kai
{

    public partial class KaiMaintenance : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager cmKai;
        private CurrencyManager cmEvent;

        public KaiMaintenance(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            cmKai = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Kai"];
        }

        ///<Summary> method: KaiMaintenanceLoad()
        ///Initiates LoadEventName when the form loads
        ///</Summary>  
        private void KaiMaintenance_Load(object sender, EventArgs e)
        {
            LoadEventName();
        }

        ///<Summary> method: BindControls()
        ///Binds the listbox and the textboxes to the Kai datatable
        ///</Summary>  
        public void BindControls()
        {

            listBoxKai.DataSource = DM.dsKaioordinate;
            listBoxKai.DisplayMember = "Kai.KaiName";
            listBoxKai.ValueMember = "Kai.KaiID";

            txtKaiID.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiID");
            txtKaiName.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiName");
            txtPreperation.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationRequired");
            txtPreperationTime.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationMinutes");
            txtServingQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.ServeQuantity");

        }

        /// Task 1
        /// Add a new record

        ///<Summary> method: btnAdd_Click()
        ///Makes different items visible and invisble
        ///Makes fields blank
        ///</Summary>  
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Location = new Point(384, 37);
            panelAdd.Visible = true;

            HideButtons();
            LoadEvents();

            cboAddEvent.SelectedIndex = 0;
            txtAddKaiName.Text = "";
            cboxAddPreparation.Checked = false;
            numAddPreparationTime.Enabled = false;
            numAddPreparationTime.Value = 0;
            numAddServingQuantity.Value = 0;

        }

        ///<Summary> method: cboxAddPreparation_CheckedChange()
        ///If the check box has been checked, disable the number up down control and set it to 0   
        ///</Summary>  
        private void cboxAddPreparation_CheckedChanged(object sender, EventArgs e)
        {

            if (cboxAddPreparation.Checked)
            {
                numAddPreparationTime.Enabled = true;
            }
            else
            {
                numAddPreparationTime.Enabled = false;
                numAddPreparationTime.Value = 0;
            }
        }

        ///<Summary> method:  btnAddSave_Click
        ///Save the new record if the fields are valid  
        ///</Summary>  
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddKaiName.Text == "")
                {
                    txtAddKaiName.Focus();
                    MessageBox.Show("Please enter a Kai Name", "Error");
                }

                if (numAddServingQuantity.Value == 0)
                {
                    MessageBox.Show("Quantity cannot be zero", "Error");
                    numAddServingQuantity.Focus();
                }
                if ((cboxAddPreparation.Checked) && (numAddPreparationTime.Value == 0))
                {
                    MessageBox.Show("Preparation Time cannot be 0 if Preperation is required", "Error");
                    numAddPreparationTime.Focus();
                }
                else if (txtAddKaiName.Text != "" || numAddServingQuantity.Value != 0)
                {
                    DataRow newKaiRow = DM.dtKai.NewRow();
                    newKaiRow["EventID"] = cboAddEvent.SelectedValue;
                    newKaiRow["KaiName"] = txtAddKaiName.Text;
                    newKaiRow["PreparationRequired"] = cboxAddPreparation.Checked;
                    newKaiRow["PreparationMinutes"] = numAddPreparationTime.Value;
                    newKaiRow["ServeQuantity"] = numAddServingQuantity.Value;

                    DM.dtKai.Rows.Add(newKaiRow);
                    DM.UpdateKai();

                    if (MessageBox.Show("Kai added successfully", "Success",
                               MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        panelAdd.Visible = false;
                        listBoxKai.Visible = true;
                        panelDelete.Visible = true;
                        ShowButtons();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        ///<Summary> method:  btnAddCancel_Click()
        ///Hides the add panel and displays the original panel
        ///Makes the buttons and listbox visible
        ///</Summary>  
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            ShowButtons();

        }

        /// Task 2
        /// Update an existing Kai Records

        ///<Summary> method:  btnUpdate_Click()
        ///Hides original panel and displays update panel
        ///Transfers orginal fields values into update panel fields
        ///</Summary>  
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panelUpdate.Location = new Point(384, 37);
            panelUpdate.Visible = true;
            LoadEvents();
            HideButtons();
            txtUpdateKaiName.Text = txtKaiName.Text;

            if (txtPreperation.Text == "True")
            {
                cboxUpdatePreparation.Checked = true;

            }
            else
            {
                cboxUpdatePreparation.Checked = false;
                numUpdatePreparationTime.Enabled = false;
                numUpdatePreparationTime.Value = 0;
            }

            numUpdatePreparationTime.Value = Convert.ToInt32(txtPreperationTime.Text);
            numUpdateServingQuantity.Value = Convert.ToInt32(txtServingQuantity.Text);

        }

        ///<Summary> method:  cboxUpdatePreparation_CheckedChanged_1()
        ///Disables the number up down field if the checkbox is unchecked and sets it to 0     
        ///</Summary>  
        private void cboxUpdatePreparation_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboxUpdatePreparation.Checked)
            {
                numUpdatePreparationTime.Enabled = true;
            }
            else
            {
                numUpdatePreparationTime.Enabled = false;
                numUpdatePreparationTime.Value = 0;
            }

        }

        ///<Summary> method:  btnUpdateSave_Click()
        ///Updates the kai record if all fields are valid   
        ///</Summary> 
        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUpdateKaiName.Text == "")
                {
                    MessageBox.Show("Please enter an Kai Name", "Error");
                    txtUpdateKaiName.Focus();
                }
                if (numUpdateServingQuantity.Text == "0")
                {
                    MessageBox.Show("Quantity cannot be zero", "Error");
                    numUpdateServingQuantity.Focus();
                }
                if ((cboxUpdatePreparation.Checked) && (numUpdatePreparationTime.Value == 0))
                {
                    MessageBox.Show("Preparation Time cannot be 0 if Preperation is required", "Error");
                    numUpdatePreparationTime.Focus();
                }
                else if ((txtUpdateKaiName.Text != "") && (numUpdateServingQuantity.Text != "0"))
                {
                    DataRow updateKaiRow = DM.dtKai.Rows[cmKai.Position];
                    updateKaiRow["EventID"] = cboUpdateEvent.SelectedValue;
                    updateKaiRow["KaiName"] = txtUpdateKaiName.Text;
                    updateKaiRow["PreparationRequired"] = cboxUpdatePreparation.Checked;
                    updateKaiRow["PreparationMinutes"] = numUpdatePreparationTime.Text;
                    updateKaiRow["ServeQuantity"] = numUpdateServingQuantity.Text;
                    cmKai.EndCurrentEdit();
                    DM.UpdateKai();

                    if (MessageBox.Show("Kai updated successfully", "Success",
                               MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        panelUpdate.Visible = false;
                        listBoxKai.Visible = true;
                        panelDelete.Visible = true;
                        ShowButtons();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        ///<Summary> method:  btnUpdateCancel_Click()
        ///Hides the update panel and displays the form in the original state 
        ///</Summary> 
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            ShowButtons();
        }

        ///Task 3 
        ///Delete an exisiting kai record

        ///<Summary> method:  btnDelete_Click()
        ///Deletes seleceted Kai record if it is not registered to any  regustered events
        ///</Summary> 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow kaiRow = DM.dtKai.Rows[cmKai.Position];
                int aEventID = Convert.ToInt32(kaiRow["EventID"].ToString());
                DataRow[] eventRegisterRow = DM.dtEventRegister.Select("EventID = " + aEventID);

                if (eventRegisterRow.Length == 0)
                {
                    int kaiID = Convert.ToInt32(DM.dtKai.Rows[cmKai.Position]["KaiID"].ToString());
                    int row = 0;
                    for (int i = 0; i < DM.dtKai.Rows.Count; i++)
                    {
                        int kID = Convert.ToInt32(DM.dtKai.Rows[i]["KaiID"].ToString());
                        if (kaiID == kID)
                        {
                            row = i;
                        }

                    }
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        DataRow deleteKaiRow = DM.dsKaioordinate.Tables["Kai"].Rows[row];
                        deleteKaiRow.Delete();
                        DM.UpdateKai();
                        MessageBox.Show("Kai successfully deleted", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Cannot delete a Kai registered to an Event", "Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        /// OTHER FUNCTIONS

        ///<Summary> method: LoadEvents()
        ///Loads the events into combo boxes
        ///</Summary>        
        private void LoadEvents()
        {
            cboAddEvent.DataSource = DM.dsKaioordinate;
            cboAddEvent.DisplayMember = "Event.EventName";
            cboAddEvent.ValueMember = "Event.EventID";

            cboUpdateEvent.DataSource = DM.dsKaioordinate;
            cboUpdateEvent.DisplayMember = "Event.EventName";
            cboUpdateEvent.ValueMember = "Event.EventID";


        }
        ///<Summary> method: iconReturn_Click
        ///Closes the current window
        ///</Summary> 
        private void iconReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        ///<Summary> method: LoadEventName()
        ///Gets the event name from the event table using the current event id
        ///</Summary>       
        private void LoadEventName()
        {
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Event"];

            if (cmKai != null)
            {
                DataRow drKai = DM.dtKai.Rows[cmKai.Position];
                int aEventID = Convert.ToInt32(drKai["EventID"].ToString());
                cmEvent.Position = DM.eventView.Find(aEventID);
                DataRow drEvent = DM.dtEvent.Rows[cmEvent.Position];
                txtEvent.Text = drEvent["EventName"].ToString();

            }

        }

        ///<Summary> method: listBoxKai_SelectedIndexChanged
        ///Initiates the LoadEventName() on every listbox index change
        ///</Summary> 
        private void listBoxKai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEventName();

        }

        ///<Summary> method: HideButtons()
        ///Disables panel, buttons and changes backcolor to Control Dark
        ///</Summary>  
        private void HideButtons()
        {
            panelDelete.Visible = false;
            listBoxKai.Visible = false;
            btnUp.Enabled = false;
            btnUp.BackColor = SystemColors.ControlDark;
            btnDown.Enabled = false; ;
            btnDown.BackColor = SystemColors.ControlDark;
            btnAdd.Enabled = false;
            btnAdd.BackColor = SystemColors.ControlDark;
            btnUpdate.Enabled = false;
            btnUpdate.BackColor = SystemColors.ControlDark;
            btnDelete.Enabled = false;
            btnDelete.BackColor = SystemColors.ControlDark;
            btnReturn.Enabled = false;
            btnReturn.BackColor = SystemColors.ControlDark;
        }

        ///<Summary> method: HideButtons()
        ///Enables original panel, buttons and changes backcolor to Control
        ///</Summary> 
        private void ShowButtons()
        {
            panelDelete.Visible = true;
            listBoxKai.Visible = true;
            btnUp.Enabled = true;
            btnUp.BackColor = SystemColors.Control;
            btnDown.Enabled = true;
            btnDown.BackColor = SystemColors.Control;
            btnAdd.Enabled = true;
            btnAdd.BackColor = SystemColors.Control;
            btnUpdate.Enabled = true;
            btnUpdate.BackColor = SystemColors.Control;
            btnDelete.Enabled = true;
            btnDelete.BackColor = SystemColors.Control;
            btnReturn.Enabled = true;
            btnReturn.BackColor = SystemColors.Control;

        }

        ///<Summary> method: btnUp_Click()
        ///Moves the selection in the listbox up
        ///</Summary>
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmKai.Position > 0)
            {
                --cmKai.Position;
            }
        }

        ///<Summary> method: btnDown_Click()
        ///Moves the selection in the listbox down
        ///</Summary>
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmKai.Position < cmKai.Count - 1)
            {
                ++cmKai.Position;
            }
        }
    }

}

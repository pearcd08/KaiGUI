﻿using System;
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

        //loads event name based on cm position on form load
        private void KaiMaintenance_Load(object sender, EventArgs e)
        {
            LoadEventName();
        }

        public void BindControls()
        {
            //fills in the listbox with the kai name
            listBoxKai.DataSource = DM.dsKaioordinate;
            listBoxKai.DisplayMember = "Kai.KaiName";
            listBoxKai.ValueMember = "Kai.KaiID";
            //bindings for original panel
            txtKaiID.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiID");
            txtKaiName.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiName");
            txtPreperation.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationRequired");
            txtPreperationTime.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationMinutes");
            txtServingQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.ServeQuantity");
            //bindings for update panel
            txtUpdateKaiName.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiName");
            cboxUpdatePreparation.DataBindings.Add("Checked", DM.dsKaioordinate, "Kai.PreparationRequired");
            numUpdatePreparationTime.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationMinutes");
            numUpdateServingQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.ServeQuantity");


        }

        // Task A
        // Add a new kai record
        //1. click the add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //make panel visible
            panelAdd.Location = new Point(384, 37);
            panelAdd.Visible = true;
            //load data into combobox
            LoadEvents();
            //make fields invisible
            panelDelete.Visible = false;
            listBoxKai.Visible = false;
            //disable buttons
            HideButtons();


        }

        //2. Click the save button 
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtAddKaiName.Text == ""))
                {
                    txtAddKaiName.Focus();
                    MessageBox.Show("Please enter a Kai Name", "Error");
                }
                else
                {
                    DataRow newKaiRow = DM.dtKai.NewRow();
                    newKaiRow["EventID"] = cboAddEvent.SelectedValue;
                    newKaiRow["KaiName"] = txtAddKaiName.Text;
                    newKaiRow["PreparationRequired"] = cboxAddPreparation.Checked;
                    newKaiRow["PreparationMinutes"] = numUpdatePreparationTime.Text;
                    newKaiRow["ServeQuantity"] = numUpdateServingQuantity.Text;

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
        //3. cancel the add operation
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelDelete.Visible = true;
            listBoxKai.Visible = true;
            ShowButtons();

        }

        // TASK B
        // Update an existing Kai Records
        //1. click the update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //make panel visible
            panelUpdate.Location = new Point(384, 37);
            panelUpdate.Visible = true;
            LoadEvents();
            panelDelete.Visible = false;
            listBoxKai.Visible = false;
            HideButtons();
            //txtUpdateKaiName.Text = txtKaiName.Text;            

        }

        //2. save the updated record
        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUpdateKaiName.Text == ""))
                {
                    txtUpdateKaiName.Focus();
                    MessageBox.Show("Please enter an Kai Name", "Error");
                }
                else
                {
                    DataRow updateKaiRow = DM.dtKai.Rows[cmKai.Position];
                    updateKaiRow["EventID"] = cboUpdateEvent.SelectedValue;
                    updateKaiRow["KaiName"] = txtUpdateKaiName.Text;
                    updateKaiRow["PreparationRequired"] = cboxUpdatePreparation.Checked;
                    updateKaiRow["PreparationMinutes"] = numUpdatePreparationTime.Text;
                    updateKaiRow["ServeQuantity"] = numUpdateServingQuantity.Text;


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

        //3. Cancel the update operation
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            panelDelete.Visible = true;
            listBoxKai.Visible = true;
            ShowButtons();
        }

        //TASK C 
        //DELETE AN EXISTING KAI RECORD
        private void btnDelete_Click(object sender, EventArgs e)
        {     

            try
            {
                DataRow deleteKaiRow = DM.dtKai.Rows[cmKai.Position];                
                int aEventID = Convert.ToInt32(deleteKaiRow["EventID"].ToString());
                DataRow[] eventRegisterRow = DM.dtEventRegister.Select("EventID = " + aEventID);

                if (eventRegisterRow.Length != 0)
                {
                    MessageBox.Show("Cannot delete a Kai that is in a Registered Event", "Error");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        deleteKaiRow.Delete();
                        DM.UpdateKai();
                        MessageBox.Show("Kai Deleted Successfully", "Success");

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        

        // FUNCTIONS

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



        //LOADS THE EVENTS INTO COMBO BOXES
        private void LoadEvents()
        {
            cboAddEvent.DataSource = DM.dsKaioordinate;
            cboAddEvent.DisplayMember = "Event.EventName";
            cboAddEvent.ValueMember = "Event.EventID";

            cboUpdateEvent.DataSource = DM.dsKaioordinate;
            cboUpdateEvent.DisplayMember = "Event.EventName";
            cboUpdateEvent.ValueMember = "Event.EventID";


        }

        private void iconReturn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void listBoxKai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEventName();

        }

        //CHANGES THE EVENT NAME IN THE EVENT NAME TEXT BOX BASED ON CURRENT EVENTID IN CURRENCY MANAGER
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

        private void HideButtons()
        {
            btnUp.Visible = false;
            btnDown.Visible = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;

        }

        private void ShowButtons()
        {
            btnUp.Visible = true;
            btnDown.Visible = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnReturn.Enabled = true;

        }


    }

}

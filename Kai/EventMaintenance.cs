using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kai
{
    public partial class EventMaintenance : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager cmEvent;
        private CurrencyManager cmLocation;

        public EventMaintenance(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Event"];
            BindControls();
            LoadLocations();
        }
        ///<Summary> method: BindControls()
        ///Binds data to listbox and textboxes
        ///</Summary>  
        private void BindControls()
        {  
            listBoxEvents.DataSource = DM.dsKaioordinate;
            listBoxEvents.DisplayMember = "Event.EventName";
            listBoxEvents.ValueMember = "Event.EventID";                       
            txtEventID.DataBindings.Add("Text", DM.dsKaioordinate, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsKaioordinate, "Event.EventName");
            txtEventDate.DataBindings.Add("Text", DM.dsKaioordinate, "Event.EventDate");            
        }



        private void EventMaintenance_Load(object sender, EventArgs e)
        {
            txtEventDate.Text = dateUpdateEventDate.Text;

        }

        //TASK A
        //ADD A NEW EVENT RECORD
        //1. CLICK THE ADD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //enable add panel and change location
            panelAdd.Location = new Point(390, 50);
            panelAdd.Visible = true;
            HideButtons();

        }

        //2. SAVE THE NEW EVENT RECORD
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddEventName.Text == "")
                {
                    txtAddEventName.Focus();
                    MessageBox.Show("Please enter an Event Name", "Error");
                }
                else
                {
                    DataRow newEventRow = DM.dtEvent.NewRow();
                    newEventRow["EventName"] = txtAddEventName.Text;
                    newEventRow["LocationID"] = cboAddLocation.SelectedValue;
                    newEventRow["EventDate"] = dateAddEventDate.Text;

                    DM.dtEvent.Rows.Add(newEventRow);
                    DM.UpdateEvent();

                    if (MessageBox.Show("Event added successfully", "Success",
                               MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        panelAdd.Visible = false;
                        listBoxEvents.Visible = true;
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

        //3. CANCEL THE ADD EVENT
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //disable add panel
            panelAdd.Visible = false;
            //enable buttons
            ShowButtons();

        }

        //TASK B UPDATE AN EXISTING EVENT RECORD
        //1. CLICK THE UPDATE BUTTON

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //enable update panel and change location
            panelUpdate.Location = new Point(390, 50);
            panelUpdate.Visible = true;
            //hidebuttons
            HideButtons();
            //put text from original text boxes to the update panel textboxes
            txtUpdateEventName.Text = txtEventName.Text;


        }

        //2. SAVE THE UPDATED RECORD
        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUpdateEventName.Text == ""))
                {
                    txtUpdateEventName.Focus();
                    MessageBox.Show("Please enter an Event Name", "Error");
                }
                else
                {
                    DataRow updateEventRow = DM.dtEvent.Rows[cmEvent.Position];
                    updateEventRow["EventName"] = txtUpdateEventName.Text;
                    updateEventRow["LocationID"] = cboUpdateLocation.SelectedValue;
                    updateEventRow["EventDate"] = dateUpdateEventDate.Text;
                    //cmEvent.EndCurrentEdit();
                    DM.UpdateEvent();

                    if (MessageBox.Show("Event updated successfully", "Success",
                               MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        panelUpdate.Visible = false;
                       
                        ShowButtons();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        //3. CANCEL THE UPDATE OPERATION
        private void btnUpdateCanel_Click(object sender, EventArgs e)
        {
            //disable update panel
            panelUpdate.Visible = false;
            //enable button
            ShowButtons();
        }


        //TASK C
        //DELETE AN EXISTING RECORD
        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int aEventID = Convert.ToInt32(txtEventID.Text);
                DataRow[] kaiRow = DM.dtKai.Select("EventID = " + aEventID);

                if (kaiRow.Length == 0)
                {
                    int row = 0;
                    for (int i = 0; i < DM.dtEvent.Rows.Count; i++)
                    {
                        int eID = Convert.ToInt32(DM.dtEvent.Rows[i]["EventID"].ToString());
                        if (aEventID == eID)
                        {
                            row = i;
                        }

                    }
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        DataRow deleteEventRow = DM.dsKaioordinate.Tables["Event"].Rows[row];
                        deleteEventRow.Delete();
                        DM.UpdateEvent();
                        MessageBox.Show("Event deleted successfully", "Success"); ;
                    }

                }
                else
                {
                    MessageBox.Show("You may only delete an event that has no kai", "Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        ///<Summary> method: HideButtons()
        ///Disables panel, buttons and changes backcolor to Control Dark
        ///</Summary>  
        private void HideButtons()
        {
            panelDelete.Visible = false;
            listBoxEvents.Visible = false;
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
            listBoxEvents.Visible = true;
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



        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Location"];

            if (cmEvent != null)
            {   //GET THE LOCATION NAME USING THE LOCATION ID 
                DataRow drEvent = DM.dtEvent.Rows[cmEvent.Position];
                int aLocationID = Convert.ToInt32(drEvent["LocationID"].ToString());
                cmLocation.Position = DM.locationView.Find(aLocationID);
                DataRow drLocation = DM.dtLocation.Rows[cmLocation.Position];
                txtLocation.Text = drLocation["LocationName"].ToString();

                //REMOVE TIME FROM THE DATE DATA BY SPLITTING THE STRING AT THE SPACE
                string newDate = txtEventDate.Text.Split(' ')[0];
                txtEventDate.Text = newDate;
               

            }
        }

        private void LoadLocations()
        {
            cboAddLocation.DataSource = DM.dsKaioordinate;
            cboAddLocation.DisplayMember = "Location.LocationName";
            cboAddLocation.ValueMember = "Location.LocationID";

            cboUpdateLocation.DataSource = DM.dsKaioordinate;
            cboUpdateLocation.DisplayMember = "Location.LocationName";
            cboUpdateLocation.ValueMember = "Location.LocationID";

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmEvent.Position > 0)
            {
                --cmEvent.Position;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmEvent.Position < cmEvent.Count - 1)
            {
                ++cmEvent.Position;
            }
        }
    }
}

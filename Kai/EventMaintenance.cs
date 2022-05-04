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
            BindControls();
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Event"];
        }

        private void EventMaintenance_Load(object sender, EventArgs e)
        {
            LoadLocationName();
            SplitDate();

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

        ///TASK A
        ///ADD A NEW EVENT RECORD

        ///<Summary> method: btnAdd_Click()
        ///Shows add panel and initiates HideButtons()
        ///</Summary>  
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Location = new Point(390, 52);
            panelAdd.Visible = true;
            HideButtons();

        }

        ///<Summary> method: btnAddSave_Click()
        ///Saves the new Event record to the database if fields are correct
        ///</Summary>  
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
                    int aLocationID = Convert.ToInt32(cboAddLocation.SelectedValue);
                    DataRow newEventRow = DM.dtEvent.NewRow();
                    newEventRow["EventName"] = txtAddEventName.Text;
                    newEventRow["LocationID"] = aLocationID;
                    newEventRow["EventDate"] = dateAddEventDate.Text;

                    DM.dtEvent.Rows.Add(newEventRow);
                    DM.UpdateEvent();

                    if (MessageBox.Show("Event added successfully", "Success",
                               MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        panelAdd.Visible = false;
                        ShowButtons();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        ///<Summary> method: btnAddCancel_Click()
        ///Hides the add panel and initiates ShowButtons()
        ///</Summary>  
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            ShowButtons();
        }

        ///TASK B UPDATE AN EXISTING EVENT RECORD

        ///<Summary> method: btnUpdate_Click()
        ///Shows the update and initiates HideButtons()
        ///Loads locations into the combobox
        ///</Summary>  

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panelUpdate.Location = new Point(390, 52);
            panelUpdate.Visible = true;
            LoadLocations();
            HideButtons();
            txtUpdateEventName.Text = txtEventName.Text;


        }

        ///<Summary> method: btnUpdateSave_Click()
        ///Updates the selected record if all fields are correct      
        ///</Summary>  
        private void btnUpdateSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUpdateEventName.Text == "")
                {
                    txtUpdateEventName.Focus();
                    MessageBox.Show("Please enter an Event Name", "Error");
                }
                else
                {
                    int aLocationID = Convert.ToInt32(cboUpdateLocation.SelectedValue);
                    DataRow updateEventRow = DM.dtEvent.Rows[cmEvent.Position];
                    updateEventRow["EventName"] = txtUpdateEventName.Text;
                    updateEventRow["LocationID"] = aLocationID;
                    updateEventRow["EventDate"] = dateUpdateEventDate.Text;
                    cmEvent.EndCurrentEdit();
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

        ///<Summary> method: btnUpdateCancel_Click()
        ///Hides the update panel and initiates ShowButtons()     
        ///</Summary>
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            ShowButtons();
        }

        ///TASK C
        ///DELETE AN EXISTING RECORD

        ///<Summary> method: btnDelete_Click()
        ///Deletes the selected row, if no Kai is attached to it      
        ///</Summary>
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

        ///<Summary> method: SplitDate()
        ///Takes the original date value, splits it to remove the time
        ///</Summary> 
        private void SplitDate()
        {
            string newDate = txtEventDate.Text.Split(' ')[0];
            txtEventDate.Text = newDate;
        }

        ///<Summary> method: LoadLocationName()
        ///Takes the location id from the Event table and navigates the location table to find the related name
        ///Then puts it in a text box
        ///</Summary> 
        private void LoadLocationName()
        {
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Location"];

            if (cmEvent != null)
            {
                DataRow drEvent = DM.dtEvent.Rows[cmEvent.Position];
                int aLocationID = Convert.ToInt32(drEvent["LocationID"].ToString());
                cmLocation.Position = DM.locationView.Find(aLocationID);
                DataRow drLocation = DM.dtLocation.Rows[cmLocation.Position];
                txtLocation.Text = drLocation["LocationName"].ToString();

            }

        }

        ///<Summary> method: listBoxEvents_SelectedIndexChange()
        ///Any time the listbox changes position update the date and location name
        ///</Summary> 
        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLocationName();
            SplitDate();

        }

        ///<Summary> method: LoadLocation()
        ///Populate the comboboxes using the Location table
        ///</Summary> 
        private void LoadLocations()
        {
            cboAddLocation.DataSource = DM.dsKaioordinate;
            cboAddLocation.DisplayMember = "Location.LocationName";
            cboAddLocation.ValueMember = "Location.LocationID";

            cboUpdateLocation.DataSource = DM.dsKaioordinate;
            cboUpdateLocation.DisplayMember = "Location.LocationName";
            cboUpdateLocation.ValueMember = "Location.LocationID";

        }

        ///<Summary> method: btnUp_Click()
        ///Click button to navigate up the listbox
        ///</Summary>
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmEvent.Position > 0)
            {
                --cmEvent.Position;
            }
        }

        ///<Summary> method: btnDown_Click()
        ///Click button to navigate down the listbox
        ///</Summary>
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmEvent.Position < cmEvent.Count - 1)
            {
                ++cmEvent.Position;
            }
        }

        ///<Summary> method: btnReturn_Click()
        ///Close the form
        ///</Summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

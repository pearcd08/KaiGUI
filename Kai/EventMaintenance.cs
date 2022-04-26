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

        private void BindControls()
        {   //load data into listbox
            listBoxEvents.DataSource = DM.dsKaioordinate;
            listBoxEvents.DisplayMember = "Event.EventName";
            listBoxEvents.ValueMember = "Event.EventID";
            //load data into textboxes             
            txtEventID.DataBindings.Add("Text", DM.dsKaioordinate, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsKaioordinate, "Event.EventName");
            dateUpdateEventDate.DataBindings.Add("Text", DM.dsKaioordinate, "Event.EventDate");
         

        }



        private void EventMaintenance_Load(object sender, EventArgs e)
        {
            txtEventDate.Text = dateUpdateEventDate.Text;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // disable orignal panel and listbox
            panelDelete.Visible = false;
            listBoxEvents.Visible = false;
            //enable add panel and change location
            panelAdd.Location = new Point(390, 50);
            panelAdd.Visible = true;
            //disable buttons
            HideButtons();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtUpdateEventName.Text = txtEventName.Text;    
            //disable orignal panel and listbox
            panelDelete.Visible = false;
            listBoxEvents.Visible = false;
            //enable update panel and change location
            panelUpdate.Location = new Point(390, 50);
            panelUpdate.Visible = true;
            //hidebuttons
            HideButtons();
            //put text from original text boxes to the update panel textboxes
            

           

        }

        private void HideButtons()
        {
            btnUp.Visible = false;
            btnDown.Visible = false; ;
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

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //disable add panel
            panelAdd.Visible = false;
            //enable original panel and listbox
            listBoxEvents.Visible = true;
            panelDelete.Visible = true;
            //enable buttons
            ShowButtons();

        }

        private void btnUpdateCanel_Click(object sender, EventArgs e)
        {
            //disable update panel
            panelUpdate.Visible = false;
            //enable original panel and listbox
            listBoxEvents.Visible = true;
            panelDelete.Visible = true;
            //enable button
            ShowButtons();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Location"];

            if (cmEvent != null)
            {
                DataRow drEvent = DM.dtEvent.Rows[cmEvent.Position];
                int aLocationID = Convert.ToInt32(drEvent["LocationID"].ToString());
                cmLocation.Position = DM.locationView.Find(aLocationID);
                DataRow drLocation = DM.dtLocation.Rows[cmLocation.Position];
                txtLocation.Text = drLocation["LocationName"].ToString();
                txtEventDate.Text = dateUpdateEventDate.Text;

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

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtAddEventName.Text == ""))
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

                    if (MessageBox.Show("Event updated successfully", "Success",
                               MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {                        
                        panelUpdate.Visible = false;                        
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.dtEvent.Rows[cmEvent.Position];

            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK) 
                {
                    deleteEventRow.Delete();
                    DM.UpdateEvent();
                    MessageBox.Show("Event deleted successfully", "Success"); ;
                }                  

            }
            catch (Exception ex) 
            {                   
                MessageBox.Show("You may only delete an event that has no kai", "Error");    
            }           

            


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

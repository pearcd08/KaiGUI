using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kai
{
    public partial class Locations : Form
    {

        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager cmLocation;

        public Locations(DataModule dm, MainMenu mnu)
        {

            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Location"];
            BindControls();



        }

        private void BindControls()
        {   //load data into listbox
            listBoxLocations.DataSource = DM.dsKaioordinate;
            listBoxLocations.DisplayMember = "Location.LocationName";
            listBoxLocations.ValueMember = "Location.LocationID";
            //load data into textboxes             
            txtLocationID.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationID");
            txtLocationName.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationName");
            txtMessyText.DataBindings.Add("Text", DM.dsKaioordinate, "Location.Address");


        }


        //add location record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // disable orignal panel and listbox
            panelDelete.Visible = false;
            listBoxLocations.Visible = false;
            //enable add panel and change location
            panelAdd.Location = new Point(405, 45);
            panelAdd.Visible = true;
            //disable buttons
            HideButtons();

        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //disable add panel
            panelAdd.Visible = false;
            //enable original panel and listbox
            listBoxLocations.Visible = true;
            panelDelete.Visible = true;
            //enable buttons
            ShowButtons();

        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            DataRow newLocationRow = DM.dtLocation.NewRow();

            if ((txtAddLocationName.Text == "" || txtAddLocationAddress.Text == ""))
            {
                MessageBox.Show("Please enter all fields", "Error");
            }
            else
            {
                newLocationRow["LocationName"] = txtAddLocationName.Text;
                newLocationRow["Address"] = txtAddLocationAddress.Text;

                DM.dtLocation.Rows.Add(newLocationRow);
                DM.UpdateLocation();

                if (MessageBox.Show("Location added successfully", "Success",
                                  MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //disable update panel
                    panelAdd.Visible = false;
                    //enable original panel and listbox
                    listBoxLocations.Visible = true;
                    panelDelete.Visible = true;
                    //enable button
                    ShowButtons();

                }




            }

        }
        //update location record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //disable orignal panel and listbox
            panelDelete.Visible = false;
            listBoxLocations.Visible = false;
            //enable update panel and change location
            panelUpdate.Location = new Point(405, 45);
            panelUpdate.Visible = true;
            //hidebuttons
            HideButtons();
            //put text from original text boxes to the update panel textboxes
            txtUpdateLocationName.Text = txtLocationName.Text;
            txtUpdateLocationAddress.Text = txtMessyText.Text;

        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //disable update panel
            panelUpdate.Visible = false;
            //enable original panel and listbox
            listBoxLocations.Visible = true;
            panelDelete.Visible = true;
            //enable button
            ShowButtons();

        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            //updates the current row position
            DataRow updateLocationRow = DM.dtLocation.Rows[cmLocation.Position];
            //make sure the text fields arent null
            if ((txtUpdateLocationName.Text == "" || txtUpdateLocationAddress.Text == ""))
            {
                MessageBox.Show("Please enter all fields", "Error");
            }
            else
            {
                updateLocationRow["LocationName"] = txtUpdateLocationName.Text;
                updateLocationRow["Address"] = txtUpdateLocationAddress.Text;
                if (MessageBox.Show("Location updated successfully", "Success",
                                  MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //disable update panel
                    panelUpdate.Visible = false;
                    //enable original panel and listbox
                    listBoxLocations.Visible = true;
                    panelDelete.Visible = true;
                    //enable button
                    ShowButtons();

                }


            }

        }

        //delete record from database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // finds the positon of the selected location in the currencymanager
            DataRow deleteLocationRow = DM.dtLocation.Rows[cmLocation.Position];
            //looks into the event table to see if any events use the current location
            DataRow[] locationEventRow = DM.dtEvent.Select("LocationID = " + txtLocationID.Text);

            if (locationEventRow.Length != 0)
            {
                MessageBox.Show("You may only delete locations that have no events", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteLocationRow.Delete();
                    DM.UpdateLocation();

                }

            }

        }

        //other buttons        
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmLocation.Position > 0)
            {
                --cmLocation.Position;
            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmLocation.Position < cmLocation.Count - 1)
            {
                ++cmLocation.Position;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void SplitAddress()
        {


        }



        private void Locations_Load(object sender, EventArgs e)
        {


        }

        private void listBoxLocations_ValueMemberChanged(object sender, EventArgs e)
        {



        }

        private void listBoxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLocations.SelectedIndex != -1)
            {
                txtLocationAddress.Text = "";
                string originalAddress = txtMessyText.Text;
                string[] splitAddress = originalAddress.Split(',');
                for (int i = 0; i < splitAddress.Length; i++)
                {
                    txtLocationAddress.Text += splitAddress[i].Trim() + Environment.NewLine;
                }



            }



        }
    }
}

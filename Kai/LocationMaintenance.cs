using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kai
{
    public partial class LocationMaintenance : Form
    {

        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager cmLocation;

        public LocationMaintenance(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

        }

        ///<Summary> method: BindControls()
        ///Binds the listbox and text boxes to the location table
        ///</Summary> 
        private void BindControls()
        {
            listBoxLocations.DataSource = DM.dsKaioordinate;
            listBoxLocations.DisplayMember = "Location.LocationName";
            listBoxLocations.ValueMember = "Location.LocationID";
            txtLocationID.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationID");
            txtLocationName.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationName");
            txtLocationAddress.DataBindings.Add("Text", DM.dsKaioordinate, "Location.Address");
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Location"];
        }

        ///TASK 1 
        ///ADD A NEW RECORD 

        ///<Summary> method: btnAdd_Click()
        ///Hides original panel and buttons
        ///Shows add panel
        ///</Summary> 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HideButtons();
            panelAdd.Location = new Point(405, 45);
            panelAdd.Visible = true;

        }

        ///<Summary> method: btnAddSave_Click()
        ///Saves the new record
        ///Puts the 5 address lines into 1 string or 4 address lines if either street address 1 or 2 are missing
        ///</Summary> 
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddLocationName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a location name", "Error");
                    txtAddLocationName.Focus();
                }
                else
                {
                    DataRow newLocationRow = DM.dtLocation.NewRow();
                    if ((txtAddAddress1.Text.Trim() == "") && (txtAddAddress2.Text.Trim() != "") && (txtAddAddress3.Text.Trim() != "") &&
                        (txtAddAddress4.Text.Trim() != "") && (txtAddAddress5.Text.Trim() != ""))
                    {
                        newLocationRow["LocationName"] = txtAddLocationName.Text;
                        newLocationRow["Address"] = txtAddAddress2.Text.Trim() + ", " + txtAddAddress3.Text.Trim() + ", " + txtAddAddress4.Text.Trim() + " " + txtAddAddress5.Text.Trim();

                        DM.dtLocation.Rows.Add(newLocationRow);
                        DM.UpdateLocation();
                        if (MessageBox.Show("“Location added successfully”", "Success",
                                           MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            panelAdd.Visible = false;
                            ShowButtons();
                        }

                    }
                    if ((txtAddAddress1.Text.Trim() != "") && (txtAddAddress2.Text.Trim() == "") && (txtAddAddress3.Text.Trim() != "") &&
                        (txtAddAddress4.Text.Trim() != "") && (txtAddAddress5.Text.Trim() != ""))
                    {
                        newLocationRow["LocationName"] = txtAddLocationName.Text;
                        newLocationRow["Address"] = txtAddAddress1.Text.Trim() + ", " + txtAddAddress3.Text.Trim() + ", " + txtAddAddress4.Text.Trim() + ", " + txtAddAddress5.Text.Trim();
                        DM.dtLocation.Rows.Add(newLocationRow);
                        DM.UpdateLocation();
                        if (MessageBox.Show("“Location added successfully”", "Success",
                                         MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            panelAdd.Visible = false;
                            ShowButtons();
                        }
                    }
                    if ((txtAddAddress1.Text.Trim() != "") && (txtAddAddress2.Text.Trim() != "") && (txtAddAddress3.Text.Trim() != "") &&
                        (txtAddAddress4.Text.Trim() != "") && (txtAddAddress5.Text.Trim() != ""))
                    {
                        newLocationRow["LocationName"] = txtAddLocationName.Text;
                        newLocationRow["Address"] = txtAddAddress1.Text.Trim() + ", " + txtAddAddress2.Text.Trim() + ", " + txtAddAddress3.Text.Trim() + ", " +
                                                    txtAddAddress4.Text.Trim() + ", " + txtAddAddress5.Text.Trim();
                        DM.dtLocation.Rows.Add(newLocationRow);
                        DM.UpdateLocation();
                        if (MessageBox.Show("“Location added successfully”", "Success",
                                         MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            panelAdd.Visible = false;
                            ShowButtons();
                        }
                    }
                    if((txtAddAddress1.Text.Trim() == "") && (txtAddAddress2.Text.Trim() == ""))
                    {
                        MessageBox.Show("Atleast one Street Address line is required", "Error");
                    }
                    if ((txtAddAddress3.Text.Trim() == "") || (txtAddAddress4.Text.Trim() == "") || (txtAddAddress5.Text.Trim() == ""))
                    {
                        MessageBox.Show("Suburb, City and Postcode is required", "Error");
                    }

                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
           

        }

        /// <summary> method: btnAddCancel_Click()
        /// Hides the add panel
        /// shows original panel and buttons
        /// </summary>
        private void btnAddCancel_Click(object sender, EventArgs e)
        {

            panelAdd.Visible = false;
            ShowButtons();

        }

        ///TASK 2
        ///UPDATE AN EXISTING RECORD 

        /// <summary> method: btnUpdate_Click()
        /// Hides original panel and buttons
        /// Shows update panel
        /// Puts data into update fields
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HideButtons();
            panelUpdate.Location = new Point(405, 45);
            panelUpdate.Visible = true;
            txtUpdateLocationName.Text = txtLocationName.Text;
            SplitAddress();

        }

        /// <summary> method: SplitAddress()
        /// Take the address from the original address text field
        /// split it up and put it into the update panels address text fields
        /// </summary>
        private void SplitAddress()
        {
            string[] splitPostcode;
            string originalAddress = txtLocationAddress.Text;
            string[] splitAddress2 = originalAddress.Split(',');
            if (splitAddress2.Length == 4)
            {
                txtUpdateAddress1.Text = splitAddress2[0].Trim();
                txtUpdateAddress2.Text = splitAddress2[1].Trim();
                txtUpdateAddress3.Text = splitAddress2[2].Trim();
                splitPostcode = splitAddress2[3].Split(' ');
                txtUpdateAddress4.Text = splitPostcode[1].Trim();
                txtUpdateAddress5.Text = splitPostcode[2].Trim();

            }

            if (splitAddress2.Length == 3)
            {
                txtUpdateAddress1.Text = " ";
                txtUpdateAddress2.Text = splitAddress2[0].Trim();
                txtUpdateAddress3.Text = splitAddress2[1].Trim();
                splitPostcode = splitAddress2[2].Split(' ');
                txtUpdateAddress4.Text = splitPostcode[1].Trim();
                txtUpdateAddress5.Text = splitPostcode[2].Trim();
            }

        }

        /// <summary> method: btnUpdateSave()
        /// Save the updated record
        /// Take the text fields for address and make a string out of them
        /// </summary>
        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUpdateLocationName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a location name", "Error");
                    txtUpdateLocationName.Focus();

                }
                else
                {
                    DataRow updateLocationRow = DM.dtLocation.Rows[cmLocation.Position];
                    if ((txtUpdateAddress1.Text.Trim() == "") && (txtUpdateAddress2.Text.Trim() != "") && (txtUpdateAddress3.Text.Trim() != "") && 
                        (txtUpdateAddress4.Text.Trim() != "") && (txtUpdateAddress5.Text.Trim() != ""))
                    {
                        updateLocationRow["LocationName"] = txtUpdateLocationName.Text.Trim();
                        updateLocationRow["Address"] = txtUpdateAddress2.Text.Trim() + ", " + txtUpdateAddress3.Text.Trim() + ", " +
                                                       txtUpdateAddress4.Text.Trim() + " " + txtUpdateAddress5.Text.Trim();
                        cmLocation.EndCurrentEdit();
                        DM.UpdateLocation();

                        if (MessageBox.Show("“Location updated successfully”", "Success",
                                     MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            panelUpdate.Visible = false;
                            ShowButtons();
                        }

                    }
                    if ((txtUpdateAddress1.Text.Trim() != "") && (txtUpdateAddress2.Text.Trim() == "") && (txtUpdateAddress3.Text.Trim() != "") &&
                        (txtUpdateAddress4.Text.Trim() != "") && (txtUpdateAddress5.Text.Trim() != ""))
                    {
                        updateLocationRow["LocationName"] = txtUpdateLocationName.Text.Trim();
                        updateLocationRow["Address"] = txtUpdateAddress1.Text.Trim() + ", " + txtUpdateAddress3.Text.Trim() + ", " +
                                                       txtUpdateAddress4.Text.Trim() + " " + txtUpdateAddress5.Text.Trim();
                        cmLocation.EndCurrentEdit();
                        DM.UpdateLocation();

                        if (MessageBox.Show("“Location updated successfully”", "Success",
                                   MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            panelUpdate.Visible = false;
                            ShowButtons();
                        }
                    }
                    if ((txtUpdateAddress1.Text.Trim() != "") && (txtUpdateAddress2.Text.Trim() != "") && (txtUpdateAddress3.Text.Trim() != "") &&
                        (txtUpdateAddress4.Text.Trim() != "") && (txtUpdateAddress5.Text.Trim() != ""))
                    {
                        updateLocationRow["LocationName"] = txtUpdateLocationName.Text.Trim();
                        updateLocationRow["Address"] = txtUpdateAddress1.Text.Trim() + ", " + txtUpdateAddress2.Text.Trim() + ", " + txtUpdateAddress3.Text.Trim() + ", " +
                                                       txtUpdateAddress4.Text.Trim() + " " + txtUpdateAddress5.Text.Trim();
                        cmLocation.EndCurrentEdit();
                        DM.UpdateLocation();

                        if (MessageBox.Show("“Location updated successfully”", "Success",
                                   MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            panelUpdate.Visible = false;
                            ShowButtons();
                        }
                    }

                    if ((txtUpdateAddress1.Text.Trim() == "") && (txtUpdateAddress2.Text.Trim() == ""))
                    {
                        MessageBox.Show("Atleast one Street Address line is required", "Error");
                    }

                    if ((txtUpdateAddress3.Text.Trim() == "") || (txtUpdateAddress4.Text.Trim() == "") || (txtUpdateAddress5.Text.Trim() == ""))
                    {
                        MessageBox.Show("Suburb, City and Postcode is required", "Error");
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }

        }

        /// <summary> method: btnUpdateCancel_Click()
        /// Hides the update panel
        /// shows original panel and buttons
        /// </summary>
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            ShowButtons();
        }

        /// <summary> method: btnDelete_Click()
        /// See if the location has an event registered
        /// If it does not, then delete the location
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow deleteLocationRow = DM.dtLocation.Rows[cmLocation.Position];
                DataRow[] locationEventRow = DM.dtEvent.Select("LocationID = " + txtLocationID.Text);

                if (locationEventRow.Length > 0)
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
                        MessageBox.Show("Location successfully deleted", "Success");

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        /// <summary> method: btnUp_Click()
        /// Press button to scroll up in the listbox     
        /// </summary>     
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmLocation.Position > 0)
            {
                --cmLocation.Position;
            }

        }

        /// <summary> method: btnDown_Click()
        /// Press button to scroll down in the listbox     
        /// </summary> 
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmLocation.Position < cmLocation.Count - 1)
            {
                ++cmLocation.Position;
            }

        }

        /// <summary> method: btnReturn_Click()
        /// Press button to close Location Form    
        /// </summary> 
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        ///<Summary> method: HideButtons()
        ///Disables panel, buttons and changes backcolor to Control Dark
        ///</Summary>  
        private void HideButtons()
        {
            panelDelete.Visible = false;
            listBoxLocations.Visible = false;
            btnUp.Enabled = false;
            btnUp.BackColor = SystemColors.ControlDark;
            btnDown.Enabled = false; 
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
            listBoxLocations.Visible = true;
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

        private void Locations_Load(object sender, EventArgs e)
        {

        }


        /// <summary> method: txtAddAddress5_KeyPress()
        /// Only allows numbers and backspace in the add postcode text box     
        /// </summary> 
        private void txtAddAddress5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

              
    /// <summary> method: txtUpdateAddress5_KeyPress()
    /// Only allows numbers and backspace in the update postcode text box     
    /// </summary> 
    private void txtUpdateAddress5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

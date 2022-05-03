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
            if (txtAddLocationName.Text == "")
            {
                MessageBox.Show("Please enter a location name", "Error");
                txtAddLocationName.Focus();
            }
            else
            {
                DataRow newLocationRow = DM.dtLocation.NewRow();
                if ((txtAddAddress1.Text == "") && (txtAddAddress2.Text != "") && (txtAddAddress3.Text != "") && (txtAddAddress4.Text != "") && (txtAddAddress5.Text != ""))
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
                if ((txtUpdateAddress1.Text != "") && (txtAddAddress2.Text == "") && (txtAddAddress3.Text != "") && (txtAddAddress4.Text != "") && (txtAddAddress5.Text != ""))
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
                if ((txtUpdateAddress1.Text != "") && (txtAddAddress2.Text != "") && (txtAddAddress3.Text != "") && (txtAddAddress4.Text != "") && (txtAddAddress5.Text != "")) 
                {
                    newLocationRow["LocationName"] = txtAddLocationName.Text;
                    newLocationRow["Address"] = txtAddAddress1.Text.Trim() + ", " + txtAddAddress2.Text.Trim() + ", " + txtAddAddress3.Text.Trim() + ", " +
                                                txtAddAddress4.Text.Trim() + ", " +  txtAddAddress5.Text.Trim();
                    DM.dtLocation.Rows.Add(newLocationRow);
                    DM.UpdateLocation();
                    if (MessageBox.Show("“Location added successfully”", "Success",
                                     MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        panelAdd.Visible = false;
                        ShowButtons();
                    }
                }
                else
                {
                    MessageBox.Show("Suburb, City and atleast One street address line are required", "Error");
                }              

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
                if (txtUpdateLocationName.Text == "")
                {
                    MessageBox.Show("Please enter a location name", "Error");
                    txtUpdateLocationName.Focus();

                }
                else 
                {
                    DataRow updateLocationRow = DM.dtLocation.Rows[cmLocation.Position];
                    if ((txtUpdateAddress1.Text == "") && (txtUpdateAddress2.Text != "") && (txtUpdateAddress3.Text != "") && (txtUpdateAddress4.Text != "") && (txtUpdateAddress5.Text != ""))
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
                    if ((txtUpdateAddress1.Text != "") && (txtUpdateAddress2.Text == "") && (txtUpdateAddress3.Text != "") && (txtUpdateAddress4.Text != "") && (txtUpdateAddress5.Text != "")) 
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
                    if ((txtUpdateAddress1.Text != "") && (txtUpdateAddress2.Text != "") && (txtUpdateAddress3.Text != "") && (txtUpdateAddress4.Text != "") && (txtUpdateAddress5.Text != ""))
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

                    else
                    {
                        MessageBox.Show("Suburb, City and atleast One street address line are required", "Error");
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
                        DM.DeleteLocation();

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

        /// <summary> method: HideButtons()
        /// Hides original panel, up and down buttons and listbox
        /// Disables other buttons
        /// </summary> 
        private void HideButtons()
        {
            panelDelete.Visible = false;
            listBoxLocations.Visible = false;
            btnUp.Visible = false;
            btnDown.Visible = false; ;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
        }

        /// <summary> method: ShowButtons()
        /// Shows original panel, up and down buttons and listbox
        /// Emables other buttons
        /// </summary> 
        private void ShowButtons()
        {
            panelDelete.Visible = true;
            listBoxLocations.Visible = true;
            btnUp.Visible = true;
            btnDown.Visible = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnReturn.Enabled = true;

        }

    }
}

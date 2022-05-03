using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kai
{
    public partial class WhanauMaintenance : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private DataTable whanauCopy;
        private CurrencyManager cmWhanau;



        public WhanauMaintenance(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            cmWhanau = (CurrencyManager)this.BindingContext[whanauCopy];

        }

        ///<Summary> method: BindControls()
        ///Creates a copy of the Whanau DataTable
        ///Adds a new column for full name
        ///Concetates first name and last name 
        ///binds text boxes to the new Datatable
        ///</Summary> 
        public void BindControls()
        {
            whanauCopy = DM.dtWhanau.Copy();
            whanauCopy.Columns.Add(new DataColumn("FullName"));

            String fName;
            for (int i = 0; i < whanauCopy.Rows.Count; i++)
            {
                fName = Convert.ToString(whanauCopy.Rows[i]["FirstName"]) + " " + Convert.ToString(whanauCopy.Rows[i]["LastName"]);
                whanauCopy.Rows[i]["FullName"] = fName;
            }

            listBoxWhanau.DataSource = whanauCopy;
            listBoxWhanau.DisplayMember = "FullName";
            listBoxWhanau.ValueMember = "WhanauID";

            txtWhanauID.DataBindings.Add("Text", whanauCopy, "WhanauID");
            txtFirstName.DataBindings.Add("Text", whanauCopy, "FirstName");
            txtLastName.DataBindings.Add("Text", whanauCopy, "LastName");
            txtEmail.DataBindings.Add("Text", whanauCopy, "Email");
            txtPhone.DataBindings.Add("Text", whanauCopy, "Phone");
            txtAddress.DataBindings.Add("Text", whanauCopy, "Address");



        }

        ///TASK A
        ///ADD A NEW WHANAU RECORD

        ///<Summary> method: btnAdd_Click()
        ///Initiates the HideButtons() method
        ///Makes the add panel visible and sets its location
        ///</Summary> 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HideButtons();
            panelAdd.Visible = true;
            panelAdd.Location = new Point(442, 50);

        }

        ///<Summary> method: btnAddSave_Click()
        ///Saves a new Whanau to the database if all fields are correct
        ///</Summary> 
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtAddFirstName.Text == "") || (txtAddLastName.Text == "") || (txtAddEmail.Text == "") ||
                   (txtAddPhone.Text == "") || (txtAddAddress.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the Whanau text fields", "Error");
                }
                else
                {
                    //update original datatable
                    DataRow newWhanauRow = DM.dtWhanau.NewRow();
                    newWhanauRow["FirstName"] = txtAddFirstName.Text;
                    newWhanauRow["LastName"] = txtAddLastName.Text;
                    newWhanauRow["Email"] = txtAddEmail.Text;
                    newWhanauRow["Phone"] = txtAddPhone.Text;
                    newWhanauRow["Address"] = txtAddAddress.Text;
                    DM.dtWhanau.Rows.Add(newWhanauRow);

                    //update copied data table
                    DataRow newWhanauCopyRow = whanauCopy.NewRow();
                    newWhanauCopyRow["FirstName"] = txtAddFirstName.Text;
                    newWhanauCopyRow["LastName"] = txtAddLastName.Text;
                    newWhanauCopyRow["Email"] = txtAddEmail.Text;
                    newWhanauCopyRow["Phone"] = txtAddPhone.Text;
                    newWhanauCopyRow["Address"] = txtAddAddress.Text;
                    newWhanauCopyRow["FullName"] = txtAddFirstName.Text + " " + txtAddLastName.Text;
                    whanauCopy.Rows.Add(newWhanauCopyRow);


                    DM.UpdateWhanau();


                    if (MessageBox.Show("whanau added successfully", "Success",
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
        ///Makes add panel invisible and initiates ShowButtons()     
        ///</Summary> 
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            ShowButtons();

        }

        ///TASK B
        ///UPDATE A WHANAU RECORD

        ///<Summary> method: btnReturn_Click()
        ///Initiates the HideButtons() method
        ///Makes the Update panel visible and sets its location
        ///Transfers the text from the original text boxes to the update text boxes
        ///</Summary> 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HideButtons();
            panelUpdate.Location = new Point(442, 50);
            panelUpdate.Visible = true;

            txtUpdateFirstName.Text = txtFirstName.Text.ToString();
            txtUpdateLastName.Text = txtLastName.Text.ToString();
            txtUpdateEmail.Text = txtEmail.Text.ToString();
            txtUpdatePhone.Text = txtPhone.Text.ToString();
            txtUpdateAddress.Text = txtAddress.Text.ToString();

        }

        ///<Summary> method: btnUpdateSave_Click()
        ///Updates an existing record in the database if all fields are correct
        ///</Summary> 
        private void btnUpdateSave_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtUpdateFirstName.Text == "") || (txtUpdateLastName.Text == "") || (txtUpdateEmail.Text == "") ||
               (txtUpdatePhone.Text == "") || (txtUpdateAddress.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the Whanau text fields", "Error");
                }
                else
                {
                    DataRow updateWhanauRow = DM.dtWhanau.Rows[cmWhanau.Position];
                    updateWhanauRow["FirstName"] = txtUpdateFirstName.Text;
                    updateWhanauRow["LastName"] = txtUpdateLastName.Text;
                    updateWhanauRow["Email"] = txtUpdateEmail.Text;
                    updateWhanauRow["Phone"] = txtUpdatePhone.Text;
                    updateWhanauRow["Address"] = txtUpdateAddress.Text;

                    DataRow updateWhanauCopyRow = whanauCopy.Rows[cmWhanau.Position];
                    updateWhanauCopyRow["FirstName"] = txtUpdateFirstName.Text;
                    updateWhanauCopyRow["LastName"] = txtUpdateLastName.Text;
                    updateWhanauCopyRow["Email"] = txtUpdateEmail.Text;
                    updateWhanauCopyRow["Phone"] = txtUpdatePhone.Text;
                    updateWhanauCopyRow["Address"] = txtUpdateAddress.Text;
                    updateWhanauCopyRow["FullName"] = txtUpdateFirstName.Text + " " + txtUpdateLastName.Text;

                    cmWhanau.EndCurrentEdit();
                    DM.UpdateWhanau();


                    if (MessageBox.Show("whanau added successfully", "Success",
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
        ///Makes update panel invisible and initiates ShowButtons()     
        ///</Summary> 
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            ShowButtons();
            panelUpdate.Visible = false;

        }

        ///TASK C         
        ///DELETE A WHANAU RECORD

        ///<Summary> method: btnDelete_Click()
        ///Deletes the selected whanau from the database and the copied datatable 
        ///if they are not registered to any events  
        ///</Summary> 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int aWhanauID = Convert.ToInt32(txtWhanauID.Text);
                DataRow[] eventRegisterRow = DM.dtEventRegister.Select("WhanauID = " + aWhanauID);
                if (eventRegisterRow.Length == 0)
                {
                    int row = 0;
                    for (int i = 0; i < DM.dtWhanau.Rows.Count; i++)
                    {
                        int wID = Convert.ToInt32(DM.dtWhanau.Rows[i]["WhanauID"].ToString());
                        if (aWhanauID == wID)
                        {
                            row = i;
                        }
                    }
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show("Whanau Record Deleted Successfully?", "Success");

                        DataRow deleteWhanauRow = DM.dsKaioordinate.Tables["Whanau"].Rows[row];
                        deleteWhanauRow.Delete();
                        DM.UpdateWhanau();
                        DataRow deleteWhanauCopy = whanauCopy.Rows[row];
                        deleteWhanauCopy.Delete();

                    }
                }
                else
                {
                    MessageBox.Show("You may only delete kai that have no event relation", "Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }


        ///OTHER FUNCTIONS

        ///<Summary> method: txtAddPhone_Keypress()
        ///User can only input numbers into text field and use backspace   
        ///</Summary> 
        private void txtAddPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        ///<Summary> method: txtUpdatePhone_Keypress()
        ///User can only input numbers into text field and use backspace   
        ///</Summary> 
        private void txtUpdatePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }


        ///<Summary> method: HideButtons()
        ///Disables panel, buttons and changes backcolor to Control Dark
        ///</Summary>  
        private void HideButtons()
        {
            panelDelete.Visible = false;
            listBoxWhanau.Visible = false;
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
            listBoxWhanau.Visible = true;
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
        ///Clicking button will navigate up the listbox
        ///</Summary> 
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmWhanau.Position > 0)
            {
                --cmWhanau.Position;
            }
        }
        ///<Summary> method: btnDown_Click()
        ///Clicking button will navigate down the listbox
        ///</Summary> 
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmWhanau.Position < cmWhanau.Count - 1)
            {
                ++cmWhanau.Position;
            }
        }
        ///<Summary> method: btnReturn_Click()
        ///Clicking button will close the form
        ///</Summary> 
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WhanauMaintenance_Load(object sender, EventArgs e)
        {

        }
    }

}


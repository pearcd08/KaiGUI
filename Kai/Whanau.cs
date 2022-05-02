using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kai
{
    public partial class Whanau : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private DataTable whanauCopy;
        private CurrencyManager cmWhanau;
  


        public Whanau(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            cmWhanau = (CurrencyManager)this.BindingContext[whanauCopy];

        }

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





        //TASK A
        //ADD A NEW WHANAU RECORD
        //1. CLICK THE ADD BUTTON 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HideButtons();            
            panelAdd.Visible = true;
            panelAdd.Location = new Point(442, 50);

        }

        //2. SAVE THE NEW WHANAU RECORD
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
                    newWhanauCopyRow["FullName"] = txtAddFirstName.Text +" "+ txtAddLastName.Text;
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

        //3. CANCEL THE ADD OPERATION
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            ShowButtons();

        }

        //TASK B
        //UPDATE A WHANAU RECORD
        //1. CLICK THE UPDATE BUTTON
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

        //2. SAVE THE UPDATED RECORD
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

        //3. CANCEL THE UPDATE OPERATION
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            ShowButtons();
            panelUpdate.Visible = false;           
            
        }

        //TASK C         
        //DELETE A WHANAU RECORD

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // SEE IF THE WHANAU IS REGISTERED TO ANY EVENTS
                DataRow deleteWhanauRow = DM.dtWhanau.Rows[cmWhanau.Position];
                DataRow deleteWhanauCopyRow = whanauCopy.Rows[cmWhanau.Position];    
                DataRow[] eventRegisterRow = DM.dtEventRegister.Select("WhanauID = " + txtWhanauID.Text);
                if (eventRegisterRow.Length != 0)
                {
                    MessageBox.Show("You may only delete kai that have no event relation", "Error");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show("Whanau Record Deleted Successfully?", "Success");
                        
                        deleteWhanauCopyRow.Delete();
                        deleteWhanauRow.Delete();
                        DM.UpdateWhanau();
                       
                    }

                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }


        //OTHER FUNCTIONS

        //ALLOWS USER TO ONLY INPUT NUMBERS INTO PHONE FIELDS
        private void txtAddPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void txtUpdatePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        //DISABLES BUTTONS, PANEL AND LISTBOX     

     
        private void HideButtons()
        {
            panelDelete.Visible = false;
            listBoxWhanau.Visible = false;
            btnUp.Visible = false;
            btnDown.Visible = false; 
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
        }

        private void ShowButtons()
        {
            panelDelete.Visible = true;
            listBoxWhanau.Visible = true;
            btnUp.Visible = true;
            btnDown.Visible = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnReturn.Enabled = true;

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmWhanau.Position > 0)
            {
                --cmWhanau.Position;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmWhanau.Position < cmWhanau.Count - 1)
            {
                ++cmWhanau.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

     


        private void Whanau_Load(object sender, EventArgs e)
        {


        }



    }

}


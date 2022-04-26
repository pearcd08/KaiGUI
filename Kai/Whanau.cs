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
    public partial class Whanau : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager cmWhanau;

        public Whanau(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();           
            DM = dm;
            frmMenu = mnu;
            BindControls();


        }

        public void BindControls() 
        {
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Whanau"];


            listBoxWhanau.DataSource = DM.dsKaioordinate;
            listBoxWhanau.DisplayMember = "Whanau.FirstName";  
            listBoxWhanau.ValueMember = "Whanau.WhanauID";

       

            txtWhanauID.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.WhanauID");
            txtFirstName.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.FirstName");
            txtLastName.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.LastName");
            txtEmail.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Email");
            txtPhone.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Phone");
            txtAddress.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Address");

           

        }
        private void Whanau_Load(object sender, EventArgs e)
        {

        }

        private void disableFields() 
        {
            listBoxWhanau.Visible = false;
            txtWhanauID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void enableFields()
        {
            listBoxWhanau.Visible = true;
            txtWhanauID.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            disableFields();

            panelAdd.Visible = true;
            panelAdd.Location = new Point(442, 50);           
          
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            disableFields();

            panelUpdate.Visible = true; 
            panelUpdate.Location = new Point(442, 50);
           
            txtUpdateFirstName.Text = txtFirstName.Text.ToString();
            txtUpdateLastName.Text = txtLastName.Text.ToString();
            txtUpdateEmail.Text = txtEmail.Text.ToString(); 
            txtUpdatePhone.Text = txtPhone.Text.ToString();
            txtUpdateAddress.Text = txtAddress.Text.ToString();

        }
        //allows user to only enter numbers and backspaces
        private void txtAddPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
          
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;   
            enableFields();

        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            enableFields();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            DataRow newWhanauRow = DM.dtWhanau.NewRow();

            if ((txtAddFirstName.Text == "") || (txtAddLastName.Text == "") || (txtAddEmail.Text == "") ||
                (txtAddPhone.Text == "") || (txtAddAddress.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the Whanau text fields", "Error");
            }
            else 
            {
                newWhanauRow["FirstName"] = txtAddFirstName.Text;
                newWhanauRow["LastName"] = txtAddLastName.Text;
                newWhanauRow["Email"] = txtAddEmail.Text;
                newWhanauRow["Phone"] = txtAddPhone.Text;
                newWhanauRow["Address"] = txtAddAddress.Text;
                
                DM.dtWhanau.Rows.Add(newWhanauRow);
                DM.UpdateWhanau();

                MessageBox.Show("Whanau added successfully", "Success");
            } 

        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            DataRow updateWhanauRow = DM.dtWhanau.Rows[cmWhanau.Position];

            if ((txtAddFirstName.Text == "") || (txtAddLastName.Text == "") || (txtAddEmail.Text == "") ||
                (txtAddPhone.Text == "") || (txtAddAddress.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the Whanau text fields", "Error");
            }
            else
            {
                updateWhanauRow["FirstName"] = txtAddFirstName.Text;
                updateWhanauRow["LastName"] = txtAddLastName.Text;
                updateWhanauRow["Email"] = txtAddEmail.Text;
                updateWhanauRow["Phone"] = txtAddPhone.Text;
                updateWhanauRow["Address"] = txtAddAddress.Text;

                MessageBox.Show("Whanau updated successfully", "Success");

            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteWhanauRow = DM.dtWhanau.Rows[cmWhanau.Position];
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
                    deleteWhanauRow.Delete();
                    DM.UpdateWhanau();
                   MessageBox.Show("Whanau Record Deleted Successfully?", "Success");

                }

            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

    

   
    }

}


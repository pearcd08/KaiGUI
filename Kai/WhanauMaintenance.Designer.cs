﻿namespace Kai
{
    partial class WhanauMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhanauMaintenance));
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.listBoxWhanau = new System.Windows.Forms.ListBox();
            this.txtWhanauID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblWhanauID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnAddSave = new FontAwesome.Sharp.IconButton();
            this.lblAddressAdd = new System.Windows.Forms.Label();
            this.btnAddCancel = new FontAwesome.Sharp.IconButton();
            this.lblPhoneAdd = new System.Windows.Forms.Label();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.lblEmailAdd = new System.Windows.Forms.Label();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.lblLastNameAdd = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.lblFirstNameAdd = new System.Windows.Forms.Label();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.btnUpdateSave = new FontAwesome.Sharp.IconButton();
            this.lblAddressUpdate = new System.Windows.Forms.Label();
            this.btnUpdateCancel = new FontAwesome.Sharp.IconButton();
            this.lblPhoneUpdate = new System.Windows.Forms.Label();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.lblEmailUpdate = new System.Windows.Forms.Label();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.lblLastNameUpdate = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.lblFirstNameUpdate = new System.Windows.Forms.Label();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.panelAdd.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(755, 425);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 100);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 60;
            this.btnDelete.Location = new System.Drawing.Point(555, 425);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 60;
            this.btnUpdate.Location = new System.Drawing.Point(451, 425);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 60;
            this.btnAdd.Location = new System.Drawing.Point(347, 425);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 60;
            this.btnDown.Location = new System.Drawing.Point(231, 425);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 100);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 60;
            this.btnUp.Location = new System.Drawing.Point(40, 425);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 100);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "UP";
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // listBoxWhanau
            // 
            this.listBoxWhanau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWhanau.FormattingEnabled = true;
            this.listBoxWhanau.ItemHeight = 24;
            this.listBoxWhanau.Location = new System.Drawing.Point(40, 40);
            this.listBoxWhanau.Name = "listBoxWhanau";
            this.listBoxWhanau.Size = new System.Drawing.Size(291, 340);
            this.listBoxWhanau.TabIndex = 26;
            // 
            // txtWhanauID
            // 
            this.txtWhanauID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhanauID.Location = new System.Drawing.Point(166, 1);
            this.txtWhanauID.Name = "txtWhanauID";
            this.txtWhanauID.ReadOnly = true;
            this.txtWhanauID.Size = new System.Drawing.Size(100, 29);
            this.txtWhanauID.TabIndex = 27;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(166, 51);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(300, 29);
            this.txtFirstName.TabIndex = 28;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(166, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(300, 29);
            this.txtLastName.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(166, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(300, 29);
            this.txtEmail.TabIndex = 30;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(166, 201);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(300, 29);
            this.txtPhone.TabIndex = 31;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(166, 251);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(300, 73);
            this.txtAddress.TabIndex = 32;
            // 
            // lblWhanauID
            // 
            this.lblWhanauID.AutoSize = true;
            this.lblWhanauID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhanauID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWhanauID.Location = new System.Drawing.Point(58, 1);
            this.lblWhanauID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhanauID.Name = "lblWhanauID";
            this.lblWhanauID.Size = new System.Drawing.Size(103, 24);
            this.lblWhanauID.TabIndex = 33;
            this.lblWhanauID.Text = "Whanau ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstName.Location = new System.Drawing.Point(61, 51);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 24);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLastName.Location = new System.Drawing.Point(63, 101);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 24);
            this.lblLastName.TabIndex = 35;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(104, 151);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPhone.Location = new System.Drawing.Point(95, 201);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 24);
            this.lblPhone.TabIndex = 37;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Location = new System.Drawing.Point(81, 251);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 24);
            this.lblAddress.TabIndex = 38;
            this.lblAddress.Text = "Address";
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.btnAddSave);
            this.panelAdd.Controls.Add(this.lblAddressAdd);
            this.panelAdd.Controls.Add(this.btnAddCancel);
            this.panelAdd.Controls.Add(this.lblPhoneAdd);
            this.panelAdd.Controls.Add(this.txtAddFirstName);
            this.panelAdd.Controls.Add(this.lblEmailAdd);
            this.panelAdd.Controls.Add(this.txtAddLastName);
            this.panelAdd.Controls.Add(this.lblLastNameAdd);
            this.panelAdd.Controls.Add(this.txtAddEmail);
            this.panelAdd.Controls.Add(this.lblFirstNameAdd);
            this.panelAdd.Controls.Add(this.txtAddPhone);
            this.panelAdd.Controls.Add(this.txtAddAddress);
            this.panelAdd.Location = new System.Drawing.Point(901, 47);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(409, 345);
            this.panelAdd.TabIndex = 39;
            this.panelAdd.Visible = false;
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAddSave.IconColor = System.Drawing.Color.Black;
            this.btnAddSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSave.IconSize = 36;
            this.btnAddSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddSave.Location = new System.Drawing.Point(105, 288);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(148, 39);
            this.btnAddSave.TabIndex = 41;
            this.btnAddSave.Text = "SAVE";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // lblAddressAdd
            // 
            this.lblAddressAdd.AutoSize = true;
            this.lblAddressAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddressAdd.Location = new System.Drawing.Point(20, 201);
            this.lblAddressAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressAdd.Name = "lblAddressAdd";
            this.lblAddressAdd.Size = new System.Drawing.Size(80, 24);
            this.lblAddressAdd.TabIndex = 51;
            this.lblAddressAdd.Text = "Address";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnAddCancel.IconColor = System.Drawing.Color.Black;
            this.btnAddCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCancel.IconSize = 36;
            this.btnAddCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddCancel.Location = new System.Drawing.Point(257, 287);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(148, 39);
            this.btnAddCancel.TabIndex = 40;
            this.btnAddCancel.Text = "CANCEL";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lblPhoneAdd
            // 
            this.lblPhoneAdd.AutoSize = true;
            this.lblPhoneAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPhoneAdd.Location = new System.Drawing.Point(34, 151);
            this.lblPhoneAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneAdd.Name = "lblPhoneAdd";
            this.lblPhoneAdd.Size = new System.Drawing.Size(66, 24);
            this.lblPhoneAdd.TabIndex = 50;
            this.lblPhoneAdd.Text = "Phone";
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddFirstName.Location = new System.Drawing.Point(105, 1);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(300, 29);
            this.txtAddFirstName.TabIndex = 41;
            // 
            // lblEmailAdd
            // 
            this.lblEmailAdd.AutoSize = true;
            this.lblEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmailAdd.Location = new System.Drawing.Point(43, 101);
            this.lblEmailAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailAdd.Name = "lblEmailAdd";
            this.lblEmailAdd.Size = new System.Drawing.Size(57, 24);
            this.lblEmailAdd.TabIndex = 49;
            this.lblEmailAdd.Text = "Email";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLastName.Location = new System.Drawing.Point(105, 51);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(300, 29);
            this.txtAddLastName.TabIndex = 42;
            // 
            // lblLastNameAdd
            // 
            this.lblLastNameAdd.AutoSize = true;
            this.lblLastNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLastNameAdd.Location = new System.Drawing.Point(2, 51);
            this.lblLastNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastNameAdd.Name = "lblLastNameAdd";
            this.lblLastNameAdd.Size = new System.Drawing.Size(99, 24);
            this.lblLastNameAdd.TabIndex = 48;
            this.lblLastNameAdd.Text = "Last Name";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEmail.Location = new System.Drawing.Point(105, 101);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(300, 29);
            this.txtAddEmail.TabIndex = 43;
            // 
            // lblFirstNameAdd
            // 
            this.lblFirstNameAdd.AutoSize = true;
            this.lblFirstNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstNameAdd.Location = new System.Drawing.Point(0, 1);
            this.lblFirstNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstNameAdd.Name = "lblFirstNameAdd";
            this.lblFirstNameAdd.Size = new System.Drawing.Size(101, 24);
            this.lblFirstNameAdd.TabIndex = 47;
            this.lblFirstNameAdd.Text = "First Name";
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPhone.Location = new System.Drawing.Point(105, 151);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(300, 29);
            this.txtAddPhone.TabIndex = 44;
            this.txtAddPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddPhone_KeyPress);
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddress.Location = new System.Drawing.Point(105, 201);
            this.txtAddAddress.Multiline = true;
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(300, 73);
            this.txtAddAddress.TabIndex = 45;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.btnUpdateSave);
            this.panelUpdate.Controls.Add(this.lblAddressUpdate);
            this.panelUpdate.Controls.Add(this.btnUpdateCancel);
            this.panelUpdate.Controls.Add(this.lblPhoneUpdate);
            this.panelUpdate.Controls.Add(this.txtUpdateFirstName);
            this.panelUpdate.Controls.Add(this.lblEmailUpdate);
            this.panelUpdate.Controls.Add(this.txtUpdateLastName);
            this.panelUpdate.Controls.Add(this.lblLastNameUpdate);
            this.panelUpdate.Controls.Add(this.txtUpdateEmail);
            this.panelUpdate.Controls.Add(this.lblFirstNameUpdate);
            this.panelUpdate.Controls.Add(this.txtUpdatePhone);
            this.panelUpdate.Controls.Add(this.txtUpdateAddress);
            this.panelUpdate.Location = new System.Drawing.Point(1331, 47);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(409, 345);
            this.panelUpdate.TabIndex = 52;
            this.panelUpdate.Visible = false;
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnUpdateSave.IconColor = System.Drawing.Color.Black;
            this.btnUpdateSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateSave.IconSize = 36;
            this.btnUpdateSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateSave.Location = new System.Drawing.Point(105, 287);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(148, 39);
            this.btnUpdateSave.TabIndex = 41;
            this.btnUpdateSave.Text = "SAVE";
            this.btnUpdateSave.UseVisualStyleBackColor = false;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // lblAddressUpdate
            // 
            this.lblAddressUpdate.AutoSize = true;
            this.lblAddressUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddressUpdate.Location = new System.Drawing.Point(20, 201);
            this.lblAddressUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressUpdate.Name = "lblAddressUpdate";
            this.lblAddressUpdate.Size = new System.Drawing.Size(80, 24);
            this.lblAddressUpdate.TabIndex = 51;
            this.lblAddressUpdate.Text = "Address";
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnUpdateCancel.IconColor = System.Drawing.Color.Black;
            this.btnUpdateCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateCancel.IconSize = 36;
            this.btnUpdateCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateCancel.Location = new System.Drawing.Point(257, 288);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(148, 39);
            this.btnUpdateCancel.TabIndex = 40;
            this.btnUpdateCancel.Text = "CANCEL";
            this.btnUpdateCancel.UseVisualStyleBackColor = false;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // lblPhoneUpdate
            // 
            this.lblPhoneUpdate.AutoSize = true;
            this.lblPhoneUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPhoneUpdate.Location = new System.Drawing.Point(34, 151);
            this.lblPhoneUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneUpdate.Name = "lblPhoneUpdate";
            this.lblPhoneUpdate.Size = new System.Drawing.Size(66, 24);
            this.lblPhoneUpdate.TabIndex = 50;
            this.lblPhoneUpdate.Text = "Phone";
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateFirstName.Location = new System.Drawing.Point(105, 1);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateFirstName.TabIndex = 41;
            // 
            // lblEmailUpdate
            // 
            this.lblEmailUpdate.AutoSize = true;
            this.lblEmailUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmailUpdate.Location = new System.Drawing.Point(43, 101);
            this.lblEmailUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailUpdate.Name = "lblEmailUpdate";
            this.lblEmailUpdate.Size = new System.Drawing.Size(57, 24);
            this.lblEmailUpdate.TabIndex = 49;
            this.lblEmailUpdate.Text = "Email";
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateLastName.Location = new System.Drawing.Point(105, 51);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateLastName.TabIndex = 42;
            // 
            // lblLastNameUpdate
            // 
            this.lblLastNameUpdate.AutoSize = true;
            this.lblLastNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLastNameUpdate.Location = new System.Drawing.Point(2, 51);
            this.lblLastNameUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastNameUpdate.Name = "lblLastNameUpdate";
            this.lblLastNameUpdate.Size = new System.Drawing.Size(99, 24);
            this.lblLastNameUpdate.TabIndex = 48;
            this.lblLastNameUpdate.Text = "Last Name";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateEmail.Location = new System.Drawing.Point(105, 101);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateEmail.TabIndex = 43;
            // 
            // lblFirstNameUpdate
            // 
            this.lblFirstNameUpdate.AutoSize = true;
            this.lblFirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstNameUpdate.Location = new System.Drawing.Point(0, 1);
            this.lblFirstNameUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstNameUpdate.Name = "lblFirstNameUpdate";
            this.lblFirstNameUpdate.Size = new System.Drawing.Size(101, 24);
            this.lblFirstNameUpdate.TabIndex = 47;
            this.lblFirstNameUpdate.Text = "First Name";
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePhone.Location = new System.Drawing.Point(105, 151);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(300, 29);
            this.txtUpdatePhone.TabIndex = 44;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateAddress.Location = new System.Drawing.Point(105, 201);
            this.txtUpdateAddress.Multiline = true;
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(300, 73);
            this.txtUpdateAddress.TabIndex = 45;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(40, 40);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(291, 276);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 53;
            this.picLogo.TabStop = false;
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.lblAddress);
            this.panelDelete.Controls.Add(this.lblPhone);
            this.panelDelete.Controls.Add(this.lblEmail);
            this.panelDelete.Controls.Add(this.lblLastName);
            this.panelDelete.Controls.Add(this.lblFirstName);
            this.panelDelete.Controls.Add(this.lblWhanauID);
            this.panelDelete.Controls.Add(this.txtAddress);
            this.panelDelete.Controls.Add(this.txtPhone);
            this.panelDelete.Controls.Add(this.txtEmail);
            this.panelDelete.Controls.Add(this.txtLastName);
            this.panelDelete.Controls.Add(this.txtFirstName);
            this.panelDelete.Controls.Add(this.txtWhanauID);
            this.panelDelete.Location = new System.Drawing.Point(385, 40);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(467, 355);
            this.panelDelete.TabIndex = 54;
            // 
            // WhanauMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1959, 561);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.listBoxWhanau);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "WhanauMaintenance";
            this.Text = "Whanau Maintenance";
            this.Load += new System.EventHandler(this.WhanauMaintenance_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.ListBox listBoxWhanau;
        private System.Windows.Forms.TextBox txtWhanauID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblWhanauID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label lblAddressAdd;
        private System.Windows.Forms.Label lblPhoneAdd;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.Label lblEmailAdd;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label lblLastNameAdd;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label lblFirstNameAdd;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.TextBox txtAddAddress;
        private FontAwesome.Sharp.IconButton btnAddSave;
        private FontAwesome.Sharp.IconButton btnAddCancel;
        private System.Windows.Forms.Panel panelUpdate;
        private FontAwesome.Sharp.IconButton btnUpdateSave;
        private System.Windows.Forms.Label lblAddressUpdate;
        private FontAwesome.Sharp.IconButton btnUpdateCancel;
        private System.Windows.Forms.Label lblPhoneUpdate;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label lblEmailUpdate;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label lblLastNameUpdate;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label lblFirstNameUpdate;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelDelete;
    }
}
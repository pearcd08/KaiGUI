namespace Kai
{
    partial class KaiMaintenance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaiMaintenance));
            this.listBoxKai = new System.Windows.Forms.ListBox();
            this.kAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKaioordinate = new Kai.dsKaioordinate();
            this.txtKaiID = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtKaiName = new System.Windows.Forms.TextBox();
            this.lblKaiID = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblKaiName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPreperationTime = new System.Windows.Forms.Label();
            this.lblPreperation = new System.Windows.Forms.Label();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.txtPreperationTime = new System.Windows.Forms.TextBox();
            this.txtServingQuantity = new System.Windows.Forms.TextBox();
            this.txtPreperation = new System.Windows.Forms.TextBox();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.cbxPreparation = new System.Windows.Forms.CheckBox();
            this.numServingQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPreparationTime = new System.Windows.Forms.NumericUpDown();
            this.txtEventID = new System.Windows.Forms.Panel();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.txtKaiNameAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtEventID2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaioordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreparationTime)).BeginInit();
            this.txtEventID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxKai
            // 
            this.listBoxKai.FormattingEnabled = true;
            this.listBoxKai.Location = new System.Drawing.Point(25, 50);
            this.listBoxKai.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxKai.Name = "listBoxKai";
            this.listBoxKai.Size = new System.Drawing.Size(291, 277);
            this.listBoxKai.TabIndex = 0;
            this.listBoxKai.SelectedIndexChanged += new System.EventHandler(this.listBoxKai_SelectedIndexChanged);
            // 
            // kAIBindingSource
            // 
            this.kAIBindingSource.DataMember = "KAI";
            this.kAIBindingSource.DataSource = this.dsKaioordinate;
            // 
            // dsKaioordinate
            // 
            this.dsKaioordinate.DataSetName = "dsKaioordinate";
            this.dsKaioordinate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtKaiID
            // 
            this.txtKaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKaiID.Location = new System.Drawing.Point(550, 50);
            this.txtKaiID.Margin = new System.Windows.Forms.Padding(2);
            this.txtKaiID.Name = "txtKaiID";
            this.txtKaiID.ReadOnly = true;
            this.txtKaiID.Size = new System.Drawing.Size(100, 29);
            this.txtKaiID.TabIndex = 1;
            // 
            // txtEvent
            // 
            this.txtEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent.Location = new System.Drawing.Point(551, 98);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(2);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.ReadOnly = true;
            this.txtEvent.Size = new System.Drawing.Size(300, 29);
            this.txtEvent.TabIndex = 2;
            // 
            // txtKaiName
            // 
            this.txtKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKaiName.Location = new System.Drawing.Point(550, 150);
            this.txtKaiName.Margin = new System.Windows.Forms.Padding(2);
            this.txtKaiName.Name = "txtKaiName";
            this.txtKaiName.ReadOnly = true;
            this.txtKaiName.Size = new System.Drawing.Size(300, 29);
            this.txtKaiName.TabIndex = 5;
            // 
            // lblKaiID
            // 
            this.lblKaiID.AutoSize = true;
            this.lblKaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKaiID.Location = new System.Drawing.Point(488, 53);
            this.lblKaiID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaiID.Name = "lblKaiID";
            this.lblKaiID.Size = new System.Drawing.Size(58, 24);
            this.lblKaiID.TabIndex = 7;
            this.lblKaiID.Text = "Kai ID";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEvent.Location = new System.Drawing.Point(488, 103);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(58, 24);
            this.lblEvent.TabIndex = 8;
            this.lblEvent.Text = "Event";
            // 
            // lblKaiName
            // 
            this.lblKaiName.AutoSize = true;
            this.lblKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKaiName.Location = new System.Drawing.Point(454, 153);
            this.lblKaiName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaiName.Name = "lblKaiName";
            this.lblKaiName.Size = new System.Drawing.Size(92, 24);
            this.lblKaiName.TabIndex = 9;
            this.lblKaiName.Text = "Kai Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(399, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Serving Quantity";
            // 
            // lblPreperationTime
            // 
            this.lblPreperationTime.AutoSize = true;
            this.lblPreperationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreperationTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreperationTime.Location = new System.Drawing.Point(391, 252);
            this.lblPreperationTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreperationTime.Name = "lblPreperationTime";
            this.lblPreperationTime.Size = new System.Drawing.Size(155, 24);
            this.lblPreperationTime.TabIndex = 11;
            this.lblPreperationTime.Text = "Preperation Time";
            // 
            // lblPreperation
            // 
            this.lblPreperation.AutoSize = true;
            this.lblPreperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreperation.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreperation.Location = new System.Drawing.Point(429, 203);
            this.lblPreperation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreperation.Name = "lblPreperation";
            this.lblPreperation.Size = new System.Drawing.Size(117, 24);
            this.lblPreperation.TabIndex = 12;
            this.lblPreperation.Text = "Preperation?";
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 60;
            this.btnUp.Location = new System.Drawing.Point(25, 409);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 100);
            this.btnUp.TabIndex = 13;
            this.btnUp.Text = "UP";
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.iconUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 60;
            this.btnDown.Location = new System.Drawing.Point(216, 409);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 100);
            this.btnDown.TabIndex = 14;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.iconDown_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 60;
            this.btnAdd.Location = new System.Drawing.Point(342, 409);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.iconAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 60;
            this.btnUpdate.Location = new System.Drawing.Point(446, 409);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 60;
            this.btnDelete.Location = new System.Drawing.Point(550, 409);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(750, 409);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 100);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.iconReturn_Click);
            // 
            // txtPreperationTime
            // 
            this.txtPreperationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreperationTime.Location = new System.Drawing.Point(551, 249);
            this.txtPreperationTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreperationTime.Name = "txtPreperationTime";
            this.txtPreperationTime.ReadOnly = true;
            this.txtPreperationTime.Size = new System.Drawing.Size(100, 29);
            this.txtPreperationTime.TabIndex = 19;
            // 
            // txtServingQuantity
            // 
            this.txtServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServingQuantity.Location = new System.Drawing.Point(551, 297);
            this.txtServingQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtServingQuantity.Name = "txtServingQuantity";
            this.txtServingQuantity.ReadOnly = true;
            this.txtServingQuantity.Size = new System.Drawing.Size(100, 29);
            this.txtServingQuantity.TabIndex = 20;
            // 
            // txtPreperation
            // 
            this.txtPreperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreperation.Location = new System.Drawing.Point(551, 203);
            this.txtPreperation.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreperation.Name = "txtPreperation";
            this.txtPreperation.ReadOnly = true;
            this.txtPreperation.Size = new System.Drawing.Size(100, 29);
            this.txtPreperation.TabIndex = 21;
            // 
            // cboEvent
            // 
            this.cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(165, 16);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(300, 32);
            this.cboEvent.TabIndex = 22;
            // 
            // cbxPreparation
            // 
            this.cbxPreparation.AutoSize = true;
            this.cbxPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbxPreparation.Location = new System.Drawing.Point(165, 122);
            this.cbxPreparation.Name = "cbxPreparation";
            this.cbxPreparation.Size = new System.Drawing.Size(15, 14);
            this.cbxPreparation.TabIndex = 23;
            this.cbxPreparation.UseVisualStyleBackColor = true;
            // 
            // numServingQuantity
            // 
            this.numServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numServingQuantity.Location = new System.Drawing.Point(165, 210);
            this.numServingQuantity.Name = "numServingQuantity";
            this.numServingQuantity.Size = new System.Drawing.Size(100, 29);
            this.numServingQuantity.TabIndex = 24;
            // 
            // numPreparationTime
            // 
            this.numPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPreparationTime.Location = new System.Drawing.Point(165, 167);
            this.numPreparationTime.Name = "numPreparationTime";
            this.numPreparationTime.Size = new System.Drawing.Size(100, 29);
            this.numPreparationTime.TabIndex = 25;
            // 
            // txtEventID
            // 
            this.txtEventID.Controls.Add(this.lblMinutes);
            this.txtEventID.Controls.Add(this.btnSave);
            this.txtEventID.Controls.Add(this.label6);
            this.txtEventID.Controls.Add(this.btnCancel);
            this.txtEventID.Controls.Add(this.txtKaiNameAdd);
            this.txtEventID.Controls.Add(this.label5);
            this.txtEventID.Controls.Add(this.label4);
            this.txtEventID.Controls.Add(this.label2);
            this.txtEventID.Controls.Add(this.label1);
            this.txtEventID.Controls.Add(this.numPreparationTime);
            this.txtEventID.Controls.Add(this.numServingQuantity);
            this.txtEventID.Controls.Add(this.cbxPreparation);
            this.txtEventID.Controls.Add(this.cboEvent);
            this.txtEventID.Location = new System.Drawing.Point(886, 66);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(507, 354);
            this.txtEventID.TabIndex = 27;
            this.txtEventID.Visible = false;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMinutes.Location = new System.Drawing.Point(270, 172);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(76, 24);
            this.lblMinutes.TabIndex = 30;
            this.lblMinutes.Text = "minutes";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 36;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(117, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 39);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(68, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kai Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 36;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.Location = new System.Drawing.Point(317, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 39);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtKaiNameAdd
            // 
            this.txtKaiNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKaiNameAdd.Location = new System.Drawing.Point(165, 66);
            this.txtKaiNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtKaiNameAdd.Name = "txtKaiNameAdd";
            this.txtKaiNameAdd.Size = new System.Drawing.Size(300, 29);
            this.txtKaiNameAdd.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(102, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Event";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(43, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Preperation?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Serving Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Preperation Time";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(25, 50);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(291, 276);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 28;
            this.picLogo.TabStop = false;
            // 
            // txtEventID2
            // 
            this.txtEventID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID2.Location = new System.Drawing.Point(342, 80);
            this.txtEventID2.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventID2.Name = "txtEventID2";
            this.txtEventID2.ReadOnly = true;
            this.txtEventID2.Size = new System.Drawing.Size(100, 29);
            this.txtEventID2.TabIndex = 29;
            // 
            // KaiMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1293, 561);
            this.Controls.Add(this.txtEventID2);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.txtPreperation);
            this.Controls.Add(this.txtServingQuantity);
            this.Controls.Add(this.txtPreperationTime);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblPreperation);
            this.Controls.Add(this.lblPreperationTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKaiName);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblKaiID);
            this.Controls.Add(this.txtKaiName);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtKaiID);
            this.Controls.Add(this.listBoxKai);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KaiMaintenance";
            this.Text = " Kaioordinate - Community Event Management Software                             ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.KaiMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaioordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServingQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreparationTime)).EndInit();
            this.txtEventID.ResumeLayout(false);
            this.txtEventID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKai;
        private System.Windows.Forms.TextBox txtKaiID;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtKaiName;
        private System.Windows.Forms.Label lblKaiID;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblKaiName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPreperationTime;
        private System.Windows.Forms.Label lblPreperation;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.TextBox txtPreperationTime;
        private System.Windows.Forms.TextBox txtServingQuantity;
        private System.Windows.Forms.TextBox txtPreperation;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.CheckBox cbxPreparation;
        private System.Windows.Forms.NumericUpDown numServingQuantity;
        private System.Windows.Forms.NumericUpDown numPreparationTime;
        private System.Windows.Forms.Panel txtEventID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKaiNameAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinutes;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.BindingSource kAIBindingSource;
        private dsKaioordinate dsKaioordinate;
        private System.Windows.Forms.TextBox txtEventID2;
    }
}
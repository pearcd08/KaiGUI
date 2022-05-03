namespace Kai
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.dgvWhanau = new System.Windows.Forms.DataGridView();
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.cboxKai = new System.Windows.Forms.CheckBox();
            this.dsKaioordinate = new Kai.dsKaioordinate();
            this.eVENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wHANAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVENTREGISTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblWhanau = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblRegistrations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhanau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaioordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wHANAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTREGISTERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(30, 51);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(400, 200);
            this.dgvEvents.TabIndex = 0;
            // 
            // dgvWhanau
            // 
            this.dgvWhanau.AllowUserToAddRows = false;
            this.dgvWhanau.AllowUserToDeleteRows = false;
            this.dgvWhanau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWhanau.Location = new System.Drawing.Point(455, 51);
            this.dgvWhanau.Name = "dgvWhanau";
            this.dgvWhanau.ReadOnly = true;
            this.dgvWhanau.RowHeadersVisible = false;
            this.dgvWhanau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWhanau.Size = new System.Drawing.Size(400, 200);
            this.dgvWhanau.TabIndex = 1;
            // 
            // dgvRegister
            // 
            this.dgvRegister.AllowUserToAddRows = false;
            this.dgvRegister.AllowUserToDeleteRows = false;
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegister.Location = new System.Drawing.Point(30, 310);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.ReadOnly = true;
            this.dgvRegister.RowHeadersVisible = false;
            this.dgvRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegister.Size = new System.Drawing.Size(400, 200);
            this.dgvRegister.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(755, 410);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 100);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 60;
            this.btnDelete.Location = new System.Drawing.Point(559, 410);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 60;
            this.btnAdd.Location = new System.Drawing.Point(455, 410);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboxKai
            // 
            this.cboxKai.AutoSize = true;
            this.cboxKai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKai.ForeColor = System.Drawing.SystemColors.Control;
            this.cboxKai.Location = new System.Drawing.Point(455, 310);
            this.cboxKai.Name = "cboxKai";
            this.cboxKai.Size = new System.Drawing.Size(245, 28);
            this.cboxKai.TabIndex = 29;
            this.cboxKai.Text = "Kai Preperation Assistant?";
            this.cboxKai.UseVisualStyleBackColor = true;
            // 
            // dsKaioordinate
            // 
            this.dsKaioordinate.DataSetName = "dsKaioordinate";
            this.dsKaioordinate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eVENTBindingSource
            // 
            this.eVENTBindingSource.DataMember = "EVENT";
            this.eVENTBindingSource.DataSource = this.dsKaioordinate;
            // 
            // wHANAUBindingSource
            // 
            this.wHANAUBindingSource.DataMember = "WHANAU";
            this.wHANAUBindingSource.DataSource = this.dsKaioordinate;
            // 
            // eVENTREGISTERBindingSource
            // 
            this.eVENTREGISTERBindingSource.DataMember = "EVENTREGISTER";
            this.eVENTREGISTERBindingSource.DataSource = this.dsKaioordinate;
            // 
            // lblWhanau
            // 
            this.lblWhanau.AutoSize = true;
            this.lblWhanau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblWhanau.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWhanau.Location = new System.Drawing.Point(451, 24);
            this.lblWhanau.Name = "lblWhanau";
            this.lblWhanau.Size = new System.Drawing.Size(81, 24);
            this.lblWhanau.TabIndex = 31;
            this.lblWhanau.Text = "Whanau";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEvents.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEvents.Location = new System.Drawing.Point(26, 24);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(67, 24);
            this.lblEvents.TabIndex = 30;
            this.lblEvents.Text = "Events";
            // 
            // lblRegistrations
            // 
            this.lblRegistrations.AutoSize = true;
            this.lblRegistrations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRegistrations.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegistrations.Location = new System.Drawing.Point(26, 283);
            this.lblRegistrations.Name = "lblRegistrations";
            this.lblRegistrations.Size = new System.Drawing.Size(117, 24);
            this.lblRegistrations.TabIndex = 32;
            this.lblRegistrations.Text = "Registrations";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblRegistrations);
            this.Controls.Add(this.lblWhanau);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.cboxKai);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvRegister);
            this.Controls.Add(this.dgvWhanau);
            this.Controls.Add(this.dgvEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Maintenance";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhanau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaioordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wHANAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTREGISTERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridView dgvWhanau;
        private System.Windows.Forms.DataGridView dgvRegister;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.CheckBox cboxKai;
        private System.Windows.Forms.BindingSource eVENTBindingSource;
        private dsKaioordinate dsKaioordinate;
        private System.Windows.Forms.BindingSource wHANAUBindingSource;
        private System.Windows.Forms.BindingSource eVENTREGISTERBindingSource;
        private System.Windows.Forms.Label lblWhanau;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblRegistrations;
    }
}
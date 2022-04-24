﻿using System;
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
    public partial class DataModule : Form
    {
        public DataTable dtKai;
        public DataTable dtEvent;
        public DataTable dtLocation;
        public DataTable dtWhanau;
        public DataTable dtEventRegister;

        public DataView kaiView;
        public DataView eventView;
        public DataView locationView;
        public DataView whanauView;
        public DataView eventRegisterView;
        

        public DataModule()
        {
            InitializeComponent();
            dsKaioordinate.EnforceConstraints = false;
            
            daKai.Fill(dsKaioordinate);
            daEvent.Fill(dsKaioordinate);
            daLocation.Fill(dsKaioordinate);
            daWhanau.Fill(dsKaioordinate);  
            daEventRegister.Fill(dsKaioordinate);

            dtKai = dsKaioordinate.Tables["Kai"];
            dtEvent = dsKaioordinate.Tables["Event"];
            dtLocation = dsKaioordinate.Tables["Location"];
            dtWhanau = dsKaioordinate.Tables["Whanau"];
            dtEventRegister = dsKaioordinate.Tables["EventRegister"];

            dsKaioordinate.EnforceConstraints = true;

        }

        public void UpdateKai() 
        {
            daKai.Update(dtKai);    
        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        }
    }
}

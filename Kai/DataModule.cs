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

            kaiView = new DataView(dtKai);
            kaiView.Sort = "KaiID";
            eventView = new DataView(dtEvent);
            eventView.Sort = "EventID";
            locationView = new DataView(dtLocation);    
            locationView.Sort = "LocationID";
            whanauView = new DataView(dtWhanau);
            whanauView.Sort = "WhanauID";
            eventRegisterView = new DataView(dtEventRegister);
            eventRegisterView.Sort = "RegistrationID";

            dsKaioordinate.EnforceConstraints = true;

        }

        public void UpdateKai() 
        {
            daKai.Update(dtKai);    
        }

        public void UpdateWhanau() 
        {
            daWhanau.Update(dtWhanau);
        }

        public void UpdateEventRegister() 
        {
            daEventRegister.Update(dtEventRegister);
        }

        public void UpdateLocation() 
        {
            daLocation.Update(dtLocation);
       }

        public void UpdateEvent() 
        {
            daEvent.Update(dtEvent);
        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        } 
    }
}

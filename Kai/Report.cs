using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kai
{
    public partial class Report : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager cmEvent;
        private CurrencyManager cmLocation;
        private CurrencyManager cmEventRegister;
        private CurrencyManager cmWhanau;
        private DataRow[] filteredEvent;
        int pagesToPrint, pagesExpected;

        public Report(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT"];
            cmEventRegister = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENTREGISTER"];
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "LOCATION"];
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "WHANAU"];
        }



        private void iconReturn_Click(object sender, EventArgs e)
        {
            if (frmMenu == null)
            {
                frmMenu = new MainMenu();
            }
            frmMenu.ShowDialog();

        }

        private void iconPrint_Click(object sender, EventArgs e)
        {
            DataTable filteredTable = new DataTable();
            DataColumn newColumn = new DataColumn("EventID", typeof(Int32));
            filteredTable.Columns.Add(newColumn);

            int tableCount = 0;
            pagesToPrint = 0;

            foreach (DataRow drEvent in DM.dtEvent.Rows)
            {   //GET THE EVENT ID FROM EACH ROW AND CONVERT TO INT                            
                int aEventID = Convert.ToInt32(drEvent["EventID"].ToString());
                //SELECT ALL ROWS THAT HAVE THAT ID IN THE EVENTREGISTER TABLE
                DataRow[] eventRegisterRow = DM.dtEventRegister.Select("EventID = " + aEventID);
                //IF THE ID EXISTS IN THE EVENT REGISTER TABLE THEN ADD THE CURRENT EVENT ID INTO THE DATATABLE
                if (eventRegisterRow.Length > 0)
                {
                    //CREATE A NEW ROW FOR THE TABLE
                    DataRow dr = filteredTable.NewRow();
                    dr[0] = aEventID;
                    //ADD THE NEW ROW TO THE BOTTOM OF THE TABLE
                    filteredTable.Rows.Add(dr);
                    //INCREASE THE TABLE COUNT
                    tableCount++;

                }

            }
            //ADD ALL THE RESULTS OF THE DATATABLE TO A NEW DATAROW
            filteredEvent = filteredTable.Select();
            //SET THE PAGES EXPECTED INT TO THE AMOUNT OF ROWS IN THE FILTERED TABLE
            pagesExpected = tableCount;
            printPreviewDialog.ShowDialog();

        }


        private void printEvents_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //font styles
            Graphics g = e.Graphics;
            int linesSoFar = 0;
            Font textFont = new Font("Arial", 12, FontStyle.Regular);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            int textHeight = textFont.Height + 2;

            //currency manager binding context


            Brush brush = new SolidBrush(Color.Black);

            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int midMargin = 200;
            int phoneMargin = 375;
            int helperMargin = 500;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //CONVERT THE DATAROW CREATED ABOVE INTO A NEW DATAROW 
            //FIND INDEX OF ROW TO PRINT BY HOW MANY PAGES HAVE BEEN PRINTED
            DataRow fEvent = filteredEvent[pagesToPrint];

            //TAKE THE EVENTID FROM THE NEW DATAROW AND USE IT TO NAVIGATE THE EVENT CURRENCY MANAGER
            int aEventID = Convert.ToInt32(fEvent["EventID"].ToString());
            cmEvent.Position = DM.eventView.Find(aEventID);
            DataRow drEvent = DM.dtEvent.Rows[cmEvent.Position];


            //heading
            //event id
            g.DrawString("Event ID: " + drEvent["EventID"], boldFont, brush, leftMargin + headingLeftMargin,
                          topMargin + (linesSoFar * textHeight));
            linesSoFar++;
            linesSoFar++;
            //event name
            g.DrawString("Event Name: ", boldFont, brush, leftMargin + headingLeftMargin,
                          topMargin + (linesSoFar * textHeight));
            g.DrawString(drEvent["EventName"].ToString(), textFont, brush, leftMargin + midMargin,
                        topMargin + (linesSoFar * textHeight));
            linesSoFar++;
            //event date
            g.DrawString("Date: ", boldFont, brush, leftMargin + headingLeftMargin,
                          topMargin + (linesSoFar * textHeight));
            g.DrawString(drEvent["EventDate"].ToString(), textFont, brush, leftMargin + midMargin,
                          topMargin + (linesSoFar * textHeight));
            linesSoFar++;

            //get location information
            int aLocationID = Convert.ToInt32(drEvent["LocationID"].ToString());
            cmLocation.Position = DM.locationView.Find(aLocationID);
            DataRow drLocation = DM.dtLocation.Rows[cmLocation.Position];

            //location name
            g.DrawString("Location: ", boldFont, brush, leftMargin + headingLeftMargin,
                         topMargin + (linesSoFar * textHeight));
            g.DrawString(drLocation["LocationName"].ToString(), textFont, brush, leftMargin + midMargin,
                        topMargin + (linesSoFar * textHeight));
            linesSoFar++;
            //location address
            g.DrawString("Address: ", boldFont, brush, leftMargin + headingLeftMargin,
                         topMargin + (linesSoFar * textHeight));
            g.DrawString(drLocation["Address"].ToString(), textFont, brush, leftMargin + midMargin,
                         topMargin + (linesSoFar * textHeight));
            linesSoFar++;
            linesSoFar++;
            //Antendees
            g.DrawString("Attendees: ", boldFont, brush, leftMargin + headingLeftMargin,
                         topMargin + (linesSoFar * textHeight));
            linesSoFar++;
            linesSoFar++;
            //Column names
            g.DrawString("First Name", boldFont, brush, leftMargin + headingLeftMargin,
                         topMargin + (linesSoFar * textHeight));
            g.DrawString("Last Name", boldFont, brush, leftMargin + midMargin,
                         topMargin + (linesSoFar * textHeight));
            g.DrawString("Phone No.", boldFont, brush, leftMargin + phoneMargin,
                         topMargin + (linesSoFar * textHeight));
            g.DrawString("Helper", boldFont, brush, leftMargin + helperMargin,
                         topMargin + (linesSoFar * textHeight));
            linesSoFar++;
            linesSoFar++;

            //get the whanau associated with each event
            DataRow[] drRegistrations = drEvent.GetChildRows(DM.dtEvent.ChildRelations["EVENT_EVENTREGISTER"]);
            if (drRegistrations.Length > 0)
            {
                //loop through the whanau attending the event                       
                foreach (DataRow drEventRegister in drRegistrations)
                {
                    string whanauText = "";
                    //use whanau id from eventregister to find the parent record in whanau
                    int aWhanauID = Convert.ToInt32(drEventRegister["WhanauID"].ToString());
                    cmWhanau.Position = DM.whanauView.Find(aWhanauID);
                    DataRow drWhanau = DM.dtWhanau.Rows[cmWhanau.Position];

                    g.DrawString(drWhanau["FirstName"].ToString(), textFont, brush, (leftMargin + headingLeftMargin), (topMargin + (linesSoFar * textHeight)));
                    g.DrawString(drWhanau["LastName"].ToString(), textFont, brush, (leftMargin + midMargin), (topMargin + (linesSoFar * textHeight)));
                    g.DrawString(drWhanau["Phone"].ToString(), textFont, brush, (leftMargin + phoneMargin), (topMargin + (linesSoFar * textHeight)));
                    g.DrawString(drEventRegister["KaiPreparation"].ToString(), textFont, brush, (leftMargin + helperMargin), (topMargin + (linesSoFar * textHeight)));
                    linesSoFar++;

                }


            }
            pagesToPrint++;
            if (pagesToPrint != pagesExpected)
            {
                e.HasMorePages = true;
            }
            else if (pagesToPrint == pagesExpected)
            {
                e.HasMorePages = false;
            }

        }





        private void printPreviewDialog_Load(object sender, EventArgs e)
        {

        }
        private void Report_Load(object sender, EventArgs e)
        {

        }

    }
}


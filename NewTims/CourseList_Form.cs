using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Runtime;
using System.Windows.Forms;

namespace NewTims
{
    public partial class CourseList_Form : Form
    {
        public CourseList_Form()
        {
            InitializeComponent();
        }
        public void Subscribing()
        {
            //CourseList_dataListView.CellClick += CourseList_dataListView_CellClick;
            CourseList_dataListView.ShowGroups = false;
            CourseList_dataListView.AutoResizeColumns();

        }

        private void FillDataListView()
        {
            const int Z_rows = 14;
            string sSql = "SELECT Top " + Z_rows.ToString() + " CourseID,Sjcode,CourseNo,SjVersion,Remarks "
                + "FROM Student "
                + "Where Cast(Surname as char(50))+Cast(GivenName as char(50))+Cast(MiddleName as char(50))+Cast(StudentID as char(10))>'"
                + "' "
                + "Order by Surname,GivenName,MiddleName,StudentID";

            OleDbConnection myConnection = new OleDbConnection("Provider=MSOLEDBSQL;Server=localHost;Database=" + "TIMS" + ";Trusted_Connection=yes;");
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sSql, myConnection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Student_table");
            myConnection.Close();
            CourseList_dataListView.DataSource = ds;
            CourseList_dataListView.DataMember = "Student_table";
            //CourseList_dataListView.AutoResizeColumns();
            //CourseList_dataListView.ShowGroups = false;
            //CourseList_dataListView.CellClick += CourseList_dataListView_CellClick;

        }


        private void CourseList_Form_Load(object sender, EventArgs e)
        {

        }
        private void CourseList_Form_Load_1(object sender, EventArgs e)
        {
            FillDataListView();
            Subscribing();
        }

    }
}

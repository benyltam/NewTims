using System;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace NewTims
{
    public partial class Student_Form : Form
    {
        const string z_FieldNames = "StudentID, Name, MiddleName, ChiName, Sex, ContactPerson, Remark"; // LastTxnDate, RegisterDate";
        const string z_SelectCmd = "Select Top 1 " + z_FieldNames + " From Student Where left(Name+replicate(' ',100),100) + Format(StudentID, '000000')";
        const string z_WhereCause = " Order By Name, StudentID";
        const string z_Fields = "SubjectID, CourseID, Format(EnrolDate,'dd/MM/yyyy') as EnrolDate, Absence, Remark";
        static string s_Name = "";
        static readonly string s_ContactPerson = "";
        static string s_Remark = "";
        static string s_StudentID = "159";
        static readonly string s_Sex = "";
        static string sSql = "";
        static readonly OleDbConnection myConnection = new OleDbConnection("Provider=MSOLEDBSQL;Server=localHost;Database=" + "TIMS" + ";Trusted_Connection=yes;");
        static readonly lib lib=new lib();

        public Student_Form(string e)
        {
            if (e != string.Empty)
                s_StudentID = e;

            InitializeComponent();
            this.Load += new System.EventHandler(Student_Form_Load);
            //Load += OnLoad;
        }

        private void Student_Form_Load(object sender, EventArgs e)
        {
            RetrieveStudent();
            FillData();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Student_Form_Load(sender, EventArgs.Empty);
        }

        private void RetrieveStudent()
        {
            if (s_StudentID == string.Empty)
                sSql = "Select Top 1 " + z_FieldNames + " from Student Order by Name, StudentID";
            else
                sSql = "Select Top 1 " + z_FieldNames + " from Student Where StudentID = " + s_StudentID + " Order by Name, StudentID";

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sSql, myConnection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Student_table");
            s_Name = ds.Tables["Student_table"].Rows[0]["Name"].ToString();
            s_Remark = ds.Tables["Student_table"].Rows[0]["Remark"].ToString();
            if (ds.Tables.Count > 0)
            {
                var table = ds.Tables[0];
                var m_StudentID = table.AsEnumerable().Select(x => x.Field<int>("StudentID")).FirstOrDefault();
                s_StudentID = m_StudentID.ToString("000000");
            }
            else
            {
                Course_listViewCustom.DataSource = ds;
            }

            Surname_textBox.Text = int.Parse(s_StudentID).ToString("000000");
            Remark_textBox.Text = s_Remark;
            ContactPerson_textBox.Text = s_ContactPerson;
            
            Sex_comboBox.Text = s_Sex;
        }
        private void FillData()
        {
            string sSql;
            sSql = "SELECT " + z_Fields +
                " FROM StudentIDCourse" +
                " Where StudentID = '" + s_StudentID + "' Order By EnrolDate";

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sSql, myConnection);
            DataSet ds1 = new DataSet();
            dataadapter.Fill(ds1, "Course_listViewCustom_table");

            if (ds1.Tables.Count < 1)
            {
                DataTable dt = new DataTable("MyTable");

                dt.Columns.Add(new DataColumn("SubjectID", typeof(string)));
                dt.Columns.Add(new DataColumn("CourseID", typeof(string)));
                dt.Columns.Add(new DataColumn("EnrolDate", typeof(string)));
                dt.Columns.Add(new DataColumn("Absence", typeof(string)));
                dt.Columns.Add(new DataColumn("Remark", typeof(string)));

                DataRow dr = dt.NewRow();
                dr["SubjectID"] = "";
                dr["CourseID"] = "";
                dr["EnrolDate"] = "";
                dr["Absence"] = "";
                dr["Remark"] = "";

                dt.Rows.Add(dr);
                ds1.Tables.Add(dt);
            }
            //dataadapter.Fill(ds1, "Course_listViewCustom_table");
            //myConnection.Close();
            Course_listViewCustom.DataSource = ds1;
            Course_listViewCustom.DataMember = "Course_listViewCustom_table";
            FormatDataListView();
        }

        private void FormatDataListView()
        {
            Course_listViewCustom.Columns[0].Width = 52;
            Course_listViewCustom.Columns[1].Width = 64;
            Course_listViewCustom.Columns[2].Width = 70;
            Course_listViewCustom.Columns[3].Width = 80;
            Course_listViewCustom.Columns[4].Width = 80;

            Course_listViewCustom.Columns[0].Text = "Subject";
            Course_listViewCustom.Columns[1].Text = "Course No.";
            Course_listViewCustom.Columns[2].Text = "Enrol Date";
            Course_listViewCustom.Columns[3].Text = "Absent Classes";
            Course_listViewCustom.Columns[4].Text = "Remark";

            Course_listViewCustom.OwnerDraw = true;
            Course_listViewCustom.Columns[0].TextAlign = HorizontalAlignment.Left;

            Course_listViewCustom.OwnerDraw = true;
            Course_listViewCustom.ShowGroups = false;

            Surname_textBox.Text = s_Name;
            switch (Sex)
            {
                case = 'O'
                Sex_comboBox.Text =
            }
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            string sSql =z_SelectCmd + "> '" + (s_Name + lib.String(" ", 100)).Substring(0, 100) + int.Parse(s_StudentID).ToString("000000") + "'" + z_WhereCause;
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sSql, myConnection);
            DataSet ds1 = new DataSet();
            dataadapter.Fill(ds1, "Student_table");
            if (ds1.Tables.Count > 0)
            {
                s_StudentID = ds1.Tables["Student_table"].Rows[0]["StudentID"].ToString();
                s_Name = ds1.Tables["Student_table"].Rows[0]["Name"].ToString();
            }
            FillData();

        }
    }
}

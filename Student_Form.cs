using System;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Library;

namespace NewTims
{
    public partial class Student_Form : BaseForm
    {
        const string z_FieldNames = "StudentID, Name, MiddleName, ChiName, Sex, ContactPerson, Remark"; // LastTxnDate, RegisterDate";
        const string z_SelectCmd = "Select Top 1 " + z_FieldNames + " From Student Where left(Name+replicate(' ',100),100) + Format(StudentID, '000000')";
        const string z_Fields = "SubjectID, CourseID, Format(EnrolDate,'dd/MM/yyyy') as EnrolDate, Absence, Remark";
        static string s_Name = "";
        static string m_ContactPerson = "";
        static string s_Remark = "";
        static string s_StudentID = "";
        static string s_Sex = "";
        static string sSql = "";
        static readonly OleDbConnection myConnection = new OleDbConnection("Provider=MSOLEDBSQL;Server=localHost;Database=" + "TIMS" + ";Trusted_Connection=yes;");
        //private Lib lib;

        public Student_Form(string e)
        {
            if (e != string.Empty)
                s_StudentID = e;

            InitializeComponent();
            //Lib lib = new Lib();
            //Load += OnLoad;
            this.Load += new System.EventHandler(Student_Form_Load);
        }

        private void Student_Form_Load(object sender, EventArgs e)
        {
            RetrieveStudent('=');
            FillData();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Student_Form_Load(sender, EventArgs.Empty);
        }

        private void RetrieveStudent(char Operator)
        {
            if (s_StudentID == string.Empty)
                sSql = "Select Top 1 " + z_FieldNames + " from Student Order by Name, StudentID";
            else
            {
                switch (Operator)
                {
                    case var x when x == '=':
                        sSql = "Select Top 1 " + z_FieldNames + " from Student Where StudentID = " + s_StudentID + " Order by StudentID";
                        break;
                    default:
                        string s_OrderClause;
                        if (Operator == '>')
                            { s_OrderClause = "Order By Name Asc, StudentID Asc"; }
                        else
                            { s_OrderClause = "Order By Name Desc, StudentID Desc"; ; }
                        sSql = z_SelectCmd + Operator + " '" + (s_Name + (" ", 100)).Substring(0, 100) + int.Parse(s_StudentID).ToString("000000") + "'" 
                            + s_OrderClause;
                        break;
                }

            }

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sSql, myConnection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Student_table");
            s_Name = ds.Tables["Student_table"].Rows[0]["Name"].ToString();
            s_Remark = ds.Tables["Student_table"].Rows[0]["Remark"].ToString();
            s_Sex = ds.Tables["Student_table"].Rows[0]["Sex"].ToString();
            m_ContactPerson = ds.Tables["Student_table"].Rows[0]["ContactPerson"].ToString();

            if (ds.Tables.Count > 0)
            {
                var table = ds.Tables[0];
                var m_StudentID = table.AsEnumerable().Select(x => x.Field<int>("StudentID")).FirstOrDefault();
                s_StudentID = m_StudentID.ToString("000000");
//################################
                try
                {
                    StudentID_textBox.Text = s_StudentID;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                Course_listViewCustom.DataSource = ds;
            }

            Surname_textBox.Text = int.Parse(s_StudentID).ToString("000000");
            Remark_textBox.Text = s_Remark;
            //ContactPerson_textBox.Text = m_ContactPerson;
            switch (s_Sex)
            {
                case var p when p == "O":
                    Sex_comboBox.Text = "Organization";
                    break;
                case var p when p == "M":
                    Sex_comboBox.Text = "Male";
                    break;
                case var p when p == "F":
                    Sex_comboBox.Text = "Female";
                    break;
            }
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
            Course_listViewCustom.DataSource = ds1;
            Course_listViewCustom.DataMember = "Course_listViewCustom_table";

            if (m_ContactPerson != "0" & m_ContactPerson!="")
            {
                //var m_ContactPeron = ds.
                sSql = "Select Name, StudentID From Student where StudentID = " + m_ContactPerson;
                dataadapter = new OleDbDataAdapter(sSql, myConnection);
                DataSet ds2 = new DataSet();
                dataadapter.Fill(ds2, "ContactPerson_table");
                if (ds2.Tables.Count >= 1)
                {
                    string s_ContactPerson = ds2.Tables["ContactPerson_table"].Rows[0]["Name"].ToString();
                    Lib lib = new Lib();
                    int condition = lib.ItemCount(s_ContactPerson, "/");
                    for (int i = 0; i <= condition; i++)
                    {
                        ContactPerson_textBox.Text += lib.Item(s_ContactPerson, i, "/");
                    }
                }
            }
            else
            {
                ContactPerson_textBox.Text += "";
            }
            FormatDataListView();
        }

        private void FormatDataListView()
        {
            Course_listViewCustom.Columns[0].Width = 51;
            Course_listViewCustom.Columns[1].Width = 65;
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
            Course_listViewCustom.ShowGroups = false;

            Surname_textBox.Text = s_Name;

        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            RetrieveStudent('>');
            FillData();
        }

        private void Prior_button_Click(object sender, EventArgs e)
        {
            RetrieveStudent('<');
            FillData();
        }

        //private void Student_Form_Load_1(object sender, EventArgs e)
        //{

        //}
    }
}

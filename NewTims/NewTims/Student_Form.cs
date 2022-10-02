using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTims
{
    public partial class Student_Form : Form
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
        static readonly Lib Lib = new Lib();

        public Student_Form()
        {
            InitializeComponent();
        }

        private void Student_Form_Load(object sender, EventArgs e)
        {
            RetrieveStudents('>');
            RetrieveCourses();
        }

        private void RetrieveStudents(char Operator)
        {
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
                //var m_StudentID = ds.Tables["Student_table"].Rows[0]["StudentID"].ToString("000000");

                Regex r = new Regex(@"^[+-]?[0-9]{3}\.[0-9]{3}$");
                Match m = r.Match(StudentID_textBox.Text);


                if (ds.Tables.Count > 0)
                {

                    var table = ds.Tables[0];
                    var m_StudentID = table.AsEnumerable().Select(x => x.Field<int>("StudentID")).FirstOrDefault();
                    s_StudentID = m_StudentID.ToString("000000");
                    StudentID_textBox.Text = s_StudentID;
                }
                else
                {
                    StudnetList_dataListView.DataSource = ds;
                    //Regex r = new Regex(@"^[+-]?[0-9]{3}\.[0-9]{3}$");
                    //Match m = r.Match(StudentID_textBox.Text);
                    StudentID_textBox.Text = ds.Tables["Student_table"].Rows[0]["StudentID"].ToString();
                }

            }
        }

        private void Client_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Client_radioButton.Checked)
            {
                FillTextBoxes();
                Institution_radioButton.Checked = false;
            }

        }

        private void Institution_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Institution_radioButton.Checked)
            {
                FillTextBoxes();
                Client_radioButton.Checked = false;
            }
        }

        void FillTextBoxes()
        {
            Remark_textBox.Text = s_Remark;
            ContactPerson_textBox.Text = m_ContactPerson;
        }
        private void Sex_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioButtonChecked();
        }

        void RadioButtonChecked()
        {
            if (s_Sex == "O")
            {
                Sex_label.Text = "Title";
                Title_TextBox.Visible = true;
                Surname_label.Visible = false;
                Surname_textBox.Visible = false;
                MiddleName_label.Visible = false;
                MiddleName_textBox.Visible = false;
                GivenName_label.Visible = false;
                GivenName_textBox.Visible = false;
                Title_TextBox.Text = s_Name;
            }
            else
            {
                Sex_label.Text = "Gender";
                Title_TextBox.Visible = false;
                Surname_label.Visible = true;
                Surname_textBox.Visible = true;
                MiddleName_label.Visible = true;
                MiddleName_textBox.Visible = true;
                GivenName_label.Visible = true;
                GivenName_textBox.Visible = true;
                Surname_textBox.Text = Lib.Item(s_Name, 1);
                GivenName_textBox.Text = Lib.Item(s_Name, 2);
            }
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

        private void RetrieveCourses()
        {
            sSql = "Select Top 1 " + z_Fields + " from StudentIDCourse Where StudentID = " + s_StudentID + "Order by StudentID, SubjectID, CourseID";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sSql, myConnection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "StudentIDCourse_table");
            
        }
    }
}
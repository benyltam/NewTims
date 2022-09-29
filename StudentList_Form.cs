using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading;
using BrightIdeasSoftware;
using Library;
//using Lib;

namespace NewTims
{
    public partial class StudentList_Form : Form
    {
        static string s_Name = "";
        static string s_StudentID = "";
        static string s_KeyBuffer = "";
        static readonly OleDbConnection myConnection = new OleDbConnection("Provider=MSOLEDBSQL;Server=localHost;Database=" + "TIMS" + ";Trusted_Connection=yes;");

        public StudentList_Form()
        {
            InitializeComponent();
        }

        private void FillDataListView()
        {
            Lib lib = new Lib();
            string sSql = "SELECT Top 14 Name,Format(StudentID,'000000') as [Student ID],MiddleName,ChiName,Sex,Remark "
                + "FROM Student "
                + "Where Cast(Name as char(100))+Cast(StudentID as char(10))>="
                + "'" + (s_KeyBuffer + lib.String(" ", 100)).Substring(0, 100) + s_StudentID + "'"
                + "Order by Name,StudentID";

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sSql, myConnection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "StudentList_table");
            myConnection.Close();
            StudentList_dataListView.DataSource = ds;
            StudentList_dataListView.DataMember = "StudentList_table";

            SetColumnWidth();
        }


        private void StudentList_dataListView_KeyPressEventHandler(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            byte[] ascII = System.Text.Encoding.ASCII.GetBytes(e.KeyChar.ToString());
            switch (ascII[0])
            {
                case byte m when m > 32 && m < 255:
                    if (s_KeyBuffer.Trim().Length <= 100)
                    {
                        var m_Name = StudentList_dataListView.SelectedItem.Text;
                        s_KeyBuffer = s_KeyBuffer.Trim() + e.KeyChar.ToString();
                        if (m_Name.Substring(0,s_KeyBuffer.Length).ToUpper() != s_KeyBuffer.ToUpper())
                            {
                                ListViewItem item = StudentList_dataListView.FindItemWithText(s_KeyBuffer.Trim());
                                if (item == null)
                                {
                                    if ( s_KeyBuffer.Length > 1 )
                                        s_KeyBuffer = s_KeyBuffer.Substring(0, s_KeyBuffer.Length - 1);
                                        item = StudentList_dataListView.FindItemWithText(s_KeyBuffer.Trim());
                                        switch (item)
                                        {
                                            case ListViewItem x when (x == null):
                                                break;
                                            default:
                                                FillDataListView();
                                                break;
                                        }
                                }
                            }
                        else
                            s_KeyBuffer = s_KeyBuffer.Substring(0, s_KeyBuffer.Length - 1);
                    }
                    break;
                case byte m when m == 13:
                    StudentList_dataListView_MouseDoubleClick(sender, e);
                    break;
            }
        }

            //s_StudentID = StudentList_dataListView.FocusedItem.Text;
        private void StudentList_dataListView_MouseDoubleClick(object sender, EventArgs e)
        {
            s_StudentID = StudentList_dataListView.SelectedItem.SubItems[1].Text;
            Student_Form Student_Form =new Student_Form(s_StudentID);
            Student_Form.Show();
        }

        private void StudentList_Form_Load_1(object sender, EventArgs e)
        {
            //Lib Lib = new Lib();
            Subscribing();
            FillDataListView();
        }

        public void Subscribing()
        {
            StudentList_dataListView.MouseDoubleClick += StudentList_dataListView_MouseDoubleClick;
            StudentList_dataListView.KeyPress += StudentList_dataListView_KeyPressEventHandler;
            StudentList_dataListView.ShowGroups = false;
            //StudentList_dataListView.AutoResizeColumns();
            StudentList_dataListView.FullRowSelect = true;
            //StudentList_dataListView.FormatRow += delegate (object sender, FormatRowEventArgs args) { args.Item.Text = args.RowIndex.ToString(); };
        }
        private void SetColumnWidth()
        {
            StudentList_dataListView.Columns[0].Width = 230;
            StudentList_dataListView.Columns[1].Width = 66;
            StudentList_dataListView.Columns[2].Width = 130;
            StudentList_dataListView.Columns[3].Width = 90;
            StudentList_dataListView.Columns[4].Width = 66;
            StudentList_dataListView.Columns[5].Width = 216;
        }
        private void StudentList_Form_Load(object sender, EventArgs e)
        {
        }

            //OLVColumn col = (OLVColumn)StudentList_dataListView.Columns[0];
            //col.IsButton = true;
        

        private void ShowDetails_button_Click(object sender, EventArgs e)
        {
            //Student_dataListView.FocusedItem = Student_dataListView.SelectedItem[0];
            //s_Name = (Student_dataListView.Item[Math.Min(i_LastRow, z_rows)].SubItems[1].Text + String(" ", 100).Substring(0, 49);
            //s_MiddleName = (Student_dataListView.Items[Math.Min(i_LastRow, z_rows)].SubItems[3].Text + String(" ", 50)).Substring(0, 49);
            //s_StudentID = (Student_dataListView.Items[Math.Min(i_LastRow, z_rows)].SubItems[3].Text + String(" ", 50)).Substring(0, 10);
        }

        private void StudentList_dataListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lowerIndex = StudentList_dataListView.Items.Count - 2;
            int upperIndex = 1;
            if (StudentList_dataListView.SelectedIndex == lowerIndex)
            {
                s_KeyBuffer = StudentList_dataListView.Items[lowerIndex].Text;
                s_StudentID = StudentList_dataListView.Items[lowerIndex].SubItems[1].Text;
                FillDataListView();
            }
            else if (StudentList_dataListView.SelectedIndex == 1)
            {
                s_KeyBuffer = StudentList_dataListView.Items[upperIndex].Text;
                s_StudentID = StudentList_dataListView.Items[upperIndex].SubItems[1].Text;
                FillDataListView();
            }
        }

        private void Next_button_StudentList_Click(object sender, EventArgs e)
        {
            //i_LastRow = StudentList_dataListView.RowsPerPage;
            Lib lib = new Lib();
            s_Name = StudentList_dataListView.Items[StudentList_dataListView.Items.Count-1].SubItems[1].ToString();
            s_KeyBuffer= (s_Name + lib.String(" ", 100)).Substring(0, 100) + s_StudentID;
            FillDataListView();
            s_KeyBuffer = "";
        }
    }
}
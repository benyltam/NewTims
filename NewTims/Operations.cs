using System;
using System.Data;
using System.Data.OleDb;

namespace NewTims
{
    public class Operations
    {

        //void ConnectSql(sFile);
        //{
        //    const string sRowCount = "14";
        //    static string sSurname = "";
        //    static string sGivenName = "";
        //    static string sMiddleName = "";
        //    static string sStudentID = "";
        //    string sSql = "SELECT Top " + sRowCount + " StudentID, Surname, GivenName, MiddleName, ChiName, Remarks FROM Student Order by Surname, GivenName, MiddleName, StudentID"
        //        + " Where Surname+GivenName+MideleName+StudentID > " + sSurname + sGivenName + sMiddleName + sStudentID;
        //    OleDbCommand myCommand = new OleDbCommand();
        //OleDbConnection myConnection = new
        //    OleDbConnection("Provider=MSOLEDBSQL;Server=localhost;Database=" + sFile + ";Integrated Security=SSPI;");
        //OleDbDataAdapter dataadapter = new OleDbDataAdapter(sSql, myConnection);
        //    DataSet ds = new DataSet();
        //    myConnection.Open();
        //    dataadapter.Fill(ds, "student_table");
        //    myConnection.Close();
        //    Student_dataListView.DataSource = ds;
        //    Student_dataListView.DataMember = "Student_table";
        //    Student_dataListView.AutoResizeColumns();
        //    Student_dataListView.ShowGroups = false;
        //}
    }
}

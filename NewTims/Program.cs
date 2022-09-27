using System;
using System.Windows.Forms;
using System.Data.OleDb;


namespace NewTims
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //OleDbConnection myConnection = new OleDbConnection("Provider=MSOLEDBSQL;Server=localHost;Database=TIMS;Trusted_Connection=yes;");
            //int StudentID = FROM Student Order by StudentID;

            //Application.Run(new DaySchedule_Form());
            Application.Run(new Student_Form(""));
            //Application.Run(new StudentList_Form());
        }
    }
}

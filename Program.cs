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

            //int x = ItemCnt();

            Application.Run(new DaySchedule_Form());
            //Application.Run(new Student_Form(""));
        }
    }
}

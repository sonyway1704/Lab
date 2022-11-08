using System.Configuration;

namespace WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static string strConn = "";
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
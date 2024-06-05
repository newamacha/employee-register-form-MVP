using EmployeeMVP._Repositories;
using EmployeeMVP.Models;
using EmployeeMVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using EmployeeMVP.Presenters;

namespace EmployeeMVP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView mainView = new MainView();
            new MainPresenter(mainView, sqlConnectionString);
            Application.Run((Form)mainView);
        }
    }
}

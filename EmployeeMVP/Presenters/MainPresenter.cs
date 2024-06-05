using EmployeeMVP._Repositories;
using EmployeeMVP.Models;
using EmployeeMVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMVP.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowEmployeeView += ShowEmployeesView;
        }

        private void ShowEmployeesView(object sender, EventArgs e)
        {
            IEmployeeView employeeView = EmployeeView.GetInstance((MainView)mainView);
            IEmployeeRepository repository = new EmployeeRepository(sqlConnectionString);
            new EmployeePresenter(employeeView, repository);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMVP.Views
{
    public interface IEmployeeView
    {
        //int EmployeeId { get; set; }
        string EmployeeName { get; set; }
        string EmployeeGender { get; set; }
        string EmployeeDepartment { get; set; }
        string EmployeePost {  get; set; }

        string SearchValue {  get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler UpdateEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;



        void SetEmployeeListBindingSource(BindingSource employeeList);
        void Show();
    }
}

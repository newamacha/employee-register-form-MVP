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
    public class EmployeePresenter
    {
        //fields
        private IEmployeeView _employeeView;
        private IEmployeeRepository _employeeRepository;
        private BindingSource _bindingSource;
        private IEnumerable<EmployeeModel> _employees;

        //constructor
        public EmployeePresenter(IEmployeeView employeeView, IEmployeeRepository employeeRepository)
        {
            _bindingSource = new BindingSource();
            _employeeView = employeeView;
            _employeeRepository = employeeRepository;
            //subscribe event handler methods to view events
            _employeeView.SearchEvent += SearchEmployee;
            _employeeView.AddNewEvent += AddNewEmployee;
            _employeeView.UpdateEvent += LoadSelectedEmployeeToEdit;
            _employeeView.DeleteEvent += DeleteSelectedEmployee;
            _employeeView.SaveEvent += SaveEmployee;
            _employeeView.CancelEvent += CancelAction;
            //set employees binding source
            _employeeView.SetEmployeeListBindingSource(_bindingSource);
            //load employee list view
            LoadAllEmployeeList();
            //show view
            _employeeView.Show();
        }

        //methods
        private void LoadAllEmployeeList()
        {
            _employees = _employeeRepository.GetAll();
            _bindingSource.DataSource = _employees; //Set data source
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveEmployee(object sender, EventArgs e)
        {
            var model = new EmployeeModel();
            var employee = (EmployeeModel)_bindingSource.Current;
            model.Id = employee.Id;
            model.Name = _employeeView.EmployeeName;
            model.Gender = _employeeView.EmployeeGender;
            model.Department = _employeeView.EmployeeDepartment;
            model.Post = _employeeView.EmployeePost;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if(_employeeView.IsEdit)//edit model
                {
                    _employeeRepository.Update(model);
                    _employeeView.Message = "Employee edited successfully";
                }
                else
                {
                    _employeeRepository.Add(model);
                    _employeeView.Message = "Employee Added successfully";
                }
                _employeeView.IsSuccessful = true;
                LoadAllEmployeeList();
                CleanviewFields();
            }
            catch(Exception ex)
            {
                _employeeView.IsSuccessful = false;
                _employeeView.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            _employeeView.EmployeeName = "";
            _employeeView.EmployeeGender = "";
            _employeeView.EmployeeDepartment = "";
            _employeeView.EmployeePost = "";
        }

        private void DeleteSelectedEmployee(object sender, EventArgs e)
        {
            try
            {
                var employee = (EmployeeModel)_bindingSource.Current;
                _employeeRepository.Delete(employee.Id);
                _employeeView.IsSuccessful = true;
                _employeeView.Message = "Employee deleted successfully";
                LoadAllEmployeeList();
            }
            catch(Exception ex)
            {
                _employeeView.IsSuccessful=false;
                _employeeView.Message = "An error occured. Could not delete employee";
            }
        }

        private void LoadSelectedEmployeeToEdit(object sender, EventArgs e)
        {
            var employee = (EmployeeModel)_bindingSource.Current;
            _employeeView.EmployeeName=employee.Name;
            _employeeView.EmployeeGender=employee.Gender;
            _employeeView.EmployeeDepartment=employee.Department;
            _employeeView.EmployeePost=employee.Post;
            _employeeView.IsEdit=true;
        }

        private void AddNewEmployee(object sender, EventArgs e)
        {
            _employeeView.IsEdit = false;
        }

        private void SearchEmployee(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(_employeeView.SearchValue);
            if(emptyValue==false)
            {
                _employees = _employeeRepository.GetByValue(_employeeView.SearchValue);
            }
            else
            {
                _employees = _employeeRepository.GetAll();
            }
            _bindingSource.DataSource = _employees;
        }
    }
}

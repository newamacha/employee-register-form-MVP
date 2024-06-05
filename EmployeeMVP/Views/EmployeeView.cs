using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMVP.Views
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public EmployeeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl.TabPages.Remove(EmployeeDetails);
            btnClose.Click += delegate { this.Close(); };
        }

        private void d(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //search
            btnSearchEmployee.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            //add new
            btnAddEmployee.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(EmployeeList);
                tabControl.TabPages.Add(EmployeeDetails);
                EmployeeDetails.Text = "Add new employee";
            };

            //update
            btnUpdateEmployee.Click += delegate 
            { 
                UpdateEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(EmployeeList);
                tabControl.TabPages.Add(EmployeeDetails);
                EmployeeDetails.Text = "Update employee";
            };

            //save changes
            btnSave.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if(IsSuccessful)
                {
                    tabControl.TabPages.Remove(EmployeeDetails);
                    tabControl.TabPages.Add(EmployeeList);
                }
                MessageBox.Show(Message);
            };

            //cancel
            btnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(EmployeeDetails);
                tabControl.TabPages.Add(EmployeeList);
            };

            //delete
            btnDeleteEmployee.Click += delegate 
            { 
                var result=MessageBox.Show("Are you sure you want to delete the selected employee?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty); 
                    MessageBox.Show(Message);
                }
            };
        }

        //public int EmployeeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EmployeeName
        {
            get { return txtEmployeeName.Text; }
            set { txtEmployeeName.Text = value; }
        }
        public string EmployeeGender
        {
            get { return txtEmployeeGender.Text; }
            set { txtEmployeeGender.Text = value; }
        }
        public string EmployeeDepartment
        {
            get { return txtEmployeeDepartment.Text; }
            set { txtEmployeeDepartment.Text = value; }
        }
        public string EmployeePost
        {
            get { return txtEmployeePost.Text; }
            set { txtEmployeePost.Text = value; }
        }
        public string SearchValue 
        { 
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message 
        {
            get { return message; }
            set { message = value; }
        }


        //events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //methods
        public void SetEmployeeListBindingSource(BindingSource employeeList)
        {
            EmployeeGridView.DataSource = employeeList;
        }

        //singleton pattern
        private static EmployeeView instance;
        public static EmployeeView GetInstance(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new EmployeeView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if(instance.WindowState==FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}

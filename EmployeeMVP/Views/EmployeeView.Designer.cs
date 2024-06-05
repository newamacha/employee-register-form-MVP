namespace EmployeeMVP.Views
{
    partial class EmployeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.EmployeeList = new System.Windows.Forms.TabPage();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.EmployeeDetails = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmployeePost = new System.Windows.Forms.TextBox();
            this.txtEmployeeDepartment = new System.Windows.Forms.TextBox();
            this.txtEmployeeGender = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeePost = new System.Windows.Forms.Label();
            this.lblEmployeeDepartment = new System.Windows.Forms.Label();
            this.lblEmployeeGender = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.EmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.EmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(63, 22);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(140, 29);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employees";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.EmployeeList);
            this.tabControl.Controls.Add(this.EmployeeDetails);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 74);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 423);
            this.tabControl.TabIndex = 2;
            // 
            // EmployeeList
            // 
            this.EmployeeList.Controls.Add(this.btnSearchEmployee);
            this.EmployeeList.Controls.Add(this.btnDeleteEmployee);
            this.EmployeeList.Controls.Add(this.btnUpdateEmployee);
            this.EmployeeList.Controls.Add(this.btnAddEmployee);
            this.EmployeeList.Controls.Add(this.EmployeeGridView);
            this.EmployeeList.Controls.Add(this.txtSearch);
            this.EmployeeList.Controls.Add(this.lblSearch);
            this.EmployeeList.Location = new System.Drawing.Point(4, 25);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeList.Size = new System.Drawing.Size(792, 394);
            this.EmployeeList.TabIndex = 0;
            this.EmployeeList.Text = "Employee List";
            this.EmployeeList.UseVisualStyleBackColor = true;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(576, 32);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(93, 23);
            this.btnSearchEmployee.TabIndex = 6;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(685, 139);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteEmployee.TabIndex = 5;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateEmployee.Location = new System.Drawing.Point(685, 100);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(90, 23);
            this.btnUpdateEmployee.TabIndex = 4;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmployee.Location = new System.Drawing.Point(685, 62);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(90, 23);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToAddRows = false;
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.AllowUserToResizeColumns = false;
            this.EmployeeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.EmployeeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Location = new System.Drawing.Point(27, 60);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowHeadersWidth = 51;
            this.EmployeeGridView.RowTemplate.Height = 24;
            this.EmployeeGridView.Size = new System.Drawing.Size(644, 334);
            this.EmployeeGridView.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(27, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(543, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(24, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Employee";
            // 
            // EmployeeDetails
            // 
            this.EmployeeDetails.Controls.Add(this.btnCancel);
            this.EmployeeDetails.Controls.Add(this.btnSave);
            this.EmployeeDetails.Controls.Add(this.txtEmployeePost);
            this.EmployeeDetails.Controls.Add(this.txtEmployeeDepartment);
            this.EmployeeDetails.Controls.Add(this.txtEmployeeGender);
            this.EmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.EmployeeDetails.Controls.Add(this.lblEmployeePost);
            this.EmployeeDetails.Controls.Add(this.lblEmployeeDepartment);
            this.EmployeeDetails.Controls.Add(this.lblEmployeeGender);
            this.EmployeeDetails.Controls.Add(this.lblEmployeeName);
            this.EmployeeDetails.Location = new System.Drawing.Point(4, 25);
            this.EmployeeDetails.Name = "EmployeeDetails";
            this.EmployeeDetails.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeDetails.Size = new System.Drawing.Size(792, 347);
            this.EmployeeDetails.TabIndex = 1;
            this.EmployeeDetails.Text = "Employee Details";
            this.EmployeeDetails.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(404, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(285, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtEmployeePost
            // 
            this.txtEmployeePost.Location = new System.Drawing.Point(432, 202);
            this.txtEmployeePost.Name = "txtEmployeePost";
            this.txtEmployeePost.Size = new System.Drawing.Size(227, 22);
            this.txtEmployeePost.TabIndex = 7;
            // 
            // txtEmployeeDepartment
            // 
            this.txtEmployeeDepartment.Location = new System.Drawing.Point(432, 103);
            this.txtEmployeeDepartment.Name = "txtEmployeeDepartment";
            this.txtEmployeeDepartment.Size = new System.Drawing.Size(227, 22);
            this.txtEmployeeDepartment.TabIndex = 6;
            // 
            // txtEmployeeGender
            // 
            this.txtEmployeeGender.Location = new System.Drawing.Point(94, 202);
            this.txtEmployeeGender.Name = "txtEmployeeGender";
            this.txtEmployeeGender.Size = new System.Drawing.Size(227, 22);
            this.txtEmployeeGender.TabIndex = 5;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(94, 103);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(227, 22);
            this.txtEmployeeName.TabIndex = 4;
            // 
            // lblEmployeePost
            // 
            this.lblEmployeePost.AutoSize = true;
            this.lblEmployeePost.Location = new System.Drawing.Point(429, 170);
            this.lblEmployeePost.Name = "lblEmployeePost";
            this.lblEmployeePost.Size = new System.Drawing.Size(99, 16);
            this.lblEmployeePost.TabIndex = 3;
            this.lblEmployeePost.Text = "Employee Post";
            // 
            // lblEmployeeDepartment
            // 
            this.lblEmployeeDepartment.AutoSize = true;
            this.lblEmployeeDepartment.Location = new System.Drawing.Point(429, 74);
            this.lblEmployeeDepartment.Name = "lblEmployeeDepartment";
            this.lblEmployeeDepartment.Size = new System.Drawing.Size(142, 16);
            this.lblEmployeeDepartment.TabIndex = 2;
            this.lblEmployeeDepartment.Text = "Employee Department";
            // 
            // lblEmployeeGender
            // 
            this.lblEmployeeGender.AutoSize = true;
            this.lblEmployeeGender.Location = new System.Drawing.Point(91, 170);
            this.lblEmployeeGender.Name = "lblEmployeeGender";
            this.lblEmployeeGender.Size = new System.Drawing.Size(117, 16);
            this.lblEmployeeGender.TabIndex = 1;
            this.lblEmployeeGender.Text = "Employee Gender";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(91, 74);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(109, 16);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(749, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.EmployeeList.ResumeLayout(false);
            this.EmployeeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.EmployeeDetails.ResumeLayout(false);
            this.EmployeeDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage EmployeeList;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TabPage EmployeeDetails;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeePost;
        private System.Windows.Forms.Label lblEmployeeDepartment;
        private System.Windows.Forms.Label lblEmployeeGender;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmployeePost;
        private System.Windows.Forms.TextBox txtEmployeeDepartment;
        private System.Windows.Forms.TextBox txtEmployeeGender;
        private System.Windows.Forms.Button btnClose;
    }
}
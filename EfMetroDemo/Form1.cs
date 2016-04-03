using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;

namespace EfMetroDemo
{
    
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDepartmentList();
            LoadEmployees();
        }

        private void InitializeDepartmentList()
        {
            using (var context = new DemoDbEntities())
            {
                metroComboBoxDepartment.DataSource = context.Departments.ToList();
                metroComboBoxDepartment.DisplayMember = "Title";
                metroComboBoxDepartment.ValueMember = "Id";                
            }
            
        }

        private void LoadEmployees()
        {
            using (var context = new DemoDbEntities())
            {
                var employees = from emp in context.Employees
                    select new
                    {
                        emp.Id,
                        emp.Name,
                        Department = emp.Department.Title
                    };

                metrogridEmployee.DataSource = employees.ToList();
            }
        }
        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(metroLabelEmployeeId.Text);            
                        
            using (var context = new DemoDbEntities())
            {
                if (empId == 0)
                {
                    //create an employee object
                    Employee employee = new Employee
                    {
                        Name = metroTextEmployeeName.Text,
                        DeptId = Convert.ToInt32(metroComboBoxDepartment.SelectedValue)
                    };
                    context.Employees.Add(employee);
                }
                else
                {
                    var empToUpdate = context.Employees.SingleOrDefault(emp => emp.Id == empId);
                    if (empToUpdate != null)
                    {
                        empToUpdate.Name = metroTextEmployeeName.Text;
                        empToUpdate.DeptId = Convert.ToInt32(metroComboBoxDepartment.SelectedValue);                     
                    }
                }
                //can use try catch block over here to catch any error while saving
                context.SaveChanges();
            }
            //show success message

            MetroMessageBox.Show(this, "Employee Saved Successfully.", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //reresh grid
            LoadEmployees();
        }

        private void metrogridEmployee_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metrogridEmployee.SelectedRows.Count > 0)
            {
                selectedRow = metrogridEmployee.SelectedRows[0];
            }
            if(selectedRow==null)
                return;
            metroLabelEmployeeId.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextEmployeeName.Text = selectedRow.Cells["Name"].Value.ToString();
            metroComboBoxDepartment.SelectedIndex =
                metroComboBoxDepartment.FindStringExact(selectedRow.Cells["Department"].Value.ToString());

        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            metroLabelEmployeeId.Text = "0";
            metroTextEmployeeName.Text = string.Empty;
            metroComboBoxDepartment.SelectedIndex = 0;
        }

        private void metroButtonAddDepartment_Click(object sender, EventArgs e)
        {
            FrmManageDepartment frmManageDepartment = new FrmManageDepartment()
            {
                RefreshDepartmentList = InitializeDepartmentList
            };                   
            frmManageDepartment.Show(this);
        }
    }
}

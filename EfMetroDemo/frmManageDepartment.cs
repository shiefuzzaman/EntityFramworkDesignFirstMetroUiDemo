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
    public delegate void RefreshDepartmentListDelegate();
    public partial class FrmManageDepartment : MetroFramework.Forms.MetroForm
    {
        public RefreshDepartmentListDelegate RefreshDepartmentList;
        public FrmManageDepartment()
        {
            InitializeComponent();            
        }
        private void InitializeDepartmentList()
        {
            using (var context = new DemoDbEntities())
            {
                var departments = from dept in context.Departments
                    select new
                    {
                        dept.Id,
                        dept.Title
                    };

                metroGridDepartments.DataSource = departments.ToList();
            }

        }
        private void FrmManageDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (RefreshDepartmentList != null)
                RefreshDepartmentList();
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            metroLabelDepatmentId.Text = "0";
            metroTextBoxDepartmentTitle.Text = string.Empty;
        }

        private void FrmManageDepartment_Load(object sender, EventArgs e)
        {
            InitializeDepartmentList();
        }

        private bool IsValidDeptTitle(string title)
        {
            using (var context = new DemoDbEntities())
            {
                if (context.Departments.Any(dept => dept.Title == title))
                    return false;
            }
            return true;
        }
        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            int deptId = Convert.ToInt32(metroLabelDepatmentId.Text);

            //some validation can be added over here, like check duplicate department id
            if (!IsValidDeptTitle(metroTextBoxDepartmentTitle.Text))
            {
                MetroMessageBox.Show(this, "Department Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return;
            }


            using (var context = new DemoDbEntities())
            {
                if (deptId == 0)
                {
                    Department dept = new Department()
                    {
                        Title = metroTextBoxDepartmentTitle.Text
                    };
                    context.Departments.Add(dept);
                }
                else
                {
                    var deptToUpdate = context.Departments.SingleOrDefault(dept => dept.Id == deptId);
                    if (deptToUpdate != null)
                    {
                        deptToUpdate.Title = metroTextBoxDepartmentTitle.Text;                       
                    }
                }
                //can use try catch block over here to catch any error while saving
                context.SaveChanges();
            }
            //show success message

            MetroMessageBox.Show(this, "Department Saved Successfully.", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //reresh grid
            InitializeDepartmentList();
        }

        private void metroGridDepartments_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metroGridDepartments.SelectedRows.Count > 0)
            {
                selectedRow = metroGridDepartments.SelectedRows[0];
            }
            if (selectedRow == null)
                return;
            metroLabelDepatmentId.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextBoxDepartmentTitle.Text = selectedRow.Cells["Title"].Value.ToString();            
        }
    }
}

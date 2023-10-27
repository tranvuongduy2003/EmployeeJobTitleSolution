using EmployeeJobTitleLibrary.Models;
using EmployeeJobTitleLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeJobTitle
{
    public partial class AddEmployeeForm : Form
    {
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Employee name is required");
                return;
            }
            if (yearTextBox.Text == "")
            {
                MessageBox.Show("Year of birht is required");
                return;
            }
            if (departmentTextBox.Text == "")
            {
                MessageBox.Show("Department name is required");
                return;
            }
            if (jobTitleNameTextBox.Text == "")
            {
                MessageBox.Show("Job title name is required");
                return;
            }
            if (jobTitleDescTextBox.Text == "")
            {
                MessageBox.Show("Job title description name is required");
                return;
            }

            var year = Int32.Parse(yearTextBox.Text);

            if (year < 1960 && year > 2002)
            {
                MessageBox.Show("Year of birht must be from 1960 to 2002");
                return;
            }

            if (nameTextBox.Text.Length <= 10)
            {
                MessageBox.Show("Employee name must be greater than 10 characters");
                return;
            }

            string[] words = nameTextBox.Text.Split(' ');
            foreach (var word in words)
            {
                if (Char.IsLower(word[0]))
                {
                    MessageBox.Show("Each word of the employee name must begin with the capital character");
                    return;
                }
            }

            EmployeeDto employeeDto = new EmployeeDto
            {
                EmployeeName = nameTextBox.Text,
                YearOfBirth = year,
                DepartmentName = departmentTextBox.Text,
                JobTitleName = jobTitleNameTextBox.Text,
                JobTitleDescription = jobTitleDescTextBox.Text,
            };

            try
            {
                _employeeRepository.InsertEmployee(employeeDto);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

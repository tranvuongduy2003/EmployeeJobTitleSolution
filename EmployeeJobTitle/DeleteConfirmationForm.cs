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
    public partial class DeleteConfirmationForm : Form
    {
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        private readonly string employeeId;

        public DeleteConfirmationForm(string employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeRepository.DeleteEmployee(employeeId);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

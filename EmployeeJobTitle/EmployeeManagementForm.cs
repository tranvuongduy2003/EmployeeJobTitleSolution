using EmployeeJobTitleLibrary.Models;
using EmployeeJobTitleLibrary.Repository;

namespace EmployeeJobTitle
{
    public partial class EmployeeManagementForm : Form
    {
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        List<EmployeeDto> employeeDtos = new List<EmployeeDto>();
        List<EmployeeDto> filteredEmployeeDtos = new List<EmployeeDto>();

        private AddEmployeeForm addEmployeeForm;
        private UpdateEmployeeForm updateEmployeeForm;
        private DeleteConfirmationForm deleteConfirmationForm;

        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            employeeDtos.Clear();
            employeeList.Rows.Clear();
            employeeDtos = _employeeRepository.GetEmployees().ToList();
            employeeDtos.ForEach(x => employeeList.Rows.Add(x.EmployeeId, x.EmployeeName, x.YearOfBirth, x.DepartmentName, x.JobTitleName, x.JobTitleDescription));
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void add_Click(object sender, EventArgs e)
        {
            addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            if (addEmployeeForm.DialogResult == DialogResult.OK)
            {
                LoadForm();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (employeeList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to update!");
                return;
            }

            updateEmployeeForm = new UpdateEmployeeForm(employeeList.SelectedRows[0].Cells["EmployeeId"].Value.ToString());
            updateEmployeeForm.ShowDialog();

            if (updateEmployeeForm.DialogResult == DialogResult.OK)
            {
                LoadForm();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (employeeList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete!");
                return;
            }

                deleteConfirmationForm = new DeleteConfirmationForm(employeeList.SelectedRows[0].Cells["EmployeeId"].Value.ToString());
                deleteConfirmationForm.ShowDialog();
                if (deleteConfirmationForm.DialogResult == DialogResult.OK)
                {
                    LoadForm();
                }
        }

        private void search_Click(object sender, EventArgs e)
        {
            var result = searchTextBox.Text;
            foreach (var item in employeeDtos)
            {
                if (item.DepartmentName.Contains(result))
                {
                    filteredEmployeeDtos.Add(item);
                }
            }
            employeeList.Rows.Clear();
            filteredEmployeeDtos.ForEach(x => employeeList.Rows.Add(x.EmployeeId, x.EmployeeName, x.YearOfBirth, x.DepartmentName, x.JobTitleName, x.JobTitleDescription));
        }

        private void clear_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            filteredEmployeeDtos.Clear();
            employeeList.Rows.Clear();
            employeeDtos.ForEach(x => employeeList.Rows.Add(x.EmployeeId, x.EmployeeName, x.YearOfBirth, x.DepartmentName, x.JobTitleName, x.JobTitleDescription));
        }
    }
}

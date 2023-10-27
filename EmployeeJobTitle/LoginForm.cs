using EmployeeJobTitleLibrary.Repository;

namespace EmployeeJobTitle
{
    public partial class LoginForm : Form
    {
        private EmployeeManagementForm employeeManagementForm;
        AuthRepository _authRepository = new AuthRepository();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var userName = usernameTextBox.Text;
            if (userName == null) {
                MessageBox.Show("Username is required");
                return;
            }

            var password = passwordTextBox.Text;
            if (password == null) {
                MessageBox.Show("Password is required");
                return;
            }
            
            try
            {
                var account = _authRepository.Login(userName, password);

                if ( account.AccountRole != 1)
                {
                    throw new Exception("You are not allowed to access this function!");
                }
                employeeManagementForm = new EmployeeManagementForm();
                employeeManagementForm.Show();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

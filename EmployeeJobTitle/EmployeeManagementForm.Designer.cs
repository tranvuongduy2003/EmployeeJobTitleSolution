namespace EmployeeJobTitle
{
    partial class EmployeeManagementForm
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
            employeeList = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            YearOfBirth = new DataGridViewTextBoxColumn();
            DepartmentName = new DataGridViewTextBoxColumn();
            JobTitleName = new DataGridViewTextBoxColumn();
            JobTitleDescription = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            delete = new Button();
            update = new Button();
            add = new Button();
            groupBox2 = new GroupBox();
            search = new Button();
            searchTextBox = new TextBox();
            clear = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeList).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // employeeList
            // 
            employeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeList.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, YearOfBirth, DepartmentName, JobTitleName, JobTitleDescription });
            employeeList.Location = new Point(2, 352);
            employeeList.MultiSelect = false;
            employeeList.Name = "employeeList";
            employeeList.RowHeadersWidth = 62;
            employeeList.Size = new Size(1118, 411);
            employeeList.TabIndex = 0;
            // 
            // EmployeeID
            // 
            EmployeeID.HeaderText = "ID";
            EmployeeID.MinimumWidth = 8;
            EmployeeID.Name = "EmployeeID";
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "Name";
            EmployeeName.MinimumWidth = 8;
            EmployeeName.Name = "EmployeeName";
            // 
            // YearOfBirth
            // 
            YearOfBirth.HeaderText = "Year Of Birth";
            YearOfBirth.MinimumWidth = 8;
            YearOfBirth.Name = "YearOfBirth";
            // 
            // DepartmentName
            // 
            DepartmentName.HeaderText = "Department Name";
            DepartmentName.MinimumWidth = 8;
            DepartmentName.Name = "DepartmentName";
            // 
            // JobTitleName
            // 
            JobTitleName.HeaderText = "Job Title Name";
            JobTitleName.MinimumWidth = 8;
            JobTitleName.Name = "JobTitleName";
            // 
            // JobTitleDescription
            // 
            JobTitleDescription.HeaderText = "JobTitleDescription";
            JobTitleDescription.MinimumWidth = 8;
            JobTitleDescription.Name = "JobTitleDescription";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(486, 60);
            label1.TabIndex = 1;
            label1.Text = "Employee Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delete);
            groupBox1.Controls.Add(update);
            groupBox1.Controls.Add(add);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(695, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 159);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // delete
            // 
            delete.AutoSize = true;
            delete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete.Location = new Point(256, 81);
            delete.Name = "delete";
            delete.Size = new Size(116, 48);
            delete.TabIndex = 2;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.AutoSize = true;
            update.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update.Location = new Point(134, 81);
            update.Name = "update";
            update.Size = new Size(116, 48);
            update.TabIndex = 1;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // add
            // 
            add.AutoSize = true;
            add.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.Location = new Point(16, 81);
            add.Name = "add";
            add.Size = new Size(112, 48);
            add.TabIndex = 0;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(search);
            groupBox2.Controls.Add(searchTextBox);
            groupBox2.Controls.Add(clear);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(53, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(614, 159);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
            // 
            // search
            // 
            search.AutoSize = true;
            search.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(355, 80);
            search.Name = "search";
            search.Size = new Size(116, 48);
            search.TabIndex = 4;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Font = new Font("Segoe UI", 14F);
            searchTextBox.Location = new Point(28, 84);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search department name";
            searchTextBox.Size = new Size(321, 45);
            searchTextBox.TabIndex = 3;
            // 
            // clear
            // 
            clear.AutoSize = true;
            clear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear.Location = new Point(477, 81);
            clear.Name = "clear";
            clear.Size = new Size(116, 48);
            clear.TabIndex = 2;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // EmployeeManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 775);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(employeeList);
            Name = "EmployeeManagementForm";
            Text = "Form1";
            Load += EmployeeManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)employeeList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView employeeList;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn YearOfBirth;
        private DataGridViewTextBoxColumn DepartmentName;
        private DataGridViewTextBoxColumn JobTitleName;
        private DataGridViewTextBoxColumn JobTitleDescription;
        private Label label1;
        private GroupBox groupBox1;
        private Button update;
        private Button add;
        private Button delete;
        private GroupBox groupBox2;
        private TextBox searchTextBox;
        private Button clear;
        private Button search;
    }
}
namespace EmployeeJobTitle
{
    partial class AddEmployeeForm
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
            label1 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            yearTextBox = new TextBox();
            label3 = new Label();
            departmentTextBox = new TextBox();
            label4 = new Label();
            jobTitleNameTextBox = new TextBox();
            label5 = new Label();
            jobTitleDescTextBox = new TextBox();
            label6 = new Label();
            add = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 54);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(23, 108);
            label2.Name = "label2";
            label2.Size = new Size(91, 38);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 14F);
            nameTextBox.Location = new Point(327, 105);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(437, 45);
            nameTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            yearTextBox.Font = new Font("Segoe UI", 14F);
            yearTextBox.Location = new Point(327, 182);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(437, 45);
            yearTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(23, 185);
            label3.Name = "label3";
            label3.Size = new Size(173, 38);
            label3.TabIndex = 3;
            label3.Text = "Year Of Birth";
            // 
            // departmentTextBox
            // 
            departmentTextBox.Font = new Font("Segoe UI", 14F);
            departmentTextBox.Location = new Point(327, 256);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(437, 45);
            departmentTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(23, 259);
            label4.Name = "label4";
            label4.Size = new Size(247, 38);
            label4.TabIndex = 5;
            label4.Text = "Department Name";
            // 
            // jobTitleNameTextBox
            // 
            jobTitleNameTextBox.Font = new Font("Segoe UI", 14F);
            jobTitleNameTextBox.Location = new Point(327, 337);
            jobTitleNameTextBox.Name = "jobTitleNameTextBox";
            jobTitleNameTextBox.Size = new Size(437, 45);
            jobTitleNameTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(23, 340);
            label5.Name = "label5";
            label5.Size = new Size(202, 38);
            label5.TabIndex = 7;
            label5.Text = "Job Title Name";
            // 
            // jobTitleDescTextBox
            // 
            jobTitleDescTextBox.Font = new Font("Segoe UI", 14F);
            jobTitleDescTextBox.Location = new Point(327, 404);
            jobTitleDescTextBox.Name = "jobTitleDescTextBox";
            jobTitleDescTextBox.Size = new Size(437, 45);
            jobTitleDescTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(23, 407);
            label6.Name = "label6";
            label6.Size = new Size(269, 38);
            label6.TabIndex = 9;
            label6.Text = "Job Title Description";
            // 
            // add
            // 
            add.AutoSize = true;
            add.Font = new Font("Segoe UI", 14F);
            add.Location = new Point(449, 506);
            add.Name = "add";
            add.Size = new Size(112, 48);
            add.TabIndex = 11;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // cancel
            // 
            cancel.AutoSize = true;
            cancel.Font = new Font("Segoe UI", 14F);
            cancel.Location = new Point(204, 506);
            cancel.Name = "cancel";
            cancel.Size = new Size(112, 48);
            cancel.TabIndex = 12;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 589);
            Controls.Add(cancel);
            Controls.Add(add);
            Controls.Add(jobTitleDescTextBox);
            Controls.Add(label6);
            Controls.Add(jobTitleNameTextBox);
            Controls.Add(label5);
            Controls.Add(departmentTextBox);
            Controls.Add(label4);
            Controls.Add(yearTextBox);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox yearTextBox;
        private Label label3;
        private TextBox departmentTextBox;
        private Label label4;
        private TextBox jobTitleNameTextBox;
        private Label label5;
        private TextBox jobTitleDescTextBox;
        private Label label6;
        private Button add;
        private Button cancel;
    }
}
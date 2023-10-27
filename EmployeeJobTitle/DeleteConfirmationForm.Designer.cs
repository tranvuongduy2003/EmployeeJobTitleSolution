namespace EmployeeJobTitle
{
    partial class DeleteConfirmationForm
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
            delete = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(297, 92);
            label1.TabIndex = 0;
            label1.Text = "Do you really want to delete this employee?";
            // 
            // delete
            // 
            delete.AutoSize = true;
            delete.BackColor = Color.Red;
            delete.Font = new Font("Segoe UI", 12F);
            delete.ForeColor = SystemColors.ButtonHighlight;
            delete.Location = new Point(213, 159);
            delete.Name = "delete";
            delete.Size = new Size(112, 42);
            delete.TabIndex = 1;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // cancel
            // 
            cancel.AutoSize = true;
            cancel.BackColor = SystemColors.ButtonHighlight;
            cancel.Font = new Font("Segoe UI", 12F);
            cancel.ForeColor = SystemColors.ActiveCaptionText;
            cancel.Location = new Point(61, 159);
            cancel.Name = "cancel";
            cancel.Size = new Size(112, 42);
            cancel.TabIndex = 2;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // DeleteConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 254);
            Controls.Add(cancel);
            Controls.Add(delete);
            Controls.Add(label1);
            Name = "DeleteConfirmationForm";
            Text = "DeleteConfirmationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button delete;
        private Button cancel;
    }
}
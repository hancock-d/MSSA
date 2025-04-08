namespace Mod3EmployeeSystemDave
{
    partial class AddForm
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
            grpEmployee = new GroupBox();
            btnSubmit = new Button();
            comboDept = new ComboBox();
            txtSalary = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            txtEid = new TextBox();
            lblDept = new Label();
            lblSalary = new Label();
            lblAddress = new Label();
            lblName = new Label();
            lblEmpId = new Label();
            grpEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // grpEmployee
            // 
            grpEmployee.Controls.Add(btnSubmit);
            grpEmployee.Controls.Add(comboDept);
            grpEmployee.Controls.Add(txtSalary);
            grpEmployee.Controls.Add(txtAddress);
            grpEmployee.Controls.Add(txtName);
            grpEmployee.Controls.Add(txtEid);
            grpEmployee.Controls.Add(lblDept);
            grpEmployee.Controls.Add(lblSalary);
            grpEmployee.Controls.Add(lblAddress);
            grpEmployee.Controls.Add(lblName);
            grpEmployee.Controls.Add(lblEmpId);
            grpEmployee.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpEmployee.Location = new Point(299, 306);
            grpEmployee.Name = "grpEmployee";
            grpEmployee.Size = new Size(1122, 663);
            grpEmployee.TabIndex = 0;
            grpEmployee.TabStop = false;
            grpEmployee.Text = "Employee Record";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(332, 541);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 67);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // comboDept
            // 
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(426, 434);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(242, 47);
            comboDept.TabIndex = 9;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(434, 347);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(227, 47);
            txtSalary.TabIndex = 8;
            txtSalary.Validating += txtSalary_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(434, 207);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(480, 85);
            txtAddress.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(434, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(488, 47);
            txtName.TabIndex = 6;
            // 
            // txtEid
            // 
            txtEid.Location = new Point(434, 64);
            txtEid.Name = "txtEid";
            txtEid.Size = new Size(200, 47);
            txtEid.TabIndex = 5;
            txtEid.Validating += txtEid_Validating;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(58, 448);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(313, 39);
            lblDept.TabIndex = 4;
            lblDept.Text = "Employee Department";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(58, 355);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(230, 39);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Employee Salary";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(58, 215);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(259, 39);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Employee Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(58, 145);
            lblName.Name = "lblName";
            lblName.Size = new Size(231, 39);
            lblName.TabIndex = 1;
            lblName.Text = "Employee Name";
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(58, 72);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(178, 39);
            lblEmpId.TabIndex = 0;
            lblEmpId.Text = "Employee Id";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1743, 1097);
            Controls.Add(grpEmployee);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            grpEmployee.ResumeLayout(false);
            grpEmployee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEmployee;
        private Label lblEmpId;
        private Label lblSalary;
        private Label lblAddress;
        private Label lblName;
        private Label lblDept;
        private TextBox txtEid;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtSalary;
        private ComboBox comboDept;
        private Button btnSubmit;
    }
}
namespace Mod7CodeFirstDemoDave
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            empGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEid = new TextBox();
            txtName = new TextBox();
            txtSalary = new TextBox();
            comboDept = new ComboBox();
            btnAdd = new Button();
            btnSubmit = new Button();
            btnSelect = new Button();
            btnUpdate = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)empGrid).BeginInit();
            SuspendLayout();
            // 
            // empGrid
            // 
            empGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empGrid.Location = new Point(186, 58);
            empGrid.Name = "empGrid";
            empGrid.RowHeadersWidth = 82;
            empGrid.Size = new Size(1085, 300);
            empGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(123, 428);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 1;
            label1.Text = "Employee Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(123, 525);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 2;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(123, 652);
            label3.Name = "label3";
            label3.Size = new Size(202, 32);
            label3.TabIndex = 3;
            label3.Text = "Employee Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(123, 786);
            label4.Name = "label4";
            label4.Size = new Size(270, 32);
            label4.TabIndex = 4;
            label4.Text = "Employee Department";
            // 
            // txtEid
            // 
            txtEid.Location = new Point(505, 418);
            txtEid.Name = "txtEid";
            txtEid.Size = new Size(200, 39);
            txtEid.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(505, 518);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(505, 645);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(200, 39);
            txtSalary.TabIndex = 7;
            // 
            // comboDept
            // 
            comboDept.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(505, 778);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(242, 40);
            comboDept.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(891, 414);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(212, 46);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Location = new Point(1178, 411);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(212, 46);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnSelect
            // 
            btnSelect.FlatStyle = FlatStyle.Popup;
            btnSelect.Location = new Point(891, 511);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(212, 46);
            btnSelect.TabIndex = 11;
            btnSelect.Text = "Select to Update";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Location = new Point(1178, 511);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(212, 46);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update DB";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Location = new Point(1178, 606);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(212, 46);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(891, 606);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(212, 46);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 983);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnSelect);
            Controls.Add(btnSubmit);
            Controls.Add(btnAdd);
            Controls.Add(comboDept);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(txtEid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(empGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)empGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView empGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEid;
        private TextBox txtName;
        private TextBox txtSalary;
        private ComboBox comboDept;
        private Button btnAdd;
        private Button btnSubmit;
        private Button btnSelect;
        private Button btnUpdate;
        private Button btnRefresh;
        private Button btnDelete;
    }
}

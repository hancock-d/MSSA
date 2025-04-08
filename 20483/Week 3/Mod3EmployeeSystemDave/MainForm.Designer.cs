namespace Mod3EmployeeSystemDave
{
    partial class MainForm
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
            lblHeading = new Label();
            empGrid = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)empGrid).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Script MT Bold", 20F);
            lblHeading.Location = new Point(584, 79);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(389, 65);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Employee Portal";
            // 
            // empGrid
            // 
            empGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            empGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empGrid.Location = new Point(161, 204);
            empGrid.Name = "empGrid";
            empGrid.RowHeadersWidth = 82;
            empGrid.Size = new Size(1303, 368);
            empGrid.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(229, 634);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(215, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1148, 634);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Employee";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(685, 690);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 46);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1669, 1048);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(empGrid);
            Controls.Add(lblHeading);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)empGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private DataGridView empGrid;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnRefresh;
    }
}
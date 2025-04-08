namespace _4._2_Teacher_LMS
{
    partial class TeacherPortalForm
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
            lblHeading2 = new Label();
            studGrid = new DataGridView();
            btnAddStud = new Button();
            btnRemoveStud = new Button();
            btnRefresh = new Button();
            btnDownload = new Button();
            btnSort = new Button();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtId = new TextBox();
            txtGPA = new TextBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)studGrid).BeginInit();
            SuspendLayout();
            // 
            // lblHeading2
            // 
            lblHeading2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading2.Location = new Point(532, 9);
            lblHeading2.Name = "lblHeading2";
            lblHeading2.Size = new Size(297, 64);
            lblHeading2.TabIndex = 0;
            lblHeading2.Text = "Teacher Portal";
            lblHeading2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // studGrid
            // 
            studGrid.AllowUserToOrderColumns = true;
            studGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            studGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studGrid.Location = new Point(89, 116);
            studGrid.Name = "studGrid";
            studGrid.RowHeadersWidth = 82;
            studGrid.Size = new Size(1155, 300);
            studGrid.TabIndex = 1;
            // 
            // btnAddStud
            // 
            btnAddStud.BackColor = Color.FromArgb(128, 255, 128);
            btnAddStud.FlatStyle = FlatStyle.Popup;
            btnAddStud.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStud.Location = new Point(1086, 722);
            btnAddStud.Name = "btnAddStud";
            btnAddStud.Size = new Size(221, 59);
            btnAddStud.TabIndex = 2;
            btnAddStud.Text = "Add Student";
            btnAddStud.UseVisualStyleBackColor = false;
            btnAddStud.Click += btnAddStud_Click;
            // 
            // btnRemoveStud
            // 
            btnRemoveStud.BackColor = Color.FromArgb(128, 255, 128);
            btnRemoveStud.FlatStyle = FlatStyle.Popup;
            btnRemoveStud.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveStud.Location = new Point(89, 472);
            btnRemoveStud.Name = "btnRemoveStud";
            btnRemoveStud.Size = new Size(262, 59);
            btnRemoveStud.TabIndex = 3;
            btnRemoveStud.Text = "Remove Student";
            btnRemoveStud.UseVisualStyleBackColor = false;
            btnRemoveStud.Click += btnRemoveStud_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(128, 255, 128);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(357, 472);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(221, 59);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(128, 255, 128);
            btnDownload.FlatStyle = FlatStyle.Popup;
            btnDownload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(1023, 472);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(221, 59);
            btnDownload.TabIndex = 5;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.FromArgb(128, 255, 128);
            btnSort.FlatStyle = FlatStyle.Popup;
            btnSort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(796, 472);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(221, 59);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort GPA";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(322, 738);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.PlaceholderText = "First Name";
            txtFirstname.Size = new Size(240, 43);
            txtFirstname.TabIndex = 8;
            txtFirstname.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(568, 738);
            txtLastname.Name = "txtLastname";
            txtLastname.PlaceholderText = "Last Name";
            txtLastname.Size = new Size(240, 43);
            txtLastname.TabIndex = 9;
            txtLastname.TextAlign = HorizontalAlignment.Center;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(76, 738);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "ID #";
            txtId.Size = new Size(240, 43);
            txtId.TabIndex = 7;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGPA
            // 
            txtGPA.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGPA.Location = new Point(814, 738);
            txtGPA.Name = "txtGPA";
            txtGPA.PlaceholderText = "GPA";
            txtGPA.Size = new Size(240, 43);
            txtGPA.TabIndex = 10;
            txtGPA.TextAlign = HorizontalAlignment.Center;
            txtGPA.Validating += txtGPA_Validating;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Lime;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(549, 902);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(233, 80);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // TeacherPortalForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1404, 1058);
            Controls.Add(btnExit);
            Controls.Add(txtGPA);
            Controls.Add(txtId);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(btnSort);
            Controls.Add(btnDownload);
            Controls.Add(btnRefresh);
            Controls.Add(btnRemoveStud);
            Controls.Add(btnAddStud);
            Controls.Add(studGrid);
            Controls.Add(lblHeading2);
            Name = "TeacherPortalForm";
            Text = "TeacherPortal";
            Load += TeacherPortal_Load;
            ((System.ComponentModel.ISupportInitialize)studGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading2;
        private DataGridView studGrid;
        private Button btnAddStud;
        private Button btnRemoveStud;
        private Button btnRefresh;
        private Button btnDownload;
        private Button btnSort;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtId;
        private TextBox txtGPA;
        private Button btnExit;
    }
}
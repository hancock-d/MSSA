namespace _3._3_Student_Roster
{
    partial class StudentPortalForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.studGrid = new System.Windows.Forms.DataGridView();
            this.btnAddStud = new System.Windows.Forms.Button();
            this.btnRemoveStud = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(648, 69);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(307, 50);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Student Portal";
            // 
            // studGrid
            // 
            this.studGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.studGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.studGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studGrid.GridColor = System.Drawing.Color.Black;
            this.studGrid.Location = new System.Drawing.Point(141, 168);
            this.studGrid.Name = "studGrid";
            this.studGrid.RowHeadersWidth = 82;
            this.studGrid.RowTemplate.Height = 33;
            this.studGrid.Size = new System.Drawing.Size(1355, 495);
            this.studGrid.TabIndex = 1;
            // 
            // btnAddStud
            // 
            this.btnAddStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStud.Location = new System.Drawing.Point(141, 713);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(270, 56);
            this.btnAddStud.TabIndex = 2;
            this.btnAddStud.Text = "Add Student";
            this.btnAddStud.UseVisualStyleBackColor = true;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // btnRemoveStud
            // 
            this.btnRemoveStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStud.Location = new System.Drawing.Point(1226, 713);
            this.btnRemoveStud.Name = "btnRemoveStud";
            this.btnRemoveStud.Size = new System.Drawing.Size(270, 56);
            this.btnRemoveStud.TabIndex = 3;
            this.btnRemoveStud.Text = "Remove Student";
            this.btnRemoveStud.UseVisualStyleBackColor = true;
            this.btnRemoveStud.Click += new System.EventHandler(this.btnRemoveStud_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(681, 713);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(250, 69);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // StudentPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1702, 1015);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemoveStud);
            this.Controls.Add(this.btnAddStud);
            this.Controls.Add(this.studGrid);
            this.Controls.Add(this.lblHeading);
            this.Name = "StudentPortalForm";
            this.Text = "StudentPortal";
            this.Load += new System.EventHandler(this.StudentPortalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView studGrid;
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.Button btnRemoveStud;
        private System.Windows.Forms.Button btnRefresh;
    }
}


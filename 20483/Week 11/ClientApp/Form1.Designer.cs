namespace ClientApp
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
            moviesGrid = new DataGridView();
            btnAdd = new Button();
            btnGetweather = new Button();
            ((System.ComponentModel.ISupportInitialize)moviesGrid).BeginInit();
            SuspendLayout();
            // 
            // moviesGrid
            // 
            moviesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesGrid.Location = new Point(281, 161);
            moviesGrid.Name = "moviesGrid";
            moviesGrid.RowHeadersWidth = 82;
            moviesGrid.Size = new Size(765, 357);
            moviesGrid.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(299, 648);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(268, 143);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Movie";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGetweather
            // 
            btnGetweather.FlatStyle = FlatStyle.Popup;
            btnGetweather.Location = new Point(743, 646);
            btnGetweather.Name = "btnGetweather";
            btnGetweather.Size = new Size(352, 145);
            btnGetweather.TabIndex = 2;
            btnGetweather.Text = "Get Weather";
            btnGetweather.UseVisualStyleBackColor = true;
            btnGetweather.Click += btnGetweather_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 989);
            Controls.Add(btnGetweather);
            Controls.Add(btnAdd);
            Controls.Add(moviesGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)moviesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView moviesGrid;
        private Button btnAdd;
        private Button btnGetweather;
    }
}

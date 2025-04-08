namespace Mini_Project_Shopping_List
{
    partial class DefaultPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultPageForm));
            btnContinue = new Button();
            txtInputStoreA = new TextBox();
            btnAddStore = new Button();
            lblStoreA = new Label();
            lblStoreB = new Label();
            txtInputStoreB = new TextBox();
            SuspendLayout();
            // 
            // btnContinue
            // 
            btnContinue.AutoSize = true;
            btnContinue.BackColor = SystemColors.ButtonFace;
            btnContinue.FlatStyle = FlatStyle.Popup;
            btnContinue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(458, 352);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(301, 55);
            btnContinue.TabIndex = 4;
            btnContinue.Text = "View Shopping List";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // txtInputStoreA
            // 
            txtInputStoreA.BorderStyle = BorderStyle.None;
            txtInputStoreA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputStoreA.Location = new Point(264, 103);
            txtInputStoreA.Name = "txtInputStoreA";
            txtInputStoreA.PlaceholderText = "Store A";
            txtInputStoreA.Size = new Size(207, 43);
            txtInputStoreA.TabIndex = 1;
            // 
            // btnAddStore
            // 
            btnAddStore.AutoSize = true;
            btnAddStore.BackColor = SystemColors.ButtonFace;
            btnAddStore.FlatStyle = FlatStyle.Popup;
            btnAddStore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStore.Location = new Point(517, 269);
            btnAddStore.Name = "btnAddStore";
            btnAddStore.Size = new Size(186, 55);
            btnAddStore.TabIndex = 3;
            btnAddStore.Text = "Add Stores";
            btnAddStore.UseVisualStyleBackColor = false;
            btnAddStore.Click += btnAddStore_Click;
            // 
            // lblStoreA
            // 
            lblStoreA.AutoSize = true;
            lblStoreA.BackColor = Color.Transparent;
            lblStoreA.Font = new Font("Lucida Calligraphy", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStoreA.ForeColor = Color.White;
            lblStoreA.Location = new Point(264, 98);
            lblStoreA.Name = "lblStoreA";
            lblStoreA.Size = new Size(176, 48);
            lblStoreA.TabIndex = 6;
            lblStoreA.Text = "Store A";
            lblStoreA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStoreB
            // 
            lblStoreB.AutoSize = true;
            lblStoreB.BackColor = Color.Transparent;
            lblStoreB.Font = new Font("Lucida Calligraphy", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStoreB.ForeColor = Color.White;
            lblStoreB.Location = new Point(694, 98);
            lblStoreB.Name = "lblStoreB";
            lblStoreB.Size = new Size(169, 48);
            lblStoreB.TabIndex = 7;
            lblStoreB.Text = "Store B";
            lblStoreB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtInputStoreB
            // 
            txtInputStoreB.BorderStyle = BorderStyle.None;
            txtInputStoreB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputStoreB.Location = new Point(699, 101);
            txtInputStoreB.Name = "txtInputStoreB";
            txtInputStoreB.PlaceholderText = "Store B";
            txtInputStoreB.Size = new Size(207, 43);
            txtInputStoreB.TabIndex = 2;
            // 
            // DefaultPageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1142, 722);
            Controls.Add(lblStoreB);
            Controls.Add(lblStoreA);
            Controls.Add(btnAddStore);
            Controls.Add(txtInputStoreA);
            Controls.Add(btnContinue);
            Controls.Add(txtInputStoreB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DefaultPageForm";
            Text = "Default Page";
            Load += DefaultPageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnContinue;
        private TextBox txtInputStoreA;
        private Button btnAddStore;
        private Label lblStoreA;
        private Label lblStoreB;
        private TextBox txtInputStoreB;
    }
}

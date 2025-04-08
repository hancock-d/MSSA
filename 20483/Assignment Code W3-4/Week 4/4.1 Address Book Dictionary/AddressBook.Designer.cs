namespace _4._1_Address_Book_Dictionary
{
    partial class AddressBook
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
            lblHeading = new Label();
            phoneGrid = new DataGridView();
            btnAddContact = new Button();
            btnDeleteContact = new Button();
            btnRefresh = new Button();
            btnSearchContact = new Button();
            txtSearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)phoneGrid).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.BackColor = Color.FromArgb(255, 128, 255);
            lblHeading.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(635, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(285, 77);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Phone Book";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneGrid
            // 
            phoneGrid.AllowUserToOrderColumns = true;
            phoneGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phoneGrid.Location = new Point(238, 151);
            phoneGrid.Name = "phoneGrid";
            phoneGrid.RowHeadersWidth = 82;
            phoneGrid.Size = new Size(1087, 518);
            phoneGrid.TabIndex = 1;
            // 
            // btnAddContact
            // 
            btnAddContact.BackColor = Color.FromArgb(255, 128, 255);
            btnAddContact.FlatStyle = FlatStyle.Popup;
            btnAddContact.Font = new Font("Segoe UI", 12F);
            btnAddContact.Location = new Point(133, 731);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(250, 96);
            btnAddContact.TabIndex = 2;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = false;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // btnDeleteContact
            // 
            btnDeleteContact.BackColor = Color.FromArgb(255, 128, 255);
            btnDeleteContact.FlatStyle = FlatStyle.Popup;
            btnDeleteContact.Font = new Font("Segoe UI", 12F);
            btnDeleteContact.Location = new Point(798, 731);
            btnDeleteContact.Name = "btnDeleteContact";
            btnDeleteContact.Size = new Size(250, 96);
            btnDeleteContact.TabIndex = 3;
            btnDeleteContact.Text = "Delete Contact";
            btnDeleteContact.UseVisualStyleBackColor = false;
            btnDeleteContact.Click += btnDeleteContact_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 128, 255);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Location = new Point(463, 731);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(250, 96);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchContact
            // 
            btnSearchContact.BackColor = Color.FromArgb(255, 128, 255);
            btnSearchContact.FlatAppearance.BorderSize = 5;
            btnSearchContact.FlatStyle = FlatStyle.Popup;
            btnSearchContact.Font = new Font("Segoe UI", 12F);
            btnSearchContact.Location = new Point(1121, 731);
            btnSearchContact.Name = "btnSearchContact";
            btnSearchContact.Size = new Size(257, 96);
            btnSearchContact.TabIndex = 5;
            btnSearchContact.Text = "Search Contacts";
            btnSearchContact.UseVisualStyleBackColor = false;
            btnSearchContact.Click += btnSearchContact_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Font = new Font("Segoe UI", 12F);
            txtSearchBox.Location = new Point(1121, 842);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = "First Last Name";
            txtSearchBox.Size = new Size(368, 50);
            txtSearchBox.TabIndex = 6;
            // 
            // AddressBook
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1612, 977);
            Controls.Add(txtSearchBox);
            Controls.Add(btnSearchContact);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteContact);
            Controls.Add(btnAddContact);
            Controls.Add(phoneGrid);
            Controls.Add(lblHeading);
            Name = "AddressBook";
            Text = "Form1";
            Load += AddressBook_Load;
            ((System.ComponentModel.ISupportInitialize)phoneGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private DataGridView phoneGrid;
        private Button btnAddContact;
        private Button btnDeleteContact;
        private Button btnRefresh;
        private Button btnSearchContact;
        private TextBox txtSearchBox;
    }
}

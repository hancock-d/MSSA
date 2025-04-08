namespace _4._1_Address_Book_Dictionary
{
    partial class AddContact
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
            grpContact = new GroupBox();
            btnCancel = new Button();
            btnSubmit = new Button();
            comboType = new ComboBox();
            txtAddress = new TextBox();
            txtPnumber = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            lblAddress = new Label();
            lblPhoneType = new Label();
            lblPhoneNumber = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            grpContact.SuspendLayout();
            SuspendLayout();
            // 
            // grpContact
            // 
            grpContact.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpContact.Controls.Add(btnCancel);
            grpContact.Controls.Add(btnSubmit);
            grpContact.Controls.Add(comboType);
            grpContact.Controls.Add(txtAddress);
            grpContact.Controls.Add(txtPnumber);
            grpContact.Controls.Add(txtLname);
            grpContact.Controls.Add(txtFname);
            grpContact.Controls.Add(lblAddress);
            grpContact.Controls.Add(lblPhoneType);
            grpContact.Controls.Add(lblPhoneNumber);
            grpContact.Controls.Add(lblLastName);
            grpContact.Controls.Add(lblFirstName);
            grpContact.Font = new Font("Segoe UI", 18F);
            grpContact.Location = new Point(53, 30);
            grpContact.Name = "grpContact";
            grpContact.Size = new Size(850, 976);
            grpContact.TabIndex = 0;
            grpContact.TabStop = false;
            grpContact.Text = "Contact Information";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(451, 854);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(198, 72);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Location = new Point(48, 854);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(238, 72);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // comboType
            // 
            comboType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(310, 510);
            comboType.Name = "comboType";
            comboType.Size = new Size(339, 53);
            comboType.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(318, 646);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(331, 107);
            txtAddress.TabIndex = 8;
            // 
            // txtPnumber
            // 
            txtPnumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPnumber.Location = new Point(318, 375);
            txtPnumber.Name = "txtPnumber";
            txtPnumber.Size = new Size(331, 50);
            txtPnumber.TabIndex = 7;
            // 
            // txtLname
            // 
            txtLname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLname.Location = new Point(318, 234);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(331, 50);
            txtLname.TabIndex = 6;
            // 
            // txtFname
            // 
            txtFname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFname.Location = new Point(318, 100);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(331, 50);
            txtFname.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI", 12F);
            lblAddress.Location = new Point(48, 649);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(238, 51);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblPhoneType
            // 
            lblPhoneType.Font = new Font("Segoe UI", 12F);
            lblPhoneType.Location = new Point(48, 512);
            lblPhoneType.Name = "lblPhoneType";
            lblPhoneType.Size = new Size(238, 51);
            lblPhoneType.TabIndex = 3;
            lblPhoneType.Text = "Phone Type";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI", 12F);
            lblPhoneNumber.Location = new Point(48, 374);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(238, 51);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI", 12F);
            lblLastName.Location = new Point(48, 233);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(175, 51);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI", 12F);
            lblFirstName.Location = new Point(48, 100);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(175, 49);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 1041);
            Controls.Add(grpContact);
            Name = "AddContact";
            Text = "AddContact";
            Load += AddContact_Load;
            grpContact.ResumeLayout(false);
            grpContact.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpContact;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private Label lblPhoneType;
        private ComboBox comboType;
        private TextBox txtAddress;
        private TextBox txtPnumber;
        private TextBox txtLname;
        private TextBox txtFname;
        private Button btnSubmit;
        private Button btnCancel;
    }
}
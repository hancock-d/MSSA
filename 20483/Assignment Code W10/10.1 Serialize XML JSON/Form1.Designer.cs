namespace _10._1_Serialize_XML_JSON
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
            txtName = new TextBox();
            txtGPA = new TextBox();
            txtAddress = new TextBox();
            lblName = new Label();
            lblAddress = new Label();
            lblGPA = new Label();
            btnCreate = new Button();
            btnJSONSer = new Button();
            btnJSONdeser = new Button();
            btnXMLser = new Button();
            btnXMLdeser = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(593, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 0;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(593, 227);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(200, 39);
            txtGPA.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(593, 160);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 39);
            txtAddress.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(327, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(168, 32);
            lblName.TabIndex = 3;
            lblName.Text = "Student Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(327, 163);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(188, 32);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Student Address";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(327, 234);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(146, 32);
            lblGPA.TabIndex = 5;
            lblGPA.Text = "Student GPA";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(417, 346);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(299, 46);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create Student";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnJSONSer
            // 
            btnJSONSer.Location = new Point(301, 522);
            btnJSONSer.Name = "btnJSONSer";
            btnJSONSer.Size = new Size(214, 46);
            btnJSONSer.TabIndex = 4;
            btnJSONSer.Text = "JSON Serialize";
            btnJSONSer.UseVisualStyleBackColor = true;
            btnJSONSer.Click += btnJSONSer_Click;
            // 
            // btnJSONdeser
            // 
            btnJSONdeser.Location = new Point(805, 522);
            btnJSONdeser.Name = "btnJSONdeser";
            btnJSONdeser.Size = new Size(214, 46);
            btnJSONdeser.TabIndex = 5;
            btnJSONdeser.Text = "JSON Deserialize";
            btnJSONdeser.UseVisualStyleBackColor = true;
            btnJSONdeser.Click += btnJSONdeser_Click;
            // 
            // btnXMLser
            // 
            btnXMLser.Location = new Point(281, 652);
            btnXMLser.Name = "btnXMLser";
            btnXMLser.Size = new Size(214, 46);
            btnXMLser.TabIndex = 6;
            btnXMLser.Text = "XML Serialize";
            btnXMLser.UseVisualStyleBackColor = true;
            btnXMLser.Click += btnXMLser_Click;
            // 
            // btnXMLdeser
            // 
            btnXMLdeser.Location = new Point(792, 652);
            btnXMLdeser.Name = "btnXMLdeser";
            btnXMLdeser.Size = new Size(214, 46);
            btnXMLdeser.TabIndex = 7;
            btnXMLdeser.Text = "XML deserialize";
            btnXMLdeser.UseVisualStyleBackColor = true;
            btnXMLdeser.Click += btnXMLdeser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 787);
            Controls.Add(btnXMLdeser);
            Controls.Add(btnXMLser);
            Controls.Add(btnJSONdeser);
            Controls.Add(btnJSONSer);
            Controls.Add(btnCreate);
            Controls.Add(lblGPA);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(txtAddress);
            Controls.Add(txtGPA);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtGPA;
        private TextBox txtAddress;
        private Label lblName;
        private Label lblAddress;
        private Label lblGPA;
        private Button btnCreate;
        private Button btnJSONSer;
        private Button btnJSONdeser;
        private Button btnXMLser;
        private Button btnXMLdeser;
    }
}

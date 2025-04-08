namespace Mod6_Serialization_Dave
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtGPA = new TextBox();
            lblStudId = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreate = new Button();
            btnJSONser = new Button();
            btnJSONdeser = new Button();
            btnXMLser = new Button();
            btnXMLdeser = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(947, 206);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 39);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(947, 298);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(947, 407);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 39);
            txtAddress.TabIndex = 2;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(947, 519);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(200, 39);
            txtGPA.TabIndex = 3;
            // 
            // lblStudId
            // 
            lblStudId.AutoSize = true;
            lblStudId.Location = new Point(658, 206);
            lblStudId.Name = "lblStudId";
            lblStudId.Size = new Size(124, 32);
            lblStudId.TabIndex = 4;
            lblStudId.Text = "Student Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(658, 305);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 5;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(658, 410);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 6;
            label2.Text = "Student Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(658, 519);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 7;
            label3.Text = "Student GPA";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(745, 686);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(238, 46);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create Student";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnJSONser
            // 
            btnJSONser.Location = new Point(623, 854);
            btnJSONser.Name = "btnJSONser";
            btnJSONser.Size = new Size(203, 46);
            btnJSONser.TabIndex = 9;
            btnJSONser.Text = "JSON Serialize";
            btnJSONser.UseVisualStyleBackColor = true;
            btnJSONser.Click += btnJSONser_Click;
            // 
            // btnJSONdeser
            // 
            btnJSONdeser.Location = new Point(965, 854);
            btnJSONdeser.Name = "btnJSONdeser";
            btnJSONdeser.Size = new Size(203, 46);
            btnJSONdeser.TabIndex = 10;
            btnJSONdeser.Text = "JSON Deserialize";
            btnJSONdeser.UseVisualStyleBackColor = true;
            btnJSONdeser.Click += btnJSONdeser_Click;
            // 
            // btnXMLser
            // 
            btnXMLser.Location = new Point(623, 944);
            btnXMLser.Name = "btnXMLser";
            btnXMLser.Size = new Size(203, 46);
            btnXMLser.TabIndex = 11;
            btnXMLser.Text = "XML Serialize";
            btnXMLser.UseVisualStyleBackColor = true;
            btnXMLser.Click += btnXMLser_Click;
            // 
            // btnXMLdeser
            // 
            btnXMLdeser.Location = new Point(965, 944);
            btnXMLdeser.Name = "btnXMLdeser";
            btnXMLdeser.Size = new Size(203, 46);
            btnXMLdeser.TabIndex = 12;
            btnXMLdeser.Text = "XML Deserialize";
            btnXMLdeser.UseVisualStyleBackColor = true;
            btnXMLdeser.Click += btnXMLdeser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1049);
            Controls.Add(btnXMLdeser);
            Controls.Add(btnXMLser);
            Controls.Add(btnJSONdeser);
            Controls.Add(btnJSONser);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStudId);
            Controls.Add(txtGPA);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtGPA;
        private Label lblStudId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCreate;
        private Button btnJSONser;
        private Button btnJSONdeser;
        private Button btnXMLser;
        private Button btnXMLdeser;
    }
}

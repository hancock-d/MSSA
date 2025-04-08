namespace Mod3EventsDel
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
            lblAccNum = new Label();
            lblBalance = new Label();
            txtAccNum = new TextBox();
            txtBalance = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lblAccNum
            // 
            lblAccNum.AutoSize = true;
            lblAccNum.Location = new Point(204, 75);
            lblAccNum.Name = "lblAccNum";
            lblAccNum.Size = new Size(125, 15);
            lblAccNum.TabIndex = 0;
            lblAccNum.Text = "BankAccount Number";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(204, 149);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(122, 15);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "BankAccount Balance";
            // 
            // txtAccNum
            // 
            txtAccNum.Location = new Point(456, 77);
            txtAccNum.Name = "txtAccNum";
            txtAccNum.Size = new Size(100, 23);
            txtAccNum.TabIndex = 2;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(456, 141);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(100, 23);
            txtBalance.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(339, 235);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(117, 52);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
           // btnCreate.Click += test;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(txtBalance);
            Controls.Add(txtAccNum);
            Controls.Add(lblBalance);
            Controls.Add(lblAccNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccNum;
        private Label lblBalance;
        private TextBox txtAccNum;
        private TextBox txtBalance;
        private Button btnCreate;
    }
}

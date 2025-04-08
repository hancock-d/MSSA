namespace _3._4_Order_Coffee
{
    partial class OrderUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUp));
            this.lblHeading = new System.Windows.Forms.Label();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCoffeeTemp = new System.Windows.Forms.Label();
            this.lblCupSize = new System.Windows.Forms.Label();
            this.lblDrink = new System.Windows.Forms.Label();
            this.lblBean = new System.Windows.Forms.Label();
            this.lblRoast = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.comboTemp = new System.Windows.Forms.ComboBox();
            this.comboCup = new System.Windows.Forms.ComboBox();
            this.comboDrink = new System.Windows.Forms.ComboBox();
            this.comboBean = new System.Windows.Forms.ComboBox();
            this.comboRoast = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Black;
            this.lblHeading.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(772, 31);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(235, 65);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Order Up";
            // 
            // ordersGrid
            // 
            this.ordersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Location = new System.Drawing.Point(184, 152);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.RowHeadersWidth = 82;
            this.ordersGrid.RowTemplate.Height = 33;
            this.ordersGrid.Size = new System.Drawing.Size(1420, 376);
            this.ordersGrid.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(48, 597);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(156, 37);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer";
            // 
            // lblCoffeeTemp
            // 
            this.lblCoffeeTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeTemp.Location = new System.Drawing.Point(48, 743);
            this.lblCoffeeTemp.Name = "lblCoffeeTemp";
            this.lblCoffeeTemp.Size = new System.Drawing.Size(200, 37);
            this.lblCoffeeTemp.TabIndex = 3;
            this.lblCoffeeTemp.Text = "Temperature";
            // 
            // lblCupSize
            // 
            this.lblCupSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupSize.Location = new System.Drawing.Point(49, 816);
            this.lblCupSize.Name = "lblCupSize";
            this.lblCupSize.Size = new System.Drawing.Size(100, 37);
            this.lblCupSize.TabIndex = 4;
            this.lblCupSize.Text = "Size";
            // 
            // lblDrink
            // 
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrink.Location = new System.Drawing.Point(48, 672);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(120, 37);
            this.lblDrink.TabIndex = 5;
            this.lblDrink.Text = "Drink";
            // 
            // lblBean
            // 
            this.lblBean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBean.Location = new System.Drawing.Point(49, 960);
            this.lblBean.Name = "lblBean";
            this.lblBean.Size = new System.Drawing.Size(119, 37);
            this.lblBean.TabIndex = 6;
            this.lblBean.Text = "Bean";
            // 
            // lblRoast
            // 
            this.lblRoast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoast.Location = new System.Drawing.Point(49, 886);
            this.lblRoast.Name = "lblRoast";
            this.lblRoast.Size = new System.Drawing.Size(120, 37);
            this.lblRoast.TabIndex = 7;
            this.lblRoast.Text = "Roast";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(264, 594);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(243, 44);
            this.txtCustomerName.TabIndex = 8;
            // 
            // comboTemp
            // 
            this.comboTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTemp.FormattingEnabled = true;
            this.comboTemp.Location = new System.Drawing.Point(264, 740);
            this.comboTemp.Name = "comboTemp";
            this.comboTemp.Size = new System.Drawing.Size(243, 45);
            this.comboTemp.TabIndex = 9;
            // 
            // comboCup
            // 
            this.comboCup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCup.FormattingEnabled = true;
            this.comboCup.Location = new System.Drawing.Point(264, 808);
            this.comboCup.Name = "comboCup";
            this.comboCup.Size = new System.Drawing.Size(243, 45);
            this.comboCup.TabIndex = 10;
            // 
            // comboDrink
            // 
            this.comboDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDrink.FormattingEnabled = true;
            this.comboDrink.Location = new System.Drawing.Point(264, 669);
            this.comboDrink.Name = "comboDrink";
            this.comboDrink.Size = new System.Drawing.Size(243, 45);
            this.comboDrink.TabIndex = 11;
            // 
            // comboBean
            // 
            this.comboBean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBean.FormattingEnabled = true;
            this.comboBean.Location = new System.Drawing.Point(264, 952);
            this.comboBean.Name = "comboBean";
            this.comboBean.Size = new System.Drawing.Size(243, 45);
            this.comboBean.TabIndex = 12;
            // 
            // comboRoast
            // 
            this.comboRoast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoast.FormattingEnabled = true;
            this.comboRoast.Location = new System.Drawing.Point(264, 878);
            this.comboRoast.Name = "comboRoast";
            this.comboRoast.Size = new System.Drawing.Size(243, 45);
            this.comboRoast.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1362, 597);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(233, 79);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh Orders";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(730, 1009);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(222, 83);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1087, 1009);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(222, 83);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OrderUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1988, 1134);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.comboRoast);
            this.Controls.Add(this.comboBean);
            this.Controls.Add(this.comboDrink);
            this.Controls.Add(this.comboCup);
            this.Controls.Add(this.comboTemp);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblRoast);
            this.Controls.Add(this.lblBean);
            this.Controls.Add(this.lblDrink);
            this.Controls.Add(this.lblCupSize);
            this.Controls.Add(this.lblCoffeeTemp);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.lblHeading);
            this.Name = "OrderUp";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCoffeeTemp;
        private System.Windows.Forms.Label lblCupSize;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Label lblBean;
        private System.Windows.Forms.Label lblRoast;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox comboTemp;
        private System.Windows.Forms.ComboBox comboCup;
        private System.Windows.Forms.ComboBox comboDrink;
        private System.Windows.Forms.ComboBox comboBean;
        private System.Windows.Forms.ComboBox comboRoast;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}


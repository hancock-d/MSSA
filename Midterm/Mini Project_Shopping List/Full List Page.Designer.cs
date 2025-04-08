namespace Mini_Project_Shopping_List
{
    partial class Full_List_Page
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Full_List_Page));
            txtAddItem = new TextBox();
            comboQuant = new ComboBox();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            rdoStoreA = new RadioButton();
            rdoStoreB = new RadioButton();
            storeAGrid = new DataGridView();
            storeBGrid = new DataGridView();
            lblStoreA = new Label();
            lblStoreB = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)storeAGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storeBGrid).BeginInit();
            SuspendLayout();
            // 
            // txtAddItem
            // 
            txtAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddItem.Location = new Point(680, 502);
            txtAddItem.Name = "txtAddItem";
            txtAddItem.PlaceholderText = "Grocery Item";
            txtAddItem.Size = new Size(238, 50);
            txtAddItem.TabIndex = 2;
            // 
            // comboQuant
            // 
            comboQuant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboQuant.FormattingEnabled = true;
            comboQuant.Location = new Point(712, 428);
            comboQuant.Name = "comboQuant";
            comboQuant.Size = new Size(142, 53);
            comboQuant.TabIndex = 4;
            comboQuant.Text = "#";
            // 
            // btnAddItem
            // 
            btnAddItem.AutoSize = true;
            btnAddItem.BackColor = SystemColors.ButtonFace;
            btnAddItem.FlatStyle = FlatStyle.Popup;
            btnAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(684, 650);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(192, 55);
            btnAddItem.TabIndex = 6;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.AutoSize = true;
            btnRemoveItem.BackColor = SystemColors.ButtonFace;
            btnRemoveItem.FlatStyle = FlatStyle.Popup;
            btnRemoveItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveItem.Location = new Point(65, 761);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(362, 55);
            btnRemoveItem.TabIndex = 7;
            btnRemoveItem.Text = "Remove Selected Items";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // rdoStoreA
            // 
            rdoStoreA.AutoSize = true;
            rdoStoreA.BackColor = Color.Transparent;
            rdoStoreA.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoStoreA.ForeColor = Color.Black;
            rdoStoreA.Location = new Point(689, 235);
            rdoStoreA.Name = "rdoStoreA";
            rdoStoreA.Size = new Size(131, 41);
            rdoStoreA.TabIndex = 11;
            rdoStoreA.TabStop = true;
            rdoStoreA.Text = "Store A";
            rdoStoreA.UseVisualStyleBackColor = false;
            // 
            // rdoStoreB
            // 
            rdoStoreB.AutoSize = true;
            rdoStoreB.BackColor = Color.Transparent;
            rdoStoreB.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoStoreB.ForeColor = Color.Black;
            rdoStoreB.Location = new Point(693, 312);
            rdoStoreB.Name = "rdoStoreB";
            rdoStoreB.Size = new Size(129, 41);
            rdoStoreB.TabIndex = 12;
            rdoStoreB.TabStop = true;
            rdoStoreB.Text = "Store B";
            rdoStoreB.UseVisualStyleBackColor = false;
            // 
            // storeAGrid
            // 
            storeAGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            storeAGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            storeAGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            storeAGrid.BackgroundColor = SystemColors.ControlLightLight;
            storeAGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            storeAGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            storeAGrid.GridColor = SystemColors.ControlLight;
            storeAGrid.Location = new Point(299, 228);
            storeAGrid.Name = "storeAGrid";
            storeAGrid.RowHeadersVisible = false;
            storeAGrid.RowHeadersWidth = 82;
            storeAGrid.Size = new Size(350, 350);
            storeAGrid.TabIndex = 13;
            // 
            // storeBGrid
            // 
            storeBGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            storeBGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            storeBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            storeBGrid.BackgroundColor = SystemColors.ControlLightLight;
            storeBGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            storeBGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            storeBGrid.DefaultCellStyle = dataGridViewCellStyle3;
            storeBGrid.GridColor = SystemColors.ControlLight;
            storeBGrid.Location = new Point(952, 228);
            storeBGrid.Name = "storeBGrid";
            storeBGrid.RowHeadersVisible = false;
            storeBGrid.RowHeadersWidth = 82;
            storeBGrid.Size = new Size(350, 350);
            storeBGrid.TabIndex = 14;
            // 
            // lblStoreA
            // 
            lblStoreA.AutoSize = true;
            lblStoreA.BackColor = Color.Transparent;
            lblStoreA.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblStoreA.ForeColor = Color.Black;
            lblStoreA.Location = new Point(357, 126);
            lblStoreA.Name = "lblStoreA";
            lblStoreA.Size = new Size(170, 59);
            lblStoreA.TabIndex = 15;
            lblStoreA.Text = "Store A";
            lblStoreA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStoreB
            // 
            lblStoreB.AutoSize = true;
            lblStoreB.BackColor = Color.Transparent;
            lblStoreB.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblStoreB.ForeColor = Color.Black;
            lblStoreB.Location = new Point(982, 126);
            lblStoreB.Name = "lblStoreB";
            lblStoreB.Size = new Size(168, 59);
            lblStoreB.TabIndex = 16;
            lblStoreB.Text = "Store B";
            lblStoreB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(1317, 770);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Full_List_Page
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1536, 828);
            Controls.Add(btnExit);
            Controls.Add(lblStoreB);
            Controls.Add(lblStoreA);
            Controls.Add(storeBGrid);
            Controls.Add(storeAGrid);
            Controls.Add(rdoStoreB);
            Controls.Add(rdoStoreA);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddItem);
            Controls.Add(comboQuant);
            Controls.Add(txtAddItem);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Full_List_Page";
            Text = "Grocery List";
            Load += Full_List_Page_Load;
            ((System.ComponentModel.ISupportInitialize)storeAGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)storeBGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddItem;
        private ComboBox comboQuant;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private RadioButton rdoStoreA;
        private RadioButton rdoStoreB;
        private DataGridView storeAGrid;
        private DataGridView storeBGrid;
        private Label lblStoreA;
        private Label lblStoreB;
        private Button btnExit;
    }
}
namespace InventorySystem2
{
    partial class SalesReportScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportScreen));
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminNameTxt = new System.Windows.Forms.Label();
            this.categoryManagementButton = new System.Windows.Forms.Button();
            this.userManagementButton = new System.Windows.Forms.Button();
            this.ProductManagemetButton = new System.Windows.Forms.Button();
            this.stockManagementButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.tillIDTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1226, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.adminNameTxt);
            this.panel3.Controls.Add(this.categoryManagementButton);
            this.panel3.Controls.Add(this.userManagementButton);
            this.panel3.Controls.Add(this.ProductManagemetButton);
            this.panel3.Controls.Add(this.stockManagementButton);
            this.panel3.Controls.Add(this.salesButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 109);
            this.panel3.TabIndex = 30;
            // 
            // adminNameTxt
            // 
            this.adminNameTxt.AutoSize = true;
            this.adminNameTxt.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminNameTxt.ForeColor = System.Drawing.Color.Gold;
            this.adminNameTxt.Location = new System.Drawing.Point(501, 0);
            this.adminNameTxt.Name = "adminNameTxt";
            this.adminNameTxt.Size = new System.Drawing.Size(131, 23);
            this.adminNameTxt.TabIndex = 14;
            this.adminNameTxt.Text = "adminName";
            this.adminNameTxt.Click += new System.EventHandler(this.adminNameTxt_Click);
            // 
            // categoryManagementButton
            // 
            this.categoryManagementButton.BackColor = System.Drawing.Color.Gold;
            this.categoryManagementButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryManagementButton.ForeColor = System.Drawing.Color.Black;
            this.categoryManagementButton.Location = new System.Drawing.Point(557, 61);
            this.categoryManagementButton.Name = "categoryManagementButton";
            this.categoryManagementButton.Size = new System.Drawing.Size(171, 36);
            this.categoryManagementButton.TabIndex = 25;
            this.categoryManagementButton.Text = "Category Management";
            this.categoryManagementButton.UseVisualStyleBackColor = false;
            this.categoryManagementButton.Click += new System.EventHandler(this.categoryManagementButton_Click);
            // 
            // userManagementButton
            // 
            this.userManagementButton.BackColor = System.Drawing.Color.Gold;
            this.userManagementButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userManagementButton.ForeColor = System.Drawing.Color.Black;
            this.userManagementButton.Location = new System.Drawing.Point(56, 61);
            this.userManagementButton.Name = "userManagementButton";
            this.userManagementButton.Size = new System.Drawing.Size(171, 36);
            this.userManagementButton.TabIndex = 23;
            this.userManagementButton.Text = "User Management";
            this.userManagementButton.UseVisualStyleBackColor = false;
            this.userManagementButton.Click += new System.EventHandler(this.userManagementButton_Click);
            // 
            // ProductManagemetButton
            // 
            this.ProductManagemetButton.BackColor = System.Drawing.Color.Gold;
            this.ProductManagemetButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductManagemetButton.ForeColor = System.Drawing.Color.Black;
            this.ProductManagemetButton.Location = new System.Drawing.Point(311, 61);
            this.ProductManagemetButton.Name = "ProductManagemetButton";
            this.ProductManagemetButton.Size = new System.Drawing.Size(171, 36);
            this.ProductManagemetButton.TabIndex = 24;
            this.ProductManagemetButton.Text = "Product Management";
            this.ProductManagemetButton.UseVisualStyleBackColor = false;
            // 
            // stockManagementButton
            // 
            this.stockManagementButton.BackColor = System.Drawing.Color.Gold;
            this.stockManagementButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockManagementButton.ForeColor = System.Drawing.Color.Black;
            this.stockManagementButton.Location = new System.Drawing.Point(799, 61);
            this.stockManagementButton.Name = "stockManagementButton";
            this.stockManagementButton.Size = new System.Drawing.Size(171, 36);
            this.stockManagementButton.TabIndex = 26;
            this.stockManagementButton.Text = "Stock Management";
            this.stockManagementButton.UseVisualStyleBackColor = false;
            this.stockManagementButton.Click += new System.EventHandler(this.stockManagementButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.Goldenrod;
            this.salesButton.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salesButton.ForeColor = System.Drawing.Color.Black;
            this.salesButton.Location = new System.Drawing.Point(1045, 61);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(171, 36);
            this.salesButton.TabIndex = 27;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Controls.Add(this.salesDataGridView);
            this.panel10.Location = new System.Drawing.Point(595, 157);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(630, 392);
            this.panel10.TabIndex = 95;
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.BackgroundColor = System.Drawing.Color.Gold;
            this.salesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.GridColor = System.Drawing.Color.Red;
            this.salesDataGridView.Location = new System.Drawing.Point(42, 40);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowHeadersWidth = 51;
            this.salesDataGridView.RowTemplate.Height = 29;
            this.salesDataGridView.Size = new System.Drawing.Size(543, 304);
            this.salesDataGridView.TabIndex = 64;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel11.Controls.Add(this.panel16);
            this.panel11.Controls.Add(this.panel17);
            this.panel11.Controls.Add(this.tillIDTxt);
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.button3);
            this.panel11.Controls.Add(this.radioButton1);
            this.panel11.Controls.Add(this.radioButton2);
            this.panel11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel11.Location = new System.Drawing.Point(112, 157);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(411, 392);
            this.panel11.TabIndex = 94;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Gold;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel16.Location = new System.Drawing.Point(35, 91);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(281, 2);
            this.panel16.TabIndex = 94;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Gold;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel17.Location = new System.Drawing.Point(35, 38);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(281, 2);
            this.panel17.TabIndex = 94;
            // 
            // tillIDTxt
            // 
            this.tillIDTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tillIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tillIDTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tillIDTxt.Location = new System.Drawing.Point(35, 66);
            this.tillIDTxt.Name = "tillIDTxt";
            this.tillIDTxt.Size = new System.Drawing.Size(281, 20);
            this.tillIDTxt.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 53;
            this.label14.Text = "Till ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(316, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 34);
            this.button3.TabIndex = 57;
            this.button3.Text = "🔎";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(243, 599);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 24);
            this.radioButton1.TabIndex = 48;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Attendant";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(102, 599);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(121, 24);
            this.radioButton2.TabIndex = 47;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Administrator";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // SalesReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 679);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReportScreen";
            this.Text = " ";
            this.Load += new System.EventHandler(this.SalesReportScreen_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Panel panel3;
        private Label adminNameTxt;
        private Label label1;
        private Button salesButton;
        private Button stockManagementButton;
        private Button categoryManagementButton;
        private Button ProductManagemetButton;
        private Button userManagementButton;
        private Panel panel10;
        private DataGridView salesDataGridView;
        private Panel panel11;
        private Panel panel16;
        private Panel panel17;
        private TextBox tillIDTxt;
        private Label label14;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button3;
    }
}
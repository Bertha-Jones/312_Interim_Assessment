namespace InventorySystem2
{
    partial class SalesReportScreenAttendant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.salesDataGridView);
            this.panel10.Location = new System.Drawing.Point(402, 59);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(770, 382);
            this.panel10.TabIndex = 97;
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.salesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.GridColor = System.Drawing.Color.Red;
            this.salesDataGridView.Location = new System.Drawing.Point(16, 29);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowHeadersWidth = 51;
            this.salesDataGridView.RowTemplate.Height = 29;
            this.salesDataGridView.Size = new System.Drawing.Size(725, 323);
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
            this.panel11.Location = new System.Drawing.Point(26, 120);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(370, 118);
            this.panel11.TabIndex = 96;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(14)))), ((int)(((byte)(41)))));
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel16.Location = new System.Drawing.Point(35, 81);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(281, 2);
            this.panel16.TabIndex = 94;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(14)))), ((int)(((byte)(41)))));
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel17.Location = new System.Drawing.Point(35, 28);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(281, 2);
            this.panel17.TabIndex = 94;
            // 
            // tillIDTxt
            // 
            this.tillIDTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tillIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tillIDTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tillIDTxt.Location = new System.Drawing.Point(35, 56);
            this.tillIDTxt.Name = "tillIDTxt";
            this.tillIDTxt.Size = new System.Drawing.Size(281, 20);
            this.tillIDTxt.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 33);
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
            this.button3.Location = new System.Drawing.Point(316, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 34);
            this.button3.TabIndex = 57;
            this.button3.Text = "🔎";
            this.button3.UseVisualStyleBackColor = false;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 20);
            this.label7.TabIndex = 100;
            this.label7.Text = "to go back to home screen\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SandyBrown;
            this.label6.Location = new System.Drawing.Point(92, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 99;
            this.label6.Text = "Start Session";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "Click";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1148, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 23);
            this.label8.TabIndex = 97;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // SalesReportScreenAttendant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1184, 556);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReportScreenAttendant";
            this.Text = "SalesReportScreenAttendant";
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel10;
        private DataGridView salesDataGridView;
        private Panel panel11;
        private Panel panel16;
        private Panel panel17;
        private TextBox tillIDTxt;
        private Label label14;
        private Button button3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
    }
}
namespace InventorySystem2
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.errorlbl = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.attendantButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.roleTxt = new System.Windows.Forms.Label();
            this.attendantIDTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(118, 217);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(281, 27);
            this.passwordTxt.TabIndex = 23;
            // 
            // errorlbl
            // 
            this.errorlbl.AutoSize = true;
            this.errorlbl.BackColor = System.Drawing.Color.Transparent;
            this.errorlbl.ForeColor = System.Drawing.Color.Red;
            this.errorlbl.Location = new System.Drawing.Point(118, 409);
            this.errorlbl.Name = "errorlbl";
            this.errorlbl.Size = new System.Drawing.Size(103, 20);
            this.errorlbl.TabIndex = 29;
            this.errorlbl.Text = "Error Message";
            this.errorlbl.Visible = false;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.Gold;
            this.logInButton.ForeColor = System.Drawing.Color.Black;
            this.logInButton.Location = new System.Drawing.Point(269, 342);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(130, 42);
            this.logInButton.TabIndex = 22;
            this.logInButton.Text = "LOGIN";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click_1);
            // 
            // attendantButton
            // 
            this.attendantButton.AutoSize = true;
            this.attendantButton.BackColor = System.Drawing.Color.Transparent;
            this.attendantButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.attendantButton.Location = new System.Drawing.Point(270, 267);
            this.attendantButton.Name = "attendantButton";
            this.attendantButton.Size = new System.Drawing.Size(96, 24);
            this.attendantButton.TabIndex = 28;
            this.attendantButton.TabStop = true;
            this.attendantButton.Text = "Attendant";
            this.attendantButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(133, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password";
            // 
            // adminButton
            // 
            this.adminButton.AutoSize = true;
            this.adminButton.BackColor = System.Drawing.Color.Transparent;
            this.adminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminButton.Location = new System.Drawing.Point(119, 267);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(121, 24);
            this.adminButton.TabIndex = 27;
            this.adminButton.TabStop = true;
            this.adminButton.Text = "Administrator";
            this.adminButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(133, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.emailTxt.Location = new System.Drawing.Point(118, 135);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(281, 27);
            this.emailTxt.TabIndex = 26;
            // 
            // roleTxt
            // 
            this.roleTxt.AutoSize = true;
            this.roleTxt.Location = new System.Drawing.Point(565, 185);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(39, 20);
            this.roleTxt.TabIndex = 30;
            this.roleTxt.Text = "Role";
            this.roleTxt.Visible = false;
            this.roleTxt.Click += new System.EventHandler(this.roleTxt_Click);
            // 
            // attendantIDTxt
            // 
            this.attendantIDTxt.AutoSize = true;
            this.attendantIDTxt.Location = new System.Drawing.Point(527, 271);
            this.attendantIDTxt.Name = "attendantIDTxt";
            this.attendantIDTxt.Size = new System.Drawing.Size(90, 20);
            this.attendantIDTxt.TabIndex = 31;
            this.attendantIDTxt.Text = "AttendantID";
            this.attendantIDTxt.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gold;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(993, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 23);
            this.label8.TabIndex = 97;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 609);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.attendantIDTxt);
            this.Controls.Add(this.roleTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.errorlbl);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.attendantButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox passwordTxt;
        private Label errorlbl;
        private Button logInButton;
        private RadioButton attendantButton;
        private Label label2;
        private RadioButton adminButton;
        private Label label3;
        private TextBox emailTxt;
        private Label roleTxt;
        private Label attendantIDTxt;
        private Label label8;
    }
}
namespace ALoxe
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Components.RJButton();
            txtEmail = new Components.RJTextBox();
            txtPassword = new Components.RJTextBox();
            lbMail = new Label();
            lbPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(101, 157);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(101, 239);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSlateBlue;
            btnLogin.BackgroundColor = Color.MediumSlateBlue;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(101, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(312, 42);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += rjButton1_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.MediumSlateBlue;
            txtEmail.BorderFocusColor = Color.HotPink;
            txtEmail.BorderRadius = 13;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Italic);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(103, 181);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceHolderText = null;
            txtEmail.Size = new Size(312, 35);
            txtEmail.TabIndex = 7;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = false;
            txtEmail._TextChanged += txtEmail__TextChanged;
            txtEmail.KeyDown += txtEmail_KeyDown;
            txtEmail.MouseLeave += txtEmail_MouseLeave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.MediumSlateBlue;
            txtPassword.BorderFocusColor = Color.HotPink;
            txtPassword.BorderRadius = 13;
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Italic);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(101, 262);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceHolderText = null;
            txtPassword.Size = new Size(312, 35);
            txtPassword.TabIndex = 8;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = false;
            txtPassword._TextChanged += txtPassword__TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(103, 219);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(100, 20);
            lbMail.TabIndex = 9;
            lbMail.Text = "mail message";
            lbMail.Visible = false;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(103, 301);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(100, 20);
            lbPass.TabIndex = 10;
            lbPass.Text = "mail message";
            lbPass.Visible = false;
            lbPass.Click += label4_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(515, 450);
            Controls.Add(lbPass);
            Controls.Add(lbMail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(533, 497);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Components.RJButton btnLogin;
        private Components.RJTextBox txtEmail;
        private Components.RJTextBox txtPassword;
        private Label lbMail;
        private Label lbPass;
    }
}

namespace FareMatrix
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_confirmpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_password = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_confirmpassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_signup = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtbox_username
            // 
            this.txtbox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_username.DefaultText = "";
            this.txtbox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_username.DisabledState.Parent = this.txtbox_username;
            this.txtbox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_username.FocusedState.Parent = this.txtbox_username;
            this.txtbox_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_username.HoverState.Parent = this.txtbox_username;
            this.txtbox_username.Location = new System.Drawing.Point(109, 64);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.PasswordChar = '\0';
            this.txtbox_username.PlaceholderText = "";
            this.txtbox_username.SelectedText = "";
            this.txtbox_username.ShadowDecoration.Parent = this.txtbox_username;
            this.txtbox_username.Size = new System.Drawing.Size(200, 27);
            this.txtbox_username.TabIndex = 0;
            this.txtbox_username.TextChanged += new System.EventHandler(this.txtbox_username_TextChanged);
            // 
            // txtbox_password
            // 
            this.txtbox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_password.DefaultText = "";
            this.txtbox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_password.DisabledState.Parent = this.txtbox_password;
            this.txtbox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_password.FocusedState.Parent = this.txtbox_password;
            this.txtbox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_password.HoverState.Parent = this.txtbox_password;
            this.txtbox_password.Location = new System.Drawing.Point(109, 97);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '\0';
            this.txtbox_password.PlaceholderText = "";
            this.txtbox_password.SelectedText = "";
            this.txtbox_password.ShadowDecoration.Parent = this.txtbox_password;
            this.txtbox_password.Size = new System.Drawing.Size(200, 27);
            this.txtbox_password.TabIndex = 1;
            this.txtbox_password.TextChanged += new System.EventHandler(this.txtbox_password_TextChanged);
            // 
            // txtbox_confirmpassword
            // 
            this.txtbox_confirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_confirmpassword.DefaultText = "";
            this.txtbox_confirmpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_confirmpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_confirmpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_confirmpassword.DisabledState.Parent = this.txtbox_confirmpassword;
            this.txtbox_confirmpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_confirmpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_confirmpassword.FocusedState.Parent = this.txtbox_confirmpassword;
            this.txtbox_confirmpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_confirmpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_confirmpassword.HoverState.Parent = this.txtbox_confirmpassword;
            this.txtbox_confirmpassword.Location = new System.Drawing.Point(109, 128);
            this.txtbox_confirmpassword.Name = "txtbox_confirmpassword";
            this.txtbox_confirmpassword.PasswordChar = '\0';
            this.txtbox_confirmpassword.PlaceholderText = "";
            this.txtbox_confirmpassword.SelectedText = "";
            this.txtbox_confirmpassword.ShadowDecoration.Parent = this.txtbox_confirmpassword;
            this.txtbox_confirmpassword.Size = new System.Drawing.Size(200, 27);
            this.txtbox_confirmpassword.TabIndex = 2;
            this.txtbox_confirmpassword.TextChanged += new System.EventHandler(this.txtbox_confirmpassword_TextChanged);
            // 
            // lbl_username
            // 
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_username.Location = new System.Drawing.Point(24, 70);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(64, 19);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_password.Location = new System.Drawing.Point(24, 103);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 19);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_confirmpassword
            // 
            this.lbl_confirmpassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmpassword.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmpassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_confirmpassword.Location = new System.Drawing.Point(24, 136);
            this.lbl_confirmpassword.Name = "lbl_confirmpassword";
            this.lbl_confirmpassword.Size = new System.Drawing.Size(76, 19);
            this.lbl_confirmpassword.TabIndex = 2;
            this.lbl_confirmpassword.Text = "Repassword:";
            // 
            // lbl_signup
            // 
            this.lbl_signup.BackColor = System.Drawing.Color.Transparent;
            this.lbl_signup.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_signup.Location = new System.Drawing.Point(232, 12);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(126, 35);
            this.lbl_signup.TabIndex = 3;
            this.lbl_signup.Text = "SIGN UP!";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(212, 173);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(97, 26);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Sign In";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::FareMatrix.Properties.Resources.img_509043;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(339, 59);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(181, 140);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(45, 24);
            this.btn_back.TabIndex = 6;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 230);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lbl_signup);
            this.Controls.Add(this.lbl_confirmpassword);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txtbox_confirmpassword);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Signup";
            this.Text = "Sign Up!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtbox_username;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_password;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_confirmpassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_username;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_password;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_confirmpassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_signup;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_back;
    }
}
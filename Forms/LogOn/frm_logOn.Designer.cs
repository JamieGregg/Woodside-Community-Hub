namespace WoodsideCommunityHub
{
    partial class frm_logOn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_logOn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_logon = new System.Windows.Forms.Label();
            this.lbl_staffID = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_logon = new System.Windows.Forms.Button();
            this.lbl_passwordForget = new System.Windows.Forms.Label();
            this.pbx_showPasswordLogIn = new System.Windows.Forms.PictureBox();
            this.gpb_logIn = new System.Windows.Forms.GroupBox();
            this.lbl_passwordError = new System.Windows.Forms.Label();
            this.lbl_usernameError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_showPasswordLogIn)).BeginInit();
            this.gpb_logIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-10, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 778);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 750);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Version 1.0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-31, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 335);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_logon
            // 
            this.lbl_logon.AutoSize = true;
            this.lbl_logon.Font = new System.Drawing.Font("Bahnschrift Condensed", 50F);
            this.lbl_logon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lbl_logon.Location = new System.Drawing.Point(707, 39);
            this.lbl_logon.Name = "lbl_logon";
            this.lbl_logon.Size = new System.Drawing.Size(173, 81);
            this.lbl_logon.TabIndex = 0;
            this.lbl_logon.Text = "LOG IN";
            // 
            // lbl_staffID
            // 
            this.lbl_staffID.AutoSize = true;
            this.lbl_staffID.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lbl_staffID.Location = new System.Drawing.Point(6, 15);
            this.lbl_staffID.Name = "lbl_staffID";
            this.lbl_staffID.Size = new System.Drawing.Size(261, 45);
            this.lbl_staffID.TabIndex = 1;
            this.lbl_staffID.Text = "Staff Login Number :";
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_username.Location = new System.Drawing.Point(14, 63);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(434, 30);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_password.Location = new System.Drawing.Point(14, 166);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(393, 30);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lbl_password.Location = new System.Drawing.Point(6, 118);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(148, 45);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password :";
            // 
            // btn_logon
            // 
            this.btn_logon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btn_logon.FlatAppearance.BorderSize = 0;
            this.btn_logon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logon.Font = new System.Drawing.Font("Bahnschrift Light", 25F);
            this.btn_logon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_logon.Location = new System.Drawing.Point(11, 264);
            this.btn_logon.Name = "btn_logon";
            this.btn_logon.Size = new System.Drawing.Size(434, 52);
            this.btn_logon.TabIndex = 5;
            this.btn_logon.Text = "LOG IN";
            this.btn_logon.UseVisualStyleBackColor = false;
            this.btn_logon.Click += new System.EventHandler(this.btn_logon_Click);
            // 
            // lbl_passwordForget
            // 
            this.lbl_passwordForget.AutoSize = true;
            this.lbl_passwordForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordForget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lbl_passwordForget.Location = new System.Drawing.Point(8, 238);
            this.lbl_passwordForget.Name = "lbl_passwordForget";
            this.lbl_passwordForget.Size = new System.Drawing.Size(170, 18);
            this.lbl_passwordForget.TabIndex = 6;
            this.lbl_passwordForget.Text = "Forgotten Password?";
            this.lbl_passwordForget.Click += new System.EventHandler(this.lbl_passwordForget_Click);
            // 
            // pbx_showPasswordLogIn
            // 
            this.pbx_showPasswordLogIn.Image = ((System.Drawing.Image)(resources.GetObject("pbx_showPasswordLogIn.Image")));
            this.pbx_showPasswordLogIn.Location = new System.Drawing.Point(410, 166);
            this.pbx_showPasswordLogIn.Name = "pbx_showPasswordLogIn";
            this.pbx_showPasswordLogIn.Size = new System.Drawing.Size(35, 30);
            this.pbx_showPasswordLogIn.TabIndex = 20;
            this.pbx_showPasswordLogIn.TabStop = false;
            this.pbx_showPasswordLogIn.MouseEnter += new System.EventHandler(this.pbx_showPasswordLogIn_MouseEnter);
            this.pbx_showPasswordLogIn.MouseLeave += new System.EventHandler(this.pbx_showPasswordLogIn_MouseLeave);
            // 
            // gpb_logIn
            // 
            this.gpb_logIn.Controls.Add(this.lbl_passwordError);
            this.gpb_logIn.Controls.Add(this.lbl_usernameError);
            this.gpb_logIn.Controls.Add(this.txt_password);
            this.gpb_logIn.Controls.Add(this.txt_username);
            this.gpb_logIn.Controls.Add(this.pbx_showPasswordLogIn);
            this.gpb_logIn.Controls.Add(this.lbl_staffID);
            this.gpb_logIn.Controls.Add(this.btn_logon);
            this.gpb_logIn.Controls.Add(this.lbl_password);
            this.gpb_logIn.Controls.Add(this.lbl_passwordForget);
            this.gpb_logIn.Location = new System.Drawing.Point(573, 123);
            this.gpb_logIn.Name = "gpb_logIn";
            this.gpb_logIn.Size = new System.Drawing.Size(457, 337);
            this.gpb_logIn.TabIndex = 21;
            this.gpb_logIn.TabStop = false;
            // 
            // lbl_passwordError
            // 
            this.lbl_passwordError.AutoSize = true;
            this.lbl_passwordError.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwordError.Location = new System.Drawing.Point(10, 198);
            this.lbl_passwordError.Name = "lbl_passwordError";
            this.lbl_passwordError.Size = new System.Drawing.Size(42, 23);
            this.lbl_passwordError.TabIndex = 22;
            this.lbl_passwordError.Text = "Error";
            this.lbl_passwordError.Visible = false;
            // 
            // lbl_usernameError
            // 
            this.lbl_usernameError.AutoSize = true;
            this.lbl_usernameError.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_usernameError.Location = new System.Drawing.Point(10, 94);
            this.lbl_usernameError.Name = "lbl_usernameError";
            this.lbl_usernameError.Size = new System.Drawing.Size(42, 23);
            this.lbl_usernameError.TabIndex = 21;
            this.lbl_usernameError.Text = "Error";
            this.lbl_usernameError.Visible = false;
            // 
            // frm_logOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 757);
            this.Controls.Add(this.gpb_logIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_logon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_logOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Woodside Community Hub";
            this.Load += new System.EventHandler(this.frm_logOn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_showPasswordLogIn)).EndInit();
            this.gpb_logIn.ResumeLayout(false);
            this.gpb_logIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_logon;
        private System.Windows.Forms.Label lbl_staffID;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_logon;
        private System.Windows.Forms.Label lbl_passwordForget;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbx_showPasswordLogIn;
        private System.Windows.Forms.GroupBox gpb_logIn;
        private System.Windows.Forms.Label lbl_usernameError;
        private System.Windows.Forms.Label lbl_passwordError;
    }
}


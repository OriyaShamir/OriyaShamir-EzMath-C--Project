namespace EZMath
{
    partial class LoginForm
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.LblCheck = new System.Windows.Forms.Label();
            this.CotaratLogin = new System.Windows.Forms.Label();
            this.loginrules = new System.Windows.Forms.Label();
            this.UsernameError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(199, 210);
            this.Username.Name = "Username";
            this.Username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Username.Size = new System.Drawing.Size(199, 26);
            this.Username.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(199, 255);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Password.Size = new System.Drawing.Size(199, 26);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 211);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "שם משתמש:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 255);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "סיסמא:";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(302, 339);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(96, 44);
            this.Login.TabIndex = 4;
            this.Login.Text = "הכנס";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LblCheck
            // 
            this.LblCheck.AutoSize = true;
            this.LblCheck.Location = new System.Drawing.Point(342, 293);
            this.LblCheck.Name = "LblCheck";
            this.LblCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblCheck.Size = new System.Drawing.Size(0, 13);
            this.LblCheck.TabIndex = 7;
            this.LblCheck.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CotaratLogin
            // 
            this.CotaratLogin.AutoSize = true;
            this.CotaratLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CotaratLogin.Location = new System.Drawing.Point(199, 37);
            this.CotaratLogin.Name = "CotaratLogin";
            this.CotaratLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CotaratLogin.Size = new System.Drawing.Size(286, 29);
            this.CotaratLogin.TabIndex = 8;
            this.CotaratLogin.Text = "ברוך הבא למתמטיקה בקליל! ";
            // 
            // loginrules
            // 
            this.loginrules.AutoSize = true;
            this.loginrules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginrules.Location = new System.Drawing.Point(356, 101);
            this.loginrules.Name = "loginrules";
            this.loginrules.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginrules.Size = new System.Drawing.Size(320, 24);
            this.loginrules.TabIndex = 9;
            this.loginrules.Text = "אנא הזן שם משתמש וססמא כדי להתחבר!";
            // 
            // UsernameError
            // 
            this.UsernameError.AutoSize = true;
            this.UsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameError.ForeColor = System.Drawing.Color.Red;
            this.UsernameError.Location = new System.Drawing.Point(167, 192);
            this.UsernameError.Name = "UsernameError";
            this.UsernameError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UsernameError.Size = new System.Drawing.Size(0, 20);
            this.UsernameError.TabIndex = 5;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(167, 236);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PasswordError.Size = new System.Drawing.Size(0, 20);
            this.PasswordError.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 431);
            this.Controls.Add(this.loginrules);
            this.Controls.Add(this.CotaratLogin);
            this.Controls.Add(this.LblCheck);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.UsernameError);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label LblCheck;
        private System.Windows.Forms.Label CotaratLogin;
        private System.Windows.Forms.Label loginrules;
        private System.Windows.Forms.Label UsernameError;
        private System.Windows.Forms.Label PasswordError;
    }
}


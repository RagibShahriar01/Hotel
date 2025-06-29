namespace Hotel
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forgotbutton = new System.Windows.Forms.Button();
            this.Registerationbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "Admin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 41);
            this.label3.TabIndex = 24;
            this.label3.Text = "Login to Account";
            // 
            // forgotbutton
            // 
            this.forgotbutton.Font = new System.Drawing.Font("Myanmar Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotbutton.Location = new System.Drawing.Point(349, 238);
            this.forgotbutton.Name = "forgotbutton";
            this.forgotbutton.Size = new System.Drawing.Size(152, 23);
            this.forgotbutton.TabIndex = 23;
            this.forgotbutton.Text = "Forgotten Password?";
            this.forgotbutton.UseVisualStyleBackColor = true;
            this.forgotbutton.Click += new System.EventHandler(this.forgotbutton_Click);
            // 
            // Registerationbutton
            // 
            this.Registerationbutton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerationbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Registerationbutton.Location = new System.Drawing.Point(415, 316);
            this.Registerationbutton.Name = "Registerationbutton";
            this.Registerationbutton.Size = new System.Drawing.Size(115, 38);
            this.Registerationbutton.TabIndex = 22;
            this.Registerationbutton.Text = "Register";
            this.Registerationbutton.UseVisualStyleBackColor = true;
            this.Registerationbutton.Click += new System.EventHandler(this.Registerationbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginbutton.Location = new System.Drawing.Point(224, 316);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(96, 38);
            this.loginbutton.TabIndex = 21;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(349, 210);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(152, 22);
            this.passwordtext.TabIndex = 20;
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(349, 136);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(152, 22);
            this.usernametext.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "User Name";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forgotbutton);
            this.Controls.Add(this.Registerationbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button forgotbutton;
        private System.Windows.Forms.Button Registerationbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


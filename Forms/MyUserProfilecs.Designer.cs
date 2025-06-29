namespace Hotel.Forms
{
    partial class MyUserProfilecs
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
            this.updatepic = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.mobiletextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // updatepic
            // 
            this.updatepic.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepic.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updatepic.Location = new System.Drawing.Point(181, 141);
            this.updatepic.Name = "updatepic";
            this.updatepic.Size = new System.Drawing.Size(150, 46);
            this.updatepic.TabIndex = 17;
            this.updatepic.Text = "Update Picture";
            this.updatepic.UseVisualStyleBackColor = true;
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.editbutton.Location = new System.Drawing.Point(602, 140);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(132, 46);
            this.editbutton.TabIndex = 18;
            this.editbutton.Text = "Edit Profile";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cancelbutton.Location = new System.Drawing.Point(465, 383);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(79, 44);
            this.cancelbutton.TabIndex = 19;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.savebutton.Location = new System.Drawing.Point(214, 383);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(88, 43);
            this.savebutton.TabIndex = 20;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(95, 244);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(95, 30);
            this.username.TabIndex = 21;
            this.username.Text = "UserName";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(133, 319);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 30);
            this.email.TabIndex = 22;
            this.email.Text = "Email";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.Location = new System.Drawing.Point(405, 242);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(139, 30);
            this.mobile.TabIndex = 23;
            this.mobile.Text = "Mobile Numner";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(460, 323);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(77, 30);
            this.address.TabIndex = 24;
            this.address.Text = "Address";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(196, 246);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(171, 22);
            this.usernametextBox.TabIndex = 25;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(196, 321);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(171, 22);
            this.emailtextBox.TabIndex = 26;
            // 
            // mobiletextBox
            // 
            this.mobiletextBox.Location = new System.Drawing.Point(551, 244);
            this.mobiletextBox.Name = "mobiletextBox";
            this.mobiletextBox.Size = new System.Drawing.Size(183, 22);
            this.mobiletextBox.TabIndex = 27;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(551, 323);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(183, 22);
            this.addresstextBox.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "Profile Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(164, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 57);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfilePicture.Location = new System.Drawing.Point(46, 72);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(118, 115);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProfilePicture.TabIndex = 16;
            this.pbProfilePicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvOrders);
            this.panel2.Location = new System.Drawing.Point(1, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 289);
            this.panel2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "Booking Information";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(3, 43);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(877, 225);
            this.dgvOrders.TabIndex = 30;
            // 
            // MyUserProfilecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(882, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.mobiletextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.updatepic);
            this.Controls.Add(this.pbProfilePicture);
            this.Name = "MyUserProfilecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyUserProfilecs";
            this.Load += new System.EventHandler(this.MyUserProfilecs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Button updatepic;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox mobiletextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}
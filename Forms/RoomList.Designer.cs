namespace Hotel.Forms
{
    partial class RoomList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ac = new System.Windows.Forms.Label();
            this.NonAc = new System.Windows.Forms.Label();
            this.CheckIndateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckOutdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Location = new System.Drawing.Point(2, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 740);
            this.panel1.TabIndex = 0;
            // 
            // Ac
            // 
            this.Ac.AutoSize = true;
            this.Ac.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ac.Location = new System.Drawing.Point(260, 93);
            this.Ac.Name = "Ac";
            this.Ac.Size = new System.Drawing.Size(39, 36);
            this.Ac.TabIndex = 1;
            this.Ac.Text = "Ac";
            this.Ac.Click += new System.EventHandler(this.Ac_Click);
            // 
            // NonAc
            // 
            this.NonAc.AutoSize = true;
            this.NonAc.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NonAc.Location = new System.Drawing.Point(314, 93);
            this.NonAc.Name = "NonAc";
            this.NonAc.Size = new System.Drawing.Size(85, 36);
            this.NonAc.TabIndex = 2;
            this.NonAc.Text = "Non Ac";
            // 
            // CheckIndateTimePicker
            // 
            this.CheckIndateTimePicker.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckIndateTimePicker.Location = new System.Drawing.Point(608, 89);
            this.CheckIndateTimePicker.Name = "CheckIndateTimePicker";
            this.CheckIndateTimePicker.Size = new System.Drawing.Size(200, 40);
            this.CheckIndateTimePicker.TabIndex = 3;
            this.CheckIndateTimePicker.ValueChanged += new System.EventHandler(this.CheckIndateTimePicker_ValueChanged);
            // 
            // CheckOutdateTimePicker
            // 
            this.CheckOutdateTimePicker.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutdateTimePicker.Location = new System.Drawing.Point(943, 85);
            this.CheckOutdateTimePicker.Name = "CheckOutdateTimePicker";
            this.CheckOutdateTimePicker.Size = new System.Drawing.Size(200, 40);
            this.CheckOutdateTimePicker.TabIndex = 4;
            this.CheckOutdateTimePicker.ValueChanged += new System.EventHandler(this.CheckOutdateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Show Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1089, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Logout";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(513, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "CheckIn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(831, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "CheckOut";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(36, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Choose AC/Non AC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(429, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 50);
            this.label6.TabIndex = 10;
            this.label6.Text = "Welcome to Hotel Taj";
            // 
            // RoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1182, 873);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckOutdateTimePicker);
            this.Controls.Add(this.CheckIndateTimePicker);
            this.Controls.Add(this.NonAc);
            this.Controls.Add(this.Ac);
            this.Controls.Add(this.panel1);
            this.Name = "RoomList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomList";
            this.Load += new System.EventHandler(this.RoomList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ac;
        private System.Windows.Forms.Label NonAc;
        private System.Windows.Forms.DateTimePicker CheckIndateTimePicker;
        private System.Windows.Forms.DateTimePicker CheckOutdateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
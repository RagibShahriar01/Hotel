namespace Hotel.Forms
{
    partial class Payment
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radiocash = new System.Windows.Forms.RadioButton();
            this.radioNagad = new System.Windows.Forms.RadioButton();
            this.radioBkash = new System.Windows.Forms.RadioButton();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 41);
            this.label3.TabIndex = 22;
            this.label3.Text = "Confirm Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Choose Payment Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "You have to pay";
            // 
            // radiocash
            // 
            this.radiocash.AutoSize = true;
            this.radiocash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiocash.Location = new System.Drawing.Point(272, 266);
            this.radiocash.Name = "radiocash";
            this.radiocash.Size = new System.Drawing.Size(174, 24);
            this.radiocash.TabIndex = 19;
            this.radiocash.TabStop = true;
            this.radiocash.Text = "Cash on Delivery";
            this.radiocash.UseVisualStyleBackColor = true;
            // 
            // radioNagad
            // 
            this.radioNagad.AutoSize = true;
            this.radioNagad.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNagad.Location = new System.Drawing.Point(488, 264);
            this.radioNagad.Name = "radioNagad";
            this.radioNagad.Size = new System.Drawing.Size(78, 34);
            this.radioNagad.TabIndex = 18;
            this.radioNagad.TabStop = true;
            this.radioNagad.Text = "Ngad";
            this.radioNagad.UseVisualStyleBackColor = true;
            // 
            // radioBkash
            // 
            this.radioBkash.AutoSize = true;
            this.radioBkash.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBkash.Location = new System.Drawing.Point(152, 264);
            this.radioBkash.Name = "radioBkash";
            this.radioBkash.Size = new System.Drawing.Size(81, 34);
            this.radioBkash.TabIndex = 17;
            this.radioBkash.TabStop = true;
            this.radioBkash.Text = "Bkash";
            this.radioBkash.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPlaceOrder.Location = new System.Drawing.Point(311, 350);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(180, 52);
            this.btnPlaceOrder.TabIndex = 16;
            this.btnPlaceOrder.Text = "Confirm Booking";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(416, 134);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(75, 30);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "amount";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radiocash);
            this.Controls.Add(this.radioNagad);
            this.Controls.Add(this.radioBkash);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblAmount);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiocash;
        private System.Windows.Forms.RadioButton radioNagad;
        private System.Windows.Forms.RadioButton radioBkash;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblAmount;
    }
}
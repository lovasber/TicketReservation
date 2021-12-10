
namespace TicketReservation
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
            this.dgvBasket = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalValue = new System.Windows.Forms.Label();
            this.tbCupon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCupon = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBasket
            // 
            this.dgvBasket.AllowUserToAddRows = false;
            this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasket.Location = new System.Drawing.Point(51, 62);
            this.dgvBasket.Name = "dgvBasket";
            this.dgvBasket.ReadOnly = true;
            this.dgvBasket.RowTemplate.Height = 25;
            this.dgvBasket.Size = new System.Drawing.Size(581, 132);
            this.dgvBasket.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // lbTotalValue
            // 
            this.lbTotalValue.AutoSize = true;
            this.lbTotalValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalValue.Location = new System.Drawing.Point(219, 295);
            this.lbTotalValue.Name = "lbTotalValue";
            this.lbTotalValue.Size = new System.Drawing.Size(27, 25);
            this.lbTotalValue.TabIndex = 2;
            this.lbTotalValue.Text = "Ft";
            // 
            // tbCupon
            // 
            this.tbCupon.Location = new System.Drawing.Point(146, 256);
            this.tbCupon.Name = "tbCupon";
            this.tbCupon.Size = new System.Drawing.Size(100, 23);
            this.tbCupon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cupon code";
            // 
            // btnCupon
            // 
            this.btnCupon.Location = new System.Drawing.Point(276, 256);
            this.btnCupon.Name = "btnCupon";
            this.btnCupon.Size = new System.Drawing.Size(75, 23);
            this.btnCupon.TabIndex = 5;
            this.btnCupon.Text = "OK";
            this.btnCupon.UseVisualStyleBackColor = true;
            this.btnCupon.Click += new System.EventHandler(this.btnCupon_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(470, 244);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(162, 47);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay Now";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(289, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your basket";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(146, 212);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 23);
            this.tbName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Your name";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCupon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCupon);
            this.Controls.Add(this.lbTotalValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBasket);
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBasket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalValue;
        private System.Windows.Forms.TextBox tbCupon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCupon;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
    }
}
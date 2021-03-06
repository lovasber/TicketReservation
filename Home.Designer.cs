
namespace TicketReservation
{
    partial class Home
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.seat24 = new System.Windows.Forms.Button();
            this.seat16 = new System.Windows.Forms.Button();
            this.seat23 = new System.Windows.Forms.Button();
            this.seat15 = new System.Windows.Forms.Button();
            this.seat20 = new System.Windows.Forms.Button();
            this.seat12 = new System.Windows.Forms.Button();
            this.seat22 = new System.Windows.Forms.Button();
            this.seat14 = new System.Windows.Forms.Button();
            this.seat19 = new System.Windows.Forms.Button();
            this.seat11 = new System.Windows.Forms.Button();
            this.seat8 = new System.Windows.Forms.Button();
            this.seat18 = new System.Windows.Forms.Button();
            this.seat10 = new System.Windows.Forms.Button();
            this.seat21 = new System.Windows.Forms.Button();
            this.seat13 = new System.Windows.Forms.Button();
            this.seat4 = new System.Windows.Forms.Button();
            this.seat7 = new System.Windows.Forms.Button();
            this.seat17 = new System.Windows.Forms.Button();
            this.seat9 = new System.Windows.Forms.Button();
            this.seat6 = new System.Windows.Forms.Button();
            this.seat3 = new System.Windows.Forms.Button();
            this.seat5 = new System.Windows.Forms.Button();
            this.seat2 = new System.Windows.Forms.Button();
            this.seat1 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chbInternational = new System.Windows.Forms.CheckBox();
            this.chFirstClass = new System.Windows.Forms.CheckBox();
            this.lbStops = new System.Windows.Forms.Label();
            this.dgvBasket = new System.Windows.Forms.DataGridView();
            this.dgvStops = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStops)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(67, 57);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(107, 38);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfoClick);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(794, 57);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(107, 38);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnMyTickets_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1631, 57);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(107, 38);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(138, 197);
            this.cmbFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(255, 33);
            this.cmbFrom.TabIndex = 3;
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(516, 197);
            this.cmbTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(264, 33);
            this.cmbTo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.seat24);
            this.panel1.Controls.Add(this.seat16);
            this.panel1.Controls.Add(this.seat23);
            this.panel1.Controls.Add(this.seat15);
            this.panel1.Controls.Add(this.seat20);
            this.panel1.Controls.Add(this.seat12);
            this.panel1.Controls.Add(this.seat22);
            this.panel1.Controls.Add(this.seat14);
            this.panel1.Controls.Add(this.seat19);
            this.panel1.Controls.Add(this.seat11);
            this.panel1.Controls.Add(this.seat8);
            this.panel1.Controls.Add(this.seat18);
            this.panel1.Controls.Add(this.seat10);
            this.panel1.Controls.Add(this.seat21);
            this.panel1.Controls.Add(this.seat13);
            this.panel1.Controls.Add(this.seat4);
            this.panel1.Controls.Add(this.seat7);
            this.panel1.Controls.Add(this.seat17);
            this.panel1.Controls.Add(this.seat9);
            this.panel1.Controls.Add(this.seat6);
            this.panel1.Controls.Add(this.seat3);
            this.panel1.Controls.Add(this.seat5);
            this.panel1.Controls.Add(this.seat2);
            this.panel1.Controls.Add(this.seat1);
            this.panel1.Location = new System.Drawing.Point(67, 315);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 515);
            this.panel1.TabIndex = 7;
            // 
            // seat24
            // 
            this.seat24.Location = new System.Drawing.Point(1030, 353);
            this.seat24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat24.Name = "seat24";
            this.seat24.Size = new System.Drawing.Size(83, 77);
            this.seat24.TabIndex = 1;
            this.seat24.Text = "Num";
            this.seat24.UseVisualStyleBackColor = true;
            // 
            // seat16
            // 
            this.seat16.Location = new System.Drawing.Point(1030, 157);
            this.seat16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat16.Name = "seat16";
            this.seat16.Size = new System.Drawing.Size(83, 77);
            this.seat16.TabIndex = 1;
            this.seat16.Text = "Num";
            this.seat16.UseVisualStyleBackColor = true;
            // 
            // seat23
            // 
            this.seat23.Location = new System.Drawing.Point(903, 353);
            this.seat23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat23.Name = "seat23";
            this.seat23.Size = new System.Drawing.Size(83, 77);
            this.seat23.TabIndex = 0;
            this.seat23.Text = "Num";
            this.seat23.UseVisualStyleBackColor = true;
            // 
            // seat15
            // 
            this.seat15.Location = new System.Drawing.Point(903, 157);
            this.seat15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat15.Name = "seat15";
            this.seat15.Size = new System.Drawing.Size(83, 77);
            this.seat15.TabIndex = 0;
            this.seat15.Text = "Num";
            this.seat15.UseVisualStyleBackColor = true;
            // 
            // seat20
            // 
            this.seat20.Location = new System.Drawing.Point(471, 353);
            this.seat20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat20.Name = "seat20";
            this.seat20.Size = new System.Drawing.Size(83, 77);
            this.seat20.TabIndex = 1;
            this.seat20.Text = "Num";
            this.seat20.UseVisualStyleBackColor = true;
            // 
            // seat12
            // 
            this.seat12.Location = new System.Drawing.Point(471, 157);
            this.seat12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat12.Name = "seat12";
            this.seat12.Size = new System.Drawing.Size(83, 77);
            this.seat12.TabIndex = 1;
            this.seat12.Text = "Num";
            this.seat12.UseVisualStyleBackColor = true;
            // 
            // seat22
            // 
            this.seat22.Location = new System.Drawing.Point(757, 353);
            this.seat22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat22.Name = "seat22";
            this.seat22.Size = new System.Drawing.Size(83, 77);
            this.seat22.TabIndex = 1;
            this.seat22.Text = "Num";
            this.seat22.UseVisualStyleBackColor = true;
            // 
            // seat14
            // 
            this.seat14.Location = new System.Drawing.Point(757, 157);
            this.seat14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat14.Name = "seat14";
            this.seat14.Size = new System.Drawing.Size(83, 77);
            this.seat14.TabIndex = 1;
            this.seat14.Text = "Num";
            this.seat14.UseVisualStyleBackColor = true;
            // 
            // seat19
            // 
            this.seat19.Location = new System.Drawing.Point(344, 353);
            this.seat19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat19.Name = "seat19";
            this.seat19.Size = new System.Drawing.Size(83, 77);
            this.seat19.TabIndex = 0;
            this.seat19.Text = "Num";
            this.seat19.UseVisualStyleBackColor = true;
            // 
            // seat11
            // 
            this.seat11.Location = new System.Drawing.Point(344, 157);
            this.seat11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat11.Name = "seat11";
            this.seat11.Size = new System.Drawing.Size(83, 77);
            this.seat11.TabIndex = 0;
            this.seat11.Text = "Num";
            this.seat11.UseVisualStyleBackColor = true;
            // 
            // seat8
            // 
            this.seat8.Location = new System.Drawing.Point(1030, 43);
            this.seat8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat8.Name = "seat8";
            this.seat8.Size = new System.Drawing.Size(83, 77);
            this.seat8.TabIndex = 1;
            this.seat8.Text = "Num";
            this.seat8.UseVisualStyleBackColor = true;
            // 
            // seat18
            // 
            this.seat18.Location = new System.Drawing.Point(199, 353);
            this.seat18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat18.Name = "seat18";
            this.seat18.Size = new System.Drawing.Size(83, 77);
            this.seat18.TabIndex = 1;
            this.seat18.Text = "Num";
            this.seat18.UseVisualStyleBackColor = true;
            // 
            // seat10
            // 
            this.seat10.Location = new System.Drawing.Point(199, 157);
            this.seat10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat10.Name = "seat10";
            this.seat10.Size = new System.Drawing.Size(83, 77);
            this.seat10.TabIndex = 1;
            this.seat10.Text = "Num";
            this.seat10.UseVisualStyleBackColor = true;
            // 
            // seat21
            // 
            this.seat21.Location = new System.Drawing.Point(630, 353);
            this.seat21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat21.Name = "seat21";
            this.seat21.Size = new System.Drawing.Size(83, 77);
            this.seat21.TabIndex = 0;
            this.seat21.Text = "Num";
            this.seat21.UseVisualStyleBackColor = true;
            // 
            // seat13
            // 
            this.seat13.Location = new System.Drawing.Point(630, 157);
            this.seat13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat13.Name = "seat13";
            this.seat13.Size = new System.Drawing.Size(83, 77);
            this.seat13.TabIndex = 0;
            this.seat13.Text = "Num";
            this.seat13.UseVisualStyleBackColor = true;
            // 
            // seat4
            // 
            this.seat4.Location = new System.Drawing.Point(471, 43);
            this.seat4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(83, 77);
            this.seat4.TabIndex = 1;
            this.seat4.Text = "Num";
            this.seat4.UseVisualStyleBackColor = true;
            // 
            // seat7
            // 
            this.seat7.Location = new System.Drawing.Point(903, 43);
            this.seat7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(83, 77);
            this.seat7.TabIndex = 0;
            this.seat7.Text = "Num";
            this.seat7.UseVisualStyleBackColor = true;
            // 
            // seat17
            // 
            this.seat17.Location = new System.Drawing.Point(71, 353);
            this.seat17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat17.Name = "seat17";
            this.seat17.Size = new System.Drawing.Size(83, 77);
            this.seat17.TabIndex = 0;
            this.seat17.Text = "Num";
            this.seat17.UseVisualStyleBackColor = true;
            // 
            // seat9
            // 
            this.seat9.Location = new System.Drawing.Point(71, 157);
            this.seat9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat9.Name = "seat9";
            this.seat9.Size = new System.Drawing.Size(83, 77);
            this.seat9.TabIndex = 0;
            this.seat9.Text = "Num";
            this.seat9.UseVisualStyleBackColor = true;
            // 
            // seat6
            // 
            this.seat6.Location = new System.Drawing.Point(757, 43);
            this.seat6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(83, 77);
            this.seat6.TabIndex = 1;
            this.seat6.Text = "Num";
            this.seat6.UseVisualStyleBackColor = true;
            // 
            // seat3
            // 
            this.seat3.Location = new System.Drawing.Point(344, 43);
            this.seat3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(83, 77);
            this.seat3.TabIndex = 0;
            this.seat3.Text = "Num";
            this.seat3.UseVisualStyleBackColor = true;
            // 
            // seat5
            // 
            this.seat5.Location = new System.Drawing.Point(630, 43);
            this.seat5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(83, 77);
            this.seat5.TabIndex = 0;
            this.seat5.Text = "Num";
            this.seat5.UseVisualStyleBackColor = true;
            // 
            // seat2
            // 
            this.seat2.Location = new System.Drawing.Point(199, 43);
            this.seat2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(83, 77);
            this.seat2.TabIndex = 1;
            this.seat2.Text = "Num";
            this.seat2.UseVisualStyleBackColor = true;
            // 
            // seat1
            // 
            this.seat1.Location = new System.Drawing.Point(71, 43);
            this.seat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(83, 77);
            this.seat1.TabIndex = 0;
            this.seat1.Text = "Num";
            this.seat1.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(1447, 830);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(183, 93);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Pay Now";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1344, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Basket";
            // 
            // chbInternational
            // 
            this.chbInternational.AutoSize = true;
            this.chbInternational.Location = new System.Drawing.Point(842, 202);
            this.chbInternational.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbInternational.Name = "chbInternational";
            this.chbInternational.Size = new System.Drawing.Size(137, 29);
            this.chbInternational.TabIndex = 12;
            this.chbInternational.Text = "International";
            this.chbInternational.UseVisualStyleBackColor = true;
            this.chbInternational.CheckedChanged += new System.EventHandler(this.chbInternational_CheckedChanged);
            // 
            // chFirstClass
            // 
            this.chFirstClass.AutoSize = true;
            this.chFirstClass.Location = new System.Drawing.Point(1058, 199);
            this.chFirstClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chFirstClass.Name = "chFirstClass";
            this.chFirstClass.Size = new System.Drawing.Size(107, 29);
            this.chFirstClass.TabIndex = 13;
            this.chFirstClass.Text = "1st Class";
            this.chFirstClass.UseVisualStyleBackColor = true;
            this.chFirstClass.CheckedChanged += new System.EventHandler(this.chFirstClass_CheckedChanged);
            // 
            // lbStops
            // 
            this.lbStops.AutoSize = true;
            this.lbStops.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStops.Location = new System.Drawing.Point(1344, 116);
            this.lbStops.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStops.Name = "lbStops";
            this.lbStops.Size = new System.Drawing.Size(82, 26);
            this.lbStops.TabIndex = 10;
            this.lbStops.Text = "Stops";
            // 
            // dgvBasket
            // 
            this.dgvBasket.AllowUserToAddRows = false;
            this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasket.Location = new System.Drawing.Point(1344, 472);
            this.dgvBasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBasket.Name = "dgvBasket";
            this.dgvBasket.ReadOnly = true;
            this.dgvBasket.RowHeadersWidth = 62;
            this.dgvBasket.RowTemplate.Height = 25;
            this.dgvBasket.Size = new System.Drawing.Size(394, 333);
            this.dgvBasket.TabIndex = 14;
            // 
            // dgvStops
            // 
            this.dgvStops.AllowUserToAddRows = false;
            this.dgvStops.AllowUserToDeleteRows = false;
            this.dgvStops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStops.Location = new System.Drawing.Point(1344, 159);
            this.dgvStops.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStops.Name = "dgvStops";
            this.dgvStops.ReadOnly = true;
            this.dgvStops.RowHeadersWidth = 62;
            this.dgvStops.RowTemplate.Height = 25;
            this.dgvStops.Size = new System.Drawing.Size(394, 250);
            this.dgvStops.TabIndex = 15;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 953);
            this.Controls.Add(this.dgvStops);
            this.Controls.Add(this.dgvBasket);
            this.Controls.Add(this.chFirstClass);
            this.Controls.Add(this.chbInternational);
            this.Controls.Add(this.lbStops);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button seat24;
        private System.Windows.Forms.Button seat16;
        private System.Windows.Forms.Button seat23;
        private System.Windows.Forms.Button seat15;
        private System.Windows.Forms.Button seat20;
        private System.Windows.Forms.Button seat12;
        private System.Windows.Forms.Button seat22;
        private System.Windows.Forms.Button seat14;
        private System.Windows.Forms.Button seat19;
        private System.Windows.Forms.Button seat11;
        private System.Windows.Forms.Button seat8;
        private System.Windows.Forms.Button seat18;
        private System.Windows.Forms.Button seat10;
        private System.Windows.Forms.Button seat21;
        private System.Windows.Forms.Button seat13;
        private System.Windows.Forms.Button seat4;
        private System.Windows.Forms.Button seat7;
        private System.Windows.Forms.Button seat17;
        private System.Windows.Forms.Button seat9;
        private System.Windows.Forms.Button seat6;
        private System.Windows.Forms.Button seat3;
        private System.Windows.Forms.Button seat5;
        private System.Windows.Forms.Button seat2;
        private System.Windows.Forms.Button seat1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbInternational;
        private System.Windows.Forms.CheckBox chFirstClass;
        private System.Windows.Forms.Label lbStops;
        private System.Windows.Forms.DataGridView dgvBasket;
        private System.Windows.Forms.DataGridView dgvStops;
    }
}
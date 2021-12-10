
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
            this.btnMyTickets = new System.Windows.Forms.Button();
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
            this.lvBasket = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.chbInternational = new System.Windows.Forms.CheckBox();
            this.chFirstClass = new System.Windows.Forms.CheckBox();
            this.lbStops = new System.Windows.Forms.Label();
            this.lvStops = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(47, 34);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfoClick);
            // 
            // btnMyTickets
            // 
            this.btnMyTickets.Location = new System.Drawing.Point(556, 34);
            this.btnMyTickets.Name = "btnMyTickets";
            this.btnMyTickets.Size = new System.Drawing.Size(75, 23);
            this.btnMyTickets.TabIndex = 1;
            this.btnMyTickets.Text = "My tickets";
            this.btnMyTickets.UseVisualStyleBackColor = true;
            this.btnMyTickets.Click += new System.EventHandler(this.btnMyTickets_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1142, 34);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(167, 118);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(180, 23);
            this.cmbFrom.TabIndex = 3;
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(488, 118);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(186, 23);
            this.cmbTo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
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
            this.panel1.Location = new System.Drawing.Point(47, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 439);
            this.panel1.TabIndex = 7;
            // 
            // seat24
            // 
            this.seat24.Location = new System.Drawing.Point(721, 295);
            this.seat24.Name = "seat24";
            this.seat24.Size = new System.Drawing.Size(58, 46);
            this.seat24.TabIndex = 1;
            this.seat24.Text = "Num";
            this.seat24.UseVisualStyleBackColor = true;
            // 
            // seat16
            // 
            this.seat16.Location = new System.Drawing.Point(721, 94);
            this.seat16.Name = "seat16";
            this.seat16.Size = new System.Drawing.Size(58, 46);
            this.seat16.TabIndex = 1;
            this.seat16.Text = "Num";
            this.seat16.UseVisualStyleBackColor = true;
            // 
            // seat23
            // 
            this.seat23.Location = new System.Drawing.Point(632, 295);
            this.seat23.Name = "seat23";
            this.seat23.Size = new System.Drawing.Size(58, 46);
            this.seat23.TabIndex = 0;
            this.seat23.Text = "Num";
            this.seat23.UseVisualStyleBackColor = true;
            // 
            // seat15
            // 
            this.seat15.Location = new System.Drawing.Point(632, 94);
            this.seat15.Name = "seat15";
            this.seat15.Size = new System.Drawing.Size(58, 46);
            this.seat15.TabIndex = 0;
            this.seat15.Text = "Num";
            this.seat15.UseVisualStyleBackColor = true;
            // 
            // seat20
            // 
            this.seat20.Location = new System.Drawing.Point(330, 295);
            this.seat20.Name = "seat20";
            this.seat20.Size = new System.Drawing.Size(58, 46);
            this.seat20.TabIndex = 1;
            this.seat20.Text = "Num";
            this.seat20.UseVisualStyleBackColor = true;
            // 
            // seat12
            // 
            this.seat12.Location = new System.Drawing.Point(330, 94);
            this.seat12.Name = "seat12";
            this.seat12.Size = new System.Drawing.Size(58, 46);
            this.seat12.TabIndex = 1;
            this.seat12.Text = "Num";
            this.seat12.UseVisualStyleBackColor = true;
            // 
            // seat22
            // 
            this.seat22.Location = new System.Drawing.Point(530, 295);
            this.seat22.Name = "seat22";
            this.seat22.Size = new System.Drawing.Size(58, 46);
            this.seat22.TabIndex = 1;
            this.seat22.Text = "Num";
            this.seat22.UseVisualStyleBackColor = true;
            // 
            // seat14
            // 
            this.seat14.Location = new System.Drawing.Point(530, 94);
            this.seat14.Name = "seat14";
            this.seat14.Size = new System.Drawing.Size(58, 46);
            this.seat14.TabIndex = 1;
            this.seat14.Text = "Num";
            this.seat14.UseVisualStyleBackColor = true;
            // 
            // seat19
            // 
            this.seat19.Location = new System.Drawing.Point(241, 295);
            this.seat19.Name = "seat19";
            this.seat19.Size = new System.Drawing.Size(58, 46);
            this.seat19.TabIndex = 0;
            this.seat19.Text = "Num";
            this.seat19.UseVisualStyleBackColor = true;
            // 
            // seat11
            // 
            this.seat11.Location = new System.Drawing.Point(241, 94);
            this.seat11.Name = "seat11";
            this.seat11.Size = new System.Drawing.Size(58, 46);
            this.seat11.TabIndex = 0;
            this.seat11.Text = "Num";
            this.seat11.UseVisualStyleBackColor = true;
            // 
            // seat8
            // 
            this.seat8.Location = new System.Drawing.Point(721, 26);
            this.seat8.Name = "seat8";
            this.seat8.Size = new System.Drawing.Size(58, 46);
            this.seat8.TabIndex = 1;
            this.seat8.Text = "Num";
            this.seat8.UseVisualStyleBackColor = true;
            // 
            // seat18
            // 
            this.seat18.Location = new System.Drawing.Point(139, 295);
            this.seat18.Name = "seat18";
            this.seat18.Size = new System.Drawing.Size(58, 46);
            this.seat18.TabIndex = 1;
            this.seat18.Text = "Num";
            this.seat18.UseVisualStyleBackColor = true;
            // 
            // seat10
            // 
            this.seat10.Location = new System.Drawing.Point(139, 94);
            this.seat10.Name = "seat10";
            this.seat10.Size = new System.Drawing.Size(58, 46);
            this.seat10.TabIndex = 1;
            this.seat10.Text = "Num";
            this.seat10.UseVisualStyleBackColor = true;
            // 
            // seat21
            // 
            this.seat21.Location = new System.Drawing.Point(441, 295);
            this.seat21.Name = "seat21";
            this.seat21.Size = new System.Drawing.Size(58, 46);
            this.seat21.TabIndex = 0;
            this.seat21.Text = "Num";
            this.seat21.UseVisualStyleBackColor = true;
            // 
            // seat13
            // 
            this.seat13.Location = new System.Drawing.Point(441, 94);
            this.seat13.Name = "seat13";
            this.seat13.Size = new System.Drawing.Size(58, 46);
            this.seat13.TabIndex = 0;
            this.seat13.Text = "Num";
            this.seat13.UseVisualStyleBackColor = true;
            // 
            // seat4
            // 
            this.seat4.Location = new System.Drawing.Point(330, 26);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(58, 46);
            this.seat4.TabIndex = 1;
            this.seat4.Text = "Num";
            this.seat4.UseVisualStyleBackColor = true;
            // 
            // seat7
            // 
            this.seat7.Location = new System.Drawing.Point(632, 26);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(58, 46);
            this.seat7.TabIndex = 0;
            this.seat7.Text = "Num";
            this.seat7.UseVisualStyleBackColor = true;
            // 
            // seat17
            // 
            this.seat17.Location = new System.Drawing.Point(50, 295);
            this.seat17.Name = "seat17";
            this.seat17.Size = new System.Drawing.Size(58, 46);
            this.seat17.TabIndex = 0;
            this.seat17.Text = "Num";
            this.seat17.UseVisualStyleBackColor = true;
            // 
            // seat9
            // 
            this.seat9.Location = new System.Drawing.Point(50, 94);
            this.seat9.Name = "seat9";
            this.seat9.Size = new System.Drawing.Size(58, 46);
            this.seat9.TabIndex = 0;
            this.seat9.Text = "Num";
            this.seat9.UseVisualStyleBackColor = true;
            // 
            // seat6
            // 
            this.seat6.Location = new System.Drawing.Point(530, 26);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(58, 46);
            this.seat6.TabIndex = 1;
            this.seat6.Text = "Num";
            this.seat6.UseVisualStyleBackColor = true;
            // 
            // seat3
            // 
            this.seat3.Location = new System.Drawing.Point(241, 26);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(58, 46);
            this.seat3.TabIndex = 0;
            this.seat3.Text = "Num";
            this.seat3.UseVisualStyleBackColor = true;
            // 
            // seat5
            // 
            this.seat5.Location = new System.Drawing.Point(441, 26);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(58, 46);
            this.seat5.TabIndex = 0;
            this.seat5.Text = "Num";
            this.seat5.UseVisualStyleBackColor = true;
            // 
            // seat2
            // 
            this.seat2.Location = new System.Drawing.Point(139, 26);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(58, 46);
            this.seat2.TabIndex = 1;
            this.seat2.Text = "Num";
            this.seat2.UseVisualStyleBackColor = true;
            // 
            // seat1
            // 
            this.seat1.Location = new System.Drawing.Point(50, 26);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(58, 46);
            this.seat1.TabIndex = 0;
            this.seat1.Text = "Num";
            this.seat1.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(1017, 572);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(128, 56);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Pay Now";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lvBasket
            // 
            this.lvBasket.HideSelection = false;
            this.lvBasket.Location = new System.Drawing.Point(941, 360);
            this.lvBasket.Name = "lvBasket";
            this.lvBasket.Size = new System.Drawing.Size(276, 185);
            this.lvBasket.TabIndex = 9;
            this.lvBasket.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(941, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Basket";
            // 
            // chbInternational
            // 
            this.chbInternational.AutoSize = true;
            this.chbInternational.Location = new System.Drawing.Point(736, 122);
            this.chbInternational.Name = "chbInternational";
            this.chbInternational.Size = new System.Drawing.Size(93, 19);
            this.chbInternational.TabIndex = 12;
            this.chbInternational.Text = "International";
            this.chbInternational.UseVisualStyleBackColor = true;
            this.chbInternational.CheckedChanged += new System.EventHandler(this.chbInternational_CheckedChanged);
            // 
            // chFirstClass
            // 
            this.chFirstClass.AutoSize = true;
            this.chFirstClass.Location = new System.Drawing.Point(887, 120);
            this.chFirstClass.Name = "chFirstClass";
            this.chFirstClass.Size = new System.Drawing.Size(71, 19);
            this.chFirstClass.TabIndex = 13;
            this.chFirstClass.Text = "1st Class";
            this.chFirstClass.UseVisualStyleBackColor = true;
            this.chFirstClass.CheckedChanged += new System.EventHandler(this.chFirstClass_CheckedChanged);
            // 
            // lbStops
            // 
            this.lbStops.AutoSize = true;
            this.lbStops.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStops.Location = new System.Drawing.Point(941, 189);
            this.lbStops.Name = "lbStops";
            this.lbStops.Size = new System.Drawing.Size(53, 17);
            this.lbStops.TabIndex = 10;
            this.lbStops.Text = "Stops";
            // 
            // lvStops
            // 
            this.lvStops.HideSelection = false;
            this.lvStops.Location = new System.Drawing.Point(941, 215);
            this.lvStops.Name = "lvStops";
            this.lvStops.Size = new System.Drawing.Size(276, 102);
            this.lvStops.TabIndex = 9;
            this.lvStops.UseCompatibleStateImageBehavior = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 698);
            this.Controls.Add(this.chFirstClass);
            this.Controls.Add(this.chbInternational);
            this.Controls.Add(this.lbStops);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvStops);
            this.Controls.Add(this.lvBasket);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMyTickets);
            this.Controls.Add(this.btnInfo);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMyTickets;
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
        private System.Windows.Forms.ListView lvBasket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbInternational;
        private System.Windows.Forms.CheckBox chFirstClass;
        private System.Windows.Forms.Label lbStops;
        private System.Windows.Forms.ListView lvStops;
    }
}
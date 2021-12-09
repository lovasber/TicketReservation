using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketReservation
{
    public partial class Home : Form
    {
        List<Ticket> basket = new List<Ticket>();
        List<Button> ticketButtons = new List<Button>();
        bool isFirstClass = false;
        bool isInternational = false;

        Database db = new Database();
        SQLiteDataAdapter sda = new SQLiteDataAdapter();
        SQLiteCommand cmd = new SQLiteCommand();

        
        public Home()
        {
            InitializeComponent();
           
            initButtons();
            initDropDowns();
        }

        private void exitOnClose(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Call method to save file...
            }
            
        }

        private void initDropDowns()
        {
            loadPaths(0);
        }

        private void initButtons()
        {
            this.ticketButtons.Add(this.seat1);
            this.ticketButtons.Add(this.seat2);
            this.ticketButtons.Add(this.seat3);
            this.ticketButtons.Add(this.seat4);
            this.ticketButtons.Add(this.seat5);
            this.ticketButtons.Add(this.seat6);
            this.ticketButtons.Add(this.seat7);
            this.ticketButtons.Add(this.seat8);
            this.ticketButtons.Add(this.seat9);
            this.ticketButtons.Add(this.seat10);
            this.ticketButtons.Add(this.seat11);
            this.ticketButtons.Add(this.seat12);
            this.ticketButtons.Add(this.seat13);
            this.ticketButtons.Add(this.seat14);
            this.ticketButtons.Add(this.seat15);
            this.ticketButtons.Add(this.seat16);
            this.ticketButtons.Add(this.seat17);
            this.ticketButtons.Add(this.seat18);
            this.ticketButtons.Add(this.seat19);
            this.ticketButtons.Add(this.seat20);
            this.ticketButtons.Add(this.seat21);
            this.ticketButtons.Add(this.seat22);
            this.ticketButtons.Add(this.seat23);
            this.ticketButtons.Add(this.seat24);

            setButtons();
        }

        private void loadPaths(int isInternational)
        {
            loadFrom(isInternational);
            loadTo(isInternational);
            this.cmbTo.SelectedIndex = 0;
            this.cmbFrom.SelectedIndex = 0;
            this.cmbFrom.SelectedIndexChanged += cmbFrom_SelectedIndexChanged;
            this.cmbTo.SelectedIndexChanged += cmbTo_SelectedIndexChanged;
        }

        private void loadTo(int isInternational)
        {
            DataTable dt = new DataTable();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Destination FROM Path WHERE Is_international ='" + isInternational.ToString() +"'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);
            
            for (int destIndex = 0; destIndex < dt.Rows.Count; destIndex++)
            {
                this.cmbTo.Items.Add(dt.Rows[destIndex][0].ToString());
            }
            db.closeconnection();

        }

        private void loadFrom(int isInternational)
        {
            DataTable dt = new DataTable();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Leaving_from FROM Path WHERE Is_international ='" + isInternational.ToString() + "'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);

            for (int fromIndex = 0; fromIndex < dt.Rows.Count; fromIndex++)
            {
                this.cmbFrom.Items.Add(dt.Rows[fromIndex][0].ToString());
            }
            db.closeconnection();

        }

        private void setButtons()
        {
            int index = 1;
            foreach(Button btn in this.ticketButtons) //Later I shoud iterate through the database's seats for this route
            {
                btn.Click += seatClick;
                btn.Text = index+"";
                

                index++;
            }
            setButtonColor();
        }

        private void setButtonColor()
        {
            foreach (Button btn in this.ticketButtons) 
            {
                if (this.isFirstClass)
                {
                    btn.BackColor = Color.AliceBlue;
                }
                else
                {
                    btn.BackColor = Color.Honeydew;
                }
            }

        }

        private void addToBasket()
        {
            this.lvBasket.Items.Clear();
            for (int i = 0; i < this.basket.Count; i++)
            {
                this.lvBasket.Items.Add(this.basket[i].ToString());
            }

            this.lvBasket.Refresh();
            
        }

        private void seatClick(object sender, EventArgs e)
        {
            string[] progresses = new string[] { "Free", "In basket", "Taken" };
            int price = calcPrice();
            
            string seatNumber = (sender as Button).Text;
            int clazz = this.isFirstClass ? 1 : 2;
            string from = this.cmbFrom.SelectedItem.ToString();
            string to = this.cmbTo.SelectedItem.ToString();

            this.basket.Add(new Ticket(from, to, clazz, Int32.Parse(seatNumber), progresses[1], price, this.isInternational, getPathId(from, to)));
            //Ticket(string from, string to, int clazz, int seatNumber, string progress, int price, bool isInternational, int pathId)
            addToBasket();

            //this.basket.Add(new Ticket());
            //TODO
            //If a seat is not taken
            //If a seat is out of distance
            //
        }

        private int calcPrice()
        {
            int price = 0;
            if (!this.isInternational)
            {
                if (this.isFirstClass)
                {
                    price = 2500;
                }
                else
                {
                    price = 1750;
                }
            }
            else
            {
                if (this.isFirstClass)
                {
                    price = 10000;
                }
                else
                {
                    price = 7500;
                }
            }
            return price;
        }

        private int getPathId(string from, string to)
        {
            DataTable dt = new DataTable();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Id FROM Path WHERE Leaving_from='"+from+"' AND Destination ='" + to + "'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);
            int id = Int32.Parse(dt.Rows[0][0].ToString());
            db.closeconnection();

            return id;
        }

        private void btnInfoClick(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Lovas Bertalan - SZGVJV");
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            //OPEN MY TICKETS PAGE
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //OPEN PAYMENT PAGE
        }

        private void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            db.openconnection();

            SQLiteCommand cmd = new SQLiteCommand(
                "SELECT Destination " +
                "FROM Path " +
                "WHERE " +
                "Leaving_from='"+this.cmbFrom.SelectedItem.ToString()+"' " +
                "AND Is_international='"+ (this.isInternational ? "1" : "0") + "'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);

            this.cmbTo.SelectedItem = dt.Rows[0][0].ToString();
            db.closeconnection();
            //this.cmbFrom.SelectedIndexChanged += cmbFrom_SelectedIndexChanged;
        }

        private void cmbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            db.openconnection();

            SQLiteCommand cmd = new SQLiteCommand("" +
                "SELECT Leaving_from " +
                "FROM Path " +
                "WHERE " +
                "Destination='" + this.cmbTo.SelectedItem.ToString() + "' " +
                "AND Is_international='" + (this.isInternational ? "1" : "0") + "'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);

            this.cmbFrom.SelectedItem = dt.Rows[0][0].ToString();
            db.closeconnection();
        }

        private void chbInternational_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbFrom.Items.Clear();
            this.cmbTo.Items.Clear();
            this.isInternational = this.chbInternational.Checked;
            loadPaths(this.chbInternational.Checked ? 1 : 0);
        }

        private void chFirstClass_CheckedChanged(object sender, EventArgs e)
        {
            this.isFirstClass = this.chFirstClass.Checked;
            setButtonColor();
        }
    }
}

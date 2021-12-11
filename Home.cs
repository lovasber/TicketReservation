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
    partial class Home : Form
    {
        List<Ticket> basket = new List<Ticket>();
        List<Ticket> takenTickets = new List<Ticket>();
        List<Button> ticketButtons = new List<Button>();
        bool isFirstClass = false;
        bool isInternational = false;
        private string userName = "";
        private Color COLOR_DISABLED = Color.DimGray;

        Database db = new Database();
        SQLiteDataAdapter sda = new SQLiteDataAdapter();
        
        public Home(string userName)
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(formClosed);
            initButtons();
            initTakenTickets();
            initDropDowns();
            loadSopsVisible(false);
            initDataGridView();
            initUser(userName);
            setButtonActive();
        }

        private void initUser(string userName)
        {
            this.userName = userName;
            if (!isAdmin(userName))
            {
                this.btnOrders.Visible = false;
            }
        }

        private bool isAdmin(string userName)
        {
            bool isAdmin = false;

            DataTable dt = new DataTable();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Is_Admin FROM User WHERE Name='" + userName + "'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);

            isAdmin = (Int32.Parse(dt.Rows[0][0].ToString()) == 1) ? true : false;
            db.closeconnection();

            return isAdmin;
        }

        private void initDataGridView()
        {
            this.dgvBasket.UserDeletingRow += DgvBasket_UserDeletingRow1; ;

            this.dgvBasket.Columns.Add("from","From");
            this.dgvBasket.Columns.Add("to","To");
            this.dgvBasket.Columns.Add("seatNumber","Seat Number");
            this.dgvBasket.Columns.Add("price","Price");

            this.dgvStops.Columns.Add("path", "Path");
        }

        private void DgvBasket_UserDeletingRow1(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = this.dgvBasket.CurrentRow.Index;
            this.basket.RemoveAt(index);
            setButtonActive();
        }

        private static void formClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loadSopsVisible(bool isInternational)
        {
            this.lbStops.Visible = isInternational;
            this.dgvStops.Visible = isInternational;
            if (isInternational)
            {
                string from = cmbFrom.SelectedItem.ToString();
                string to = cmbTo.SelectedItem.ToString();
                DataTable dt = new DataTable();
                db.openconnection();
                SQLiteCommand cmd = new SQLiteCommand("SELECT Stops FROM Path WHERE Leaving_from='" + from + "' AND Destination ='" + to + "'", db.GetConnection());
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(dt);
                string[] stops = getStopsFromData(dt.Rows[0][0].ToString());
                db.closeconnection();

                loadStops(stops);
            }
        }

        private void loadStops(string[] stops)
        {
            this.dgvStops.Rows.Clear();
            for (int i = 0; i < stops.Length; i++)
            {
                //var index = this.dgvBasket.Rows.Add();
                //this.dgvBasket.Rows[index].Cells["path"].Value = this.basket[i].from;
                var index = this.dgvStops.Rows.Add();
                this.dgvStops.Rows[index].Cells["path"].Value = stops[i];
                
            }

            this.dgvStops.Refresh();
            /*
            //--------------
            this.dgvStops.Rows.Clear();
            foreach(string stop in stops)
            {
                var index = this.dgvBasket.Rows.Add();
                this.dgvStops.Rows[index].Cells["path"].Value = stop;
            }
            */
        }

        private string[] getStopsFromData(string data)
        {
            string [] stops = data.Split(",");
            return stops;
        }

        private void initTakenTickets()
        {
            DataTable dt = new DataTable();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Ticket, Path WHERE Ticket.Path_Id = Path.Id", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);
            
            for (int fromIndex = 0; fromIndex < dt.Rows.Count; fromIndex++)
            {
                int id = Int32.Parse(dt.Rows[fromIndex][0].ToString());
                int clazz = Int32.Parse(dt.Rows[fromIndex][1].ToString());
                int seatNumber = Int32.Parse(dt.Rows[fromIndex][2].ToString());
                string progress = dt.Rows[fromIndex][3].ToString();
                int price = Int32.Parse(dt.Rows[fromIndex][4].ToString());
                bool isInter = (Int32.Parse(dt.Rows[fromIndex][5].ToString()) == 1)? true : false;
                int pathId = Int32.Parse(dt.Rows[fromIndex][6].ToString());

                string from = dt.Rows[fromIndex][10].ToString();
                string to = dt.Rows[fromIndex][11].ToString();

                this.takenTickets.Add(new Ticket(id, from, to, clazz, seatNumber, progress, price, isInter, pathId));
            }
            db.closeconnection();
            
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
            foreach(Button btn in this.ticketButtons)
            {
                btn.Click += seatClick;
                btn.Text = index+"";
                

                index++;
            }
            setButtonColor();
            
        }

        private void setButtonActive()
        {

            for (int allBtnIndex = 0; allBtnIndex < this.ticketButtons.Count; allBtnIndex++)
            {
                this.ticketButtons[allBtnIndex].Enabled = true;

                if (this.ticketButtons[allBtnIndex].BackColor == COLOR_DISABLED)
                {
                    this.ticketButtons[allBtnIndex].Click += seatClick;
                }
                

                int clazz = this.isFirstClass ? 1 : 2;
                string from = this.cmbFrom.SelectedItem.ToString();
                string to = this.cmbTo.SelectedItem.ToString();
                bool isInter = this.isInternational;

                for (int basketIndex = 0; basketIndex < this.basket.Count; basketIndex++)
                {
                    Ticket ticket = this.basket[basketIndex];
                    if (
                        ticket.seatNumber == (allBtnIndex + 1) && 
                        (ticket.isInternational == isInter) &&
                        clazz == ticket.clazz &&
                        ticket.from.Equals(from) &&
                        ticket.to.Equals(to)
                        )
                    {
                        // this.ticketButtons[allBtnIndex].Enabled = false;
                        this.ticketButtons[allBtnIndex].BackColor = COLOR_DISABLED;
                        this.ticketButtons[allBtnIndex].Click -= seatClick;
                       
                    }
                }
                
                for (int takenSeatIndex = 0; takenSeatIndex < this.takenTickets.Count; takenSeatIndex++)
                {
                    Ticket ticket = this.takenTickets[takenSeatIndex];
                    if (
                        ticket.seatNumber == (allBtnIndex + 1) &&
                        (ticket.isInternational == isInter) &&
                        ticket.clazz == clazz &&
                        ticket.from.Equals(from) &&
                        ticket.to.Equals(to)
                        )
                    {
                        this.ticketButtons[allBtnIndex].Enabled = false;
                        //this.ticketButtons[allBtnIndex]. = false;
                        
                        //this.ticketButtons[allBtnIndex].Click -= seatClick;
                    }
                }
                
               
            }
        }

        private void setButtonColor()
        {
            foreach (Button btn in this.ticketButtons) 
            {
                btn.EnabledChanged += Btn_EnabledChanged;

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

        private void Btn_EnabledChanged(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(!btn.Enabled)
            {
                btn.BackColor = COLOR_DISABLED;
            }
            else
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
            this.dgvBasket.Rows.Clear();
            for (int i = 0; i < this.basket.Count; i++)
            {
                var index = this.dgvBasket.Rows.Add();
                this.dgvBasket.Rows[index].Cells["from"].Value = this.basket[i].from;
                this.dgvBasket.Rows[index].Cells["to"].Value = this.basket[i].to;
                this.dgvBasket.Rows[index].Cells["seatNumber"].Value = this.basket[i].seatNumber;
                this.dgvBasket.Rows[index].Cells["price"].Value = this.basket[i].price;
            }

            this.dgvBasket.Refresh();
        }

        private bool isNeighborSeatFree(int index)
        {
            int maxSize = this.ticketButtons.Count;
            bool isFree = true;

            //UPPER 
            if (0 <= index - 8)
            {
                isFree = ticketButtons[index-8].Enabled;
                if (!isFree)
                {
                    return false;
                }
            }
            //BOTTOM 
            if(index + 8 < maxSize)
            {
                isFree = ticketButtons[index + 8].Enabled;
                if (!isFree)
                {
                    return false;
                }
            }
            //LEFT
            if (0 <= index -1)
            {
                isFree = ticketButtons[index - 1].Enabled;
                if (!isFree)
                {
                    return false;
                }
            }
            //RIGHT
            if (index +1 < maxSize)
            {
                isFree = ticketButtons[index +1 ].Enabled;
                if (!isFree)
                {
                    return false;
                }
            }
            
            return isFree;
        }

        private void seatClick(object sender, EventArgs e)
        {
            string seatNumber = (sender as Button).Text;
            int seatNumberInt = Int32.Parse(seatNumber);
            if (isNeighborSeatFree(seatNumberInt - 1))
            {
                setButtonActive();
                string[] progresses = new string[] { "Free", "In basket", "Taken" };
                int price = calcPrice();

                int clazz = this.isFirstClass ? 1 : 2;
                string from = this.cmbFrom.SelectedItem.ToString();
                string to = this.cmbTo.SelectedItem.ToString();

                this.basket.Add(new Ticket(from, to, clazz, Int32.Parse(seatNumber), progresses[1], price, this.isInternational, getPathId(from, to)));
                addToBasket();
                //(sender as Button).Enabled = false;
                (sender as Button).Click -= seatClick;
                (sender as Button).BackColor = Color.DimGray;
            }
            else
            {
                MessageBox.Show("Due to Covid you can not take this seat.");
            }
            
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
            new Orders().Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            new Payment(this.basket, this.userName).Show();
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
            loadSopsVisible(this.isInternational);
            setButtonColor();
            setButtonActive();
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
            loadSopsVisible(this.isInternational);
            setButtonActive();
            setButtonColor();
        }

        private void chbInternational_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbFrom.Items.Clear();
            this.cmbTo.Items.Clear();
            this.isInternational = this.chbInternational.Checked;
            loadPaths(this.chbInternational.Checked ? 1 : 0);
            loadSopsVisible(this.isInternational);
            setButtonActive();
            setButtonColor();
        }

        private void chFirstClass_CheckedChanged(object sender, EventArgs e)
        {
            this.isFirstClass = this.chFirstClass.Checked;
            setButtonColor();
            setButtonActive();

        }
    }
}

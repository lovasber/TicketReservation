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
    partial class Payment : Form
    {
        Database db = new Database();
        SQLiteDataAdapter sda = new SQLiteDataAdapter();
        SQLiteCommand cmd = new SQLiteCommand();

        private List<Ticket> basket = new List<Ticket>();
        private int price = 0;
        private string userName = "";

        public Payment(List<Ticket> basket, string userName)
        {
            InitializeComponent();
            initBasket(basket);
            
            initPrice();
            loadBasket();
            initUserName(userName);
        }

        private void initUserName(string userName)
        {
            this.userName = userName;
        }

        private int calcPrice()
        {
            int sum = 0;
            foreach (Ticket ticket in this.basket)
            {
                sum += ticket.price;
            }
            return sum;
        } 

        private void initPrice()
        {
            this.price = calcPrice();
            this.lbTotalValue.Text = this.price + " Ft";
        }

        private void initBasket(List<Ticket> basket)
        {
            this.basket = basket;

            this.dgvBasket.UserDeletingRow += DgvBasket_UserDeletingRow1; ;
            this.dgvBasket.Columns.Add("from", "From");
            this.dgvBasket.Columns.Add("to", "To");
            this.dgvBasket.Columns.Add("seatNumber", "Seat Number");
            this.dgvBasket.Columns.Add("price", "Price");
            loadBasket();
            this.dgvBasket.Refresh();

        }

        private void loadBasket()
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

        private void DgvBasket_UserDeletingRow1(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = this.dgvBasket.CurrentRow.Index;
            this.basket.RemoveAt(index);
            initPrice();
        }

        private void btnCupon_Click(object sender, EventArgs e)
        {
            string cuponCode = this.tbCupon.Text;
            int cuponValue = getCuponValue(cuponCode);
            if (cuponValue != 0)
            {
                MessageBox.Show("Cupon code accepted!");
                setCuponPrice(cuponValue);
            }
            else
            {
                MessageBox.Show("No Code found.");
            }
        }

        private int getCuponValue(string cuponCode)
        {
            DataTable dt = new DataTable();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Value FROM Cupon WHERE Code='" + cuponCode + "'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);
            int value = 0;
            try
            {
                value = Int32.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            db.closeconnection();

            return value;
        }

        private void setCuponPrice(int cuponValue)
        {
            this.price = calcPrice();
            int newPrice = (int)(this.price * ((100 - (double)(cuponValue)) / 100));
            this.price = newPrice;
            this.lbTotalValue.Text = newPrice + " Ft";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(this.basket.Count != 0)
            {
                paymentToDb();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your basket is empty, please add tickets!");
            }
            
        }

        private int getTicketId()
        {
            int id = 0;

            DataTable dt = new DataTable();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT MAX(Id) FROM Ticket", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);

            id = Int32.Parse(dt.Rows[0][0].ToString());
            db.closeconnection();

            return id;
        }

        private void paymentToDb()
        {
            string user_Id = this.userName;
            string cupon_Code = "";
            string cuponCodeInput = this.tbCupon.Text;

            if(getCuponValue(cuponCodeInput) != 0)
            {
                cupon_Code = cuponCodeInput;
            }

            db.openconnection();

            foreach (Ticket ticket in this.basket)
            {
                int clazz = ticket.clazz;
                int seatNumber = ticket.seatNumber;
                int price = ticket.price;
                int isInternational = ticket.isInternational ? 1 : 0;
                string progress = ticket.progress;
                int pathId = ticket.pathId;
                
                cmd = new SQLiteCommand("INSERT INTO Ticket(Class, Seat_Number, Progress, Price, Is_International, Path_Id) " +
                    "VALUES ('"+clazz+"', '"+seatNumber+"', '"+progress+ "', '" + price + "', '" + isInternational+"', '"+pathId+"' )", db.GetConnection());
                cmd.ExecuteNonQuery();

                db.closeconnection();

                int ticket_Id = getTicketId();
                
                db.openconnection();
                cmd = new SQLiteCommand("" +
                "Insert INTO User_Order (User_id, Ticket_id, Cupon_Code, Class, Seat_Number)" +
                " values ('" + user_Id + "', '" + ticket_Id + "', '" + cupon_Code + "', '"+ clazz + "', '" + seatNumber + "')", db.GetConnection());
                cmd.ExecuteNonQuery();
                
            }

            db.closeconnection();
        }
    }
}

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
    public partial class Orders : Form
    {
        Database db = new Database();
        SQLiteDataAdapter sda = new SQLiteDataAdapter();
        SQLiteCommand cmd = new SQLiteCommand();
        DataTable dt = new DataTable();

        int isInternational = 0;
        int clazz = 2;

        public Orders()
        {
            InitializeComponent();
            loadDropDownList();
            loadDataGridView();
            setSum();
        }

        private void setSum()
        {
            string path = comboBox1.SelectedItem.ToString();
            string[] spl = path.Split("-");
            string leaving = spl[0].Trim();
            string destination = spl[1].Trim();
            ///DataTable dt = new DataTable();

            db.openconnection();

            cmd = new SQLiteCommand("SELECT SUM(Ticket.Price) " +
                "FROM User, User_Order, Ticket, Path " +
                                "WHERE User.name = User_Order.User_id " +
                "AND Ticket.Id = User_Order.Ticket_id " +
                "AND Path.Id = Ticket.Path_Id " +
                "AND Path.Leaving_from like '" + leaving + "' " +
                "AND Ticket.Class like '" + this.clazz + "' " +
                "AND Ticket.Is_International like '" + this.isInternational + "' " +
                "AND Path.Destination like '" + destination + "' ;",
                db.GetConnection()
            ) ;
            sda = new SQLiteDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            int sum = 0;
            try
            {
                sum = Int32.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }

            this.lbIncome.Text = sum + " Ft";

            db.closeconnection();
        }

        private void loadDropDownList()
        {
            this.comboBox1.Items.Clear();
            DataTable dt = new DataTable();

            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Leaving_from, Destination FROM Path WHERE Path.Is_International Like '"+this.isInternational+"'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);

            for (int fromIndex = 0; fromIndex < dt.Rows.Count; fromIndex++)
            {
                this.comboBox1.Items.Add(dt.Rows[fromIndex][0].ToString() + " - " + dt.Rows[fromIndex][1].ToString());
            }
            db.closeconnection();
            this.comboBox1.SelectedIndex = 0;
        }

        private void loadDataGridView()
        {
            string path = comboBox1.SelectedItem.ToString();
            string[] spl = path.Split("-");
            string leaving = spl[0].Trim();
            string destination = spl[1].Trim();
            db.openconnection();
            
            cmd = new SQLiteCommand("SELECT User.Name as 'User name', Count(*) as 'Bought tickets ', Ticket.Price, Sum(Ticket.Price) as 'Price in total', User_Order.Cupon_Code as 'Cupon code' " + //username, count(jegy), hova, price, isCupon
                "FROM User, User_Order, Ticket, Path " +
                "WHERE User.name = User_Order.User_id " +
                "AND Ticket.Id = User_Order.Ticket_id " +
                "AND Path.Id = Ticket.Path_Id " +
                "AND Path.Leaving_from like '" + leaving + "' " +
                "AND Ticket.Class like '" + this.clazz + "' " +
                "AND Ticket.Is_International like '" + this.isInternational + "' " +
                "AND Path.Destination like '" + destination + "' " +
                "GROUP BY User.Name, " + 
                "Ticket.Price, " +
                "User_Order.Cupon_Code ;", 
                db.GetConnection()
            );
            sda = new SQLiteDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
            db.closeconnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            loadDataGridView();
            setSum();
        }

        private void chbInternational_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.isInternational = chbInternational.Checked ? 1 : 0;
            loadDataGridView();
            setSum();
            loadDropDownList();
        }

        private void chFirstClass_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.clazz = chFirstClass.Checked ? 1 : 2;
            loadDataGridView();
            setSum();
            loadDropDownList();
        }
    }
}

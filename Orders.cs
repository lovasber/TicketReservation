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

        public Orders()
        {
            InitializeComponent();
            initDropDownList();
            initGridView();
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
                "AND Path.Destination like '" + destination + "';",
                db.GetConnection()
            );
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

        private void initDropDownList()
        {
            DataTable dt = new DataTable();

            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Leaving_from, Destination FROM Path", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);

            for (int fromIndex = 0; fromIndex < dt.Rows.Count; fromIndex++)
            {
                this.comboBox1.Items.Add(dt.Rows[fromIndex][0].ToString() + " - " + dt.Rows[fromIndex][1].ToString());
            }
            db.closeconnection();
            this.comboBox1.SelectedIndex = 0;
        }

        private void initGridView()
        {
            string path = comboBox1.SelectedItem.ToString();
            string[] spl = path.Split("-");
            string leaving = spl[0].Trim();
            string destination = spl[1].Trim();
            db.openconnection();
            
            cmd = new SQLiteCommand("SELECT * " +
                "FROM User, User_Order, Ticket, Path " +
                "WHERE User.name = User_Order.User_id " +
                "AND Ticket.Id = User_Order.Ticket_id " +
                "AND Path.Id = Ticket.Path_Id " +
                "AND Path.Leaving_from like '" + leaving + "' " +
                "AND Path.Destination like '" + destination + "';", 
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
            initGridView();
            setSum();
        }
    }
}

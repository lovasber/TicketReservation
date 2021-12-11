using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservation
{
    public partial class Login : Form
    {

        Database db = new Database();
        SQLiteDataAdapter sda = new SQLiteDataAdapter();
        SQLiteCommand cmd = new SQLiteCommand();

        public Login()
        {
            InitializeComponent();
        }


        private void loginBtnClick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM User WHERE name='"+tbUsername.Text+"' AND Password = '"+ tbPassword.Text +"'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                string userName = this.tbUsername.Text;
                new Home(userName).Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }

            db.closeconnection();
          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }
    }
}

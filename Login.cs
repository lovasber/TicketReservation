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

        private void registerBtnClick(object sender, EventArgs e)
        {
            
            if (tbUsername.Text.Length != 0 && tbPassword.Text.Length != 0)
            {
                if (!alreadyExistingName(tbUsername.Text))
                {
                    db.openconnection();
                    cmd = new SQLiteCommand("Insert INTO User (Name, Password, Is_admin) values ('" + tbUsername.Text + "', '" + tbPassword.Text + "', 0)", db.GetConnection());
                    cmd.ExecuteNonQuery();
                    db.closeconnection();
                    MessageBox.Show("Successful login");
                    //HOME
                }
                else
                {
                    MessageBox.Show("Username already taken!");
                }

            }
            else
            {
                MessageBox.Show("Please fill all the fields!");
            }

        }

        private bool alreadyExistingName(String userName)
        {
            DataTable dt = new DataTable();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM User WHERE Name='" + userName + "'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }

            return false;
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
                new Home().Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }

            db.closeconnection();
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation
{
    class Database
    {
        private SQLiteConnection con = new SQLiteConnection("data source = ticketManagement.db");

        public SQLiteConnection GetConnection()
        {
            return con;
        }

        public void openconnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void closeconnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

    }
}

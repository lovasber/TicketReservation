using System;
using System.Collections.Generic;
using System.Text;

namespace TicketReservation
{
    class Ticket
    {
        private int id { get; set; }
        private int clazz { get; set; }
        private string date { get; set; }
        private int seatNumber { get; set; }
        private string progress { get; set; }
        private int price { get; set; }
        private bool isInternational { get; set; }
        private int pathId { get; set; }

        public Ticket(int id, int clazz, string date, int seatNumber, string progress, int price, bool isInternational, int pathId)
        {
            this.id = id;
            this.clazz = clazz;
            this.date = date;
            this.seatNumber = seatNumber;
            this.progress = progress;
            this.price = price;
            this.isInternational = isInternational;
            this.pathId = pathId;
        }

    }
}

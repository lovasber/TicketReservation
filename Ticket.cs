using System;
using System.Collections.Generic;
using System.Text;

namespace TicketReservation
{
    class Ticket
    {

        public string from { get; set; }
        public string to { get; set; }
        private int clazz { get; set; }
        private int seatNumber { get; set; }
        private string progress { get; set; }
        private int price { get; set; }
        private bool isInternational { get; set; }
        private int pathId { get; set; }


        public Ticket(string from, string to, int clazz, int seatNumber, string progress, int price, bool isInternational, int pathId)
        {
            this.from = from;
            this.to = to;
            this.clazz = clazz;
            this.seatNumber = seatNumber;
            this.progress = progress;
            this.price = price;
            this.isInternational = isInternational;
            this.pathId = pathId;
        }

        public override string ToString()
        {
            return this.from + " - " + this.to + " " + this.clazz + ". class, Seat:" + this.seatNumber + " " + " " + this.price + "FT";
        }
    }
}

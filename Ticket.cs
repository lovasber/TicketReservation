using System;
using System.Collections.Generic;
using System.Text;

namespace TicketReservation
{
    class Ticket
    {

        public int id { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public int clazz { get; set; }
        public int seatNumber { get; set; }
        public string progress { get; set; }
        public int price { get; set; }
        public bool isInternational { get; set; }
        public int pathId { get; set; }

        public Ticket(int id, int clazz, int seatNumber, string progress, int price, bool isInternational, int pathId)
        {
            this.id = id;
            this.clazz = clazz;
            this.seatNumber = seatNumber;
            this.progress = progress;
            this.price = price;
            this.isInternational = isInternational;
            this.pathId = pathId;
        }

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

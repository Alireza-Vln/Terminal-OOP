using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_OOP
{
   public class Trip
    {
        public Trip(string origin, string destination, double ticket,Bus bus)
        {
            Origin = origin;
            Destination = destination;
            TicketPrice = ticket;
            Bus= bus;
           
        }
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double TicketPrice { get; set; }
        public Bus Bus { get; set; }
        public double travelIncome { get; set; }
        public int CancelBuy { get; set; }
        public int CancelBook { get; set; }
        public void SetID(int id)
        {
            Id = id;
        }
    }
}


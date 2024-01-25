using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_OOP
{
    public static class Terminal
    {



        private static List<Bus> buses = new();
        private static List<Trip> triples = new();

        static int BusId = 0;
        static double Total = 0;
        static int TripId = 0;
        public static void Addbus(string name, int type)
        {
            if (type == 1)
            {
                BusId++;

                var bus = new NormalBus(name);
                bus.SetID(BusId);
                bus.SetChair(bus.Capacity);
                buses.Add(bus);
            }
            if (type == 2)
            {
                BusId++;
                var bus = new VipBus(name);
                bus.SetID(BusId);
                bus.SetChair(bus.Capacity);
                buses.Add(bus);
            }
        }

        public static void AddTrip(int type)
        {
            if (type == 1)
            {
                Line();
                var item = buses.Where(_ => _.Type == "Normal");
                foreach (var bus in item)
                {
                    Console.WriteLine($"{bus.Id}=>{bus.Name}--Type={bus.Type}");
                }
                Line();
                int Option = GetInt("choose Option=");
                var check = buses.Find(_ => _.Id == Option);
                if (check == null)
                {
                    throw new Exception();
                }
                else
                {
                    string origin = GetString("set origin");
                    string destination = GetString("set destination");
                    double ticketPrice = GetDouble("set Ticket Price");
                    var trip = new Trip(origin, destination, ticketPrice,check);
                    trip.SetID(TripId);
                    triples.Add(trip);
                }
            }
            if (type == 2)
            {
                Line();
                var item = buses.Where(_ => _.Type == "Vip");
                foreach (var bus in item)
                {
                    Console.WriteLine($"{bus.Id}=>{bus.Name}--Type={bus.Type}");
                }
                Line();
                int Option = GetInt("choose Option=");
                var check = buses.Find(_ => _.Id == Option);
                if (check == null)
                {
                    throw new Exception();
                }
                else
                {

                    string origin = GetString("set origin");
                    string destination = GetString("set destination");
                    double ticketPrice = GetDouble("set Ticket Price");
                    var trip = new Trip(origin, destination, ticketPrice,check);
                    trip.SetID(TripId);
                    triples.Add(trip);
                }
            }
        }



        public static void ShowTrip()
        {
            int i = 1;
            foreach (var trip in triples)
            {
                trip.SetID(i);
                Console.WriteLine($"{trip.Bus.Id}->{trip.Bus.Name}--{trip.Bus.Type} ---{trip.Origin}---{trip.Destination}---{trip.TicketPrice}");
                i++;
            }
            int optin = GetInt("enter your trip");
            {
                var chairs=triples.Where(_ => _.Bus.Id == optin);
                if (chairs == null)
                {
                    throw new Exception();
                }
                else
                {
                    Line();
                    foreach (var chair in chairs)
                    {
                        foreach(var x in chair.Bus.Chair)
                        {
                            Console.WriteLine($"{chair.Bus.Name}--{chair.Bus.Type}--{x.Num}");
                        }
                    }
                    Line();
                }
            }
        }

        public static void BookATicket()
        {
            ShowTrip();

            string ticket = GetString("Enter Your Chair");
          
         

        }
        public static void BuyATicket()
        {
            ShowTrip();

            string ticket = GetString("Enter Your Chair");

            foreach (var buese in triples)
            {
                foreach (var chair in buese.Bus.Chair)
                {
                     if(chair.Num== ticket)
                    {
                        chair.Num = "bb";
                    }

                }
                Total += buese.TicketPrice;
            }   
            
            
            
            
            
            
            
        }

        public static void showTotal()
        {
            Console.WriteLine($"total={Total}");
        }
        
        public static void Line()
        {
            Console.WriteLine("--------------------------------");
        }






        public static int GetInt(string message)
        {
            Console.WriteLine(message);
            int get = int.Parse(Console.ReadLine()!);
            return get;
        }


        public static string GetString(string message)
        {
            Console.WriteLine(message);
            string get = Console.ReadLine()!;
            return get;
        }



        public static double GetDouble(string message)
        {
            Console.WriteLine(message);
            double get = double.Parse(Console.ReadLine()!);
            return get;
        }






    }
}

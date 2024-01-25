using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_OOP
{
    public static class Terminal
    {



        private static List<Bus> buses=new ();
        private static List<Trip> triples=new ();

         static int NormalID = 0;
        static int VipID = 0;
        static  int TripId= 0;
        public static void Addbus(string name, int type)
        {
            if (type == 1)
            {
                NormalID++;

                var bus = new NormalBus(name);
                bus.SetID(NormalID);
                bus.SetChair(bus.Capacity);
                buses.Add(bus);
            }
            if (type == 2)
            {
                VipID++;
                var bus = new VipBus(name);
                bus.SetID(VipID);
                bus.SetChair(bus.Capacity);
                buses.Add(bus);
            }
        }

        public static void AddTrip(int type)
        {
            if(type == 1)
            {
                Line();
                var item=buses.Where(_ => _.Type == "Normal");
                foreach(var bus in item)
                {
                    Console.WriteLine($"{bus.Id}=>{bus.Name}--Type={bus.Type}");
                }
                Line();
                int Option = GetInt("choose Option=");
                var check=buses.Find(_=>_.Id== Option);
                if (check == null)
                {
                    throw new Exception();
                }
                else
                {
                    string origin = GetString("set origin");
                    string destination = GetString("set destination");
                    double ticketPrice = GetDouble("set Ticket Price");
                    var trip=new Trip(origin, destination, ticketPrice,check);
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
            foreach(var trip in triples)
            {

                Console.WriteLine($"{trip.Buses.Name}----{trip.Buses.Type}---{trip.Origin}---{trip.Destination}---{trip.TicketPrice}");



            }
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

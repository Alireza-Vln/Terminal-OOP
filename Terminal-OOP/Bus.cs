using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal_OOP;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Terminal_OOP
{
    public  class Bus
    {
        public Bus(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Chair> Chair { get; set; }
        public int Id { get; set; }
        public void SetChair(int chair)
        {
            Chair = new();
            for (int i = 1; i <= chair; i++)
            {
                Chair.Add(new Chair(i.ToString()));
            }
        }
        public void SetID(int id )
        {           
                Id =id;
        }
    }
    public class NormalBus : Bus
    {
        public NormalBus(string name) : base(name)
        {
            Capacity = 44;
            Type = "Normal";
        }

    }
    public class VipBus : Bus
    {
        public VipBus(string name) : base(name)
        {
            Capacity = 30;
            Type = "Vip";
        }

    }

    public class Chair
    {
        public Chair(string num)
        {
            Num = num;
        }
        public string Num { get; set; }
        public Bus Bus { get; set; }
    }
}


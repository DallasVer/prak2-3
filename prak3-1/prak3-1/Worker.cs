using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace prak3_1
{
    internal class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public double rate { get; set; }
        public int days { get; set; }
    
    public Worker(string nsme, string surname, double rate, int days) 
    {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;

    }
        public void GetSalary()
        {
            Console.WriteLine($"Зарплата выбранного сотрудника составляет {rate * days}" );
        }
  }
}



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzlab004
{
    public class Car
    {
        public string Mark { get; set; }
        public int Price { get; set; }
        public Car() { }
        public Car(string mark, int price)
        {
            Mark = mark; Price = price;
        }
        public override string ToString()
        {
            return "$ Marka " + Mark + " Cena " + Price + "asfasdfasdfasd";
        }
    }    
}

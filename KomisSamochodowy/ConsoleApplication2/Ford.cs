using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Ford:Samochod
    {
        override public string wyswietlMarke()
        {
            return "Ford";
        }
    }
}

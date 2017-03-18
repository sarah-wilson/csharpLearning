using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScribestarEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            MostRecentlyUsedList listy = new MostRecentlyUsedList(4);
            listy.AddOne(4);
            listy.AddOne(2);
            listy.AddOne(12);
            System.Console.WriteLine(listy);



        }
    }
}

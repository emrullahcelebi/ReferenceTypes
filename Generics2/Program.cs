using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
        }
    }

    class MyList<T>
    {
        public void Add(string item)
        {

        }
    }
}

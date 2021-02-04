using System;
using System.Collections.Generic;

namespace DictionaryKavramı
{
    class Program
    {
        //key e uygun olarak değer saklar
        static void Main(string[] args)
        {
            Dictionary<string, int> okulNumarasıAdı = new Dictionary<string, int>();
            okulNumarasıAdı.Add("Ali",123);
            okulNumarasıAdı.Add("Emrah", 456);
            okulNumarasıAdı.Add("Cemil", 789);
            okulNumarasıAdı.Add("Tahir", 102);
            okulNumarasıAdı.Add("Adnan", 216);

            foreach (var veriler in okulNumarasıAdı)
            {
                Console.WriteLine(veriler);

            }

        }
    }
    

}

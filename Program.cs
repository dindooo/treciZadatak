using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaCetvrta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite recenicu");
            string recenica = Console.ReadLine();
            string prva = recenica.Substring(0, recenica.IndexOf(" "));
            string zadnja = recenica.Substring(recenica.LastIndexOf(" ", recenica.Length - 1));
            Console.WriteLine(prva + zadnja);
            Console.ReadKey();
        }
    }
}

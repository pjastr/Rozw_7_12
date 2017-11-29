using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rozw_7_12
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("ABC"))
            {
                if (File.Exists("ABC\\bilet.txt"))
                {
                    string tresc = File.ReadAllText("ABC\\bilet.txt");
                    Console.WriteLine("Zawartość pliku:");
                    Console.WriteLine(tresc);
                }
                else
                {
                    Console.WriteLine("brak pliku bilet.txt");
                }
            }
            else
            {
                Console.WriteLine("Nie ma folderu ABC");
            }
            Console.ReadKey();

        }
    }
}

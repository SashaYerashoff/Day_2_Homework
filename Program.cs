using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Voidfcija(); //void funkcijas izsaukums a un b saskaitīšanai

            int retresult = Intreturnfcija(); //retresult mainīga iniciēšana un Inreturnfcija rezultāta piešķiršana mainīgajam
            Console.WriteLine("Return funkcijas rezultāts ir: {0}", retresult); //Intreturnfcija rezultāta izvade ar retresult mainīga palīdzību

            Console.ReadLine(); //Pauze
        }

        static void Voidfcija() //void funkcija a un b saskaitīšanai
        {
            int a, b, c;

            Console.Write("Lūdzu ievadi veselo skaitli a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lūdzu ievadi veselo skaitli b: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("Void funkcijas rezultāts izskatas šādi {0} + {1} = {2}", a, b, c);
            Console.WriteLine(""); // Atstarpe pēc funkcijas darba pabeigšanas
        }

        static int Intreturnfcija() // funkcija, kas izpildes procesā saskaita a un b un atgriež integer
        {
            int a, b, c;

            Console.Write("Lūdzu ievadi veselo skaitli a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lūdzu ievadi veselo skaitli b: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;

            return c;
        }
    }
}

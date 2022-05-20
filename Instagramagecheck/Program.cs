using System;

namespace Instagramagecheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutaja vanust;
            //programm kontrollib, kas kasutaja on vanem kui 13 v6i 13 aastat vana;
            //kui kasutaja on 13 aastat vana v6i vanem, siis ta v6ib Instagram'i kasutada;
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor;

            Console.WriteLine("Palun sisesta oma vanus:");
            int Userage = Convert.ToInt32(Console.ReadLine());

            if (Userage > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }
            else if (Userage < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua.");
            }
            else
            {
                Console.WriteLine("Oledki 13, nyyd saad endale Instagrami kontot luua.");
            }

            Console.WriteLine("Kena p2eva!");
        }
    }
}

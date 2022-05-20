using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //programm kysib kasutaja synniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma synniaasta:");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearofbirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");
        }
    }
}

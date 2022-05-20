using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //program kysib kasutaja vanust;
            //programm arvutab kasutaja synniaastat;
            //programm kuvab synniaastat konsoolis;
            //"oled syndinud aastal {yearofbirth}"

            Console.WriteLine("Palun sisesta oma vanus");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            int yearofbirth = 2022 - UserAge;

            Console.WriteLine($"Oled syndinud aastal {yearofbirth}");
        }
    }
}

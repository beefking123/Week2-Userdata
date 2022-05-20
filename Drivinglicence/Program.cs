using System;

namespace Drivinglicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutaja synniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju 6nne! Nyyd sa saad juhilube taotleda"

            Console.WriteLine("Palun sisesta oma synniaasta:");

            int yearofbirth = Convert.ToInt32(Console.ReadLine());

            int Userage = 2022 - yearofbirth;
            

            if (Userage > 18)
            {
                Console.WriteLine("oled piisavalt vana, et juhilube saada.");
            }
            else if (Userage < 18)
            {
                Console.WriteLine("oled liiga noor, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju 6nne! Nyyd sa saad juhilube taotleda.");
            }

            Console.WriteLine("Oli meeldiv!");



        }
    }
}

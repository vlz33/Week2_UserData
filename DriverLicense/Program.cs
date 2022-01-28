using System;

namespace DriverLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanuse;
            //kui kasutaja on noorem kui 18, siis programm kuvab teate "Oled liiga noor juhilabadeks";
            //kui kasutaja on vanem kui 18, siis programm kuvab teate "Oled piisavalt vana juhilubadeks";
            //kui kasutaja on 18, siis programm kuvab teate "Palju õnne! Võid juhilube taotleda";

            Console.WriteLine("Palun sisesta oma sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2022 - YearOfBirth;

            if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana juhilubadeks");
            }
            else if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor juhilubadeks");
            }

            else
            {
                Console.WriteLine("Palju õnne, võid juhilube taotleda");
            }

            Console.WriteLine("Kena päeva");



        }
    }
}

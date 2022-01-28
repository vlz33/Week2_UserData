using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 või vanem, siis ta võib Instagrami kasutada;
            //kui kasutaja on noorem kui 13, siis ta on liiga noor;

            Console.WriteLine("Palun sisesta oma vanus");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            if (UserAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana Instagrami kasutamiseks");
            }
            else if (UserAge < 13)
            {
                Console.WriteLine("Oled liiga noor Instagrami kasutamiseks");
            }

            else
            {
                Console.WriteLine("Palju õnne, oled piisavalt vana Instagrami kasutamiseks");
            }

            Console.WriteLine("Kena päeva");

        }

    }

}
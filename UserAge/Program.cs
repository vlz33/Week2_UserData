using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //Programm arvutab kasutaja sünniaasta;
            //programm kuvab sünniaasta konsoolis;
            //"oled sündinud aastal {YearOfBirth}";

            Console.WriteLine("Kui vana sa oled?");
            int UserAge = Convert.ToInt32(Console.ReadLine());
            int YearOfBirth = 2022 - UserAge;

            Console.WriteLine($"Oled sündinud aastal {YearOfBirth}");

        }
    }
}

﻿using PudelkoClass.Enums;
using System.Globalization;
using System.Security.Cryptography;
using PudelkoClass;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //dla pudełka o wymiarach kolejno 2.5, 9.321 i 0.1, ToString("mm") zwraca napis "2500 mm × 9321 mm × 100 mm"

                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

                Pudelko abc = new Pudelko(7, 7, 4, UnitOfMeasure.meter);
                Pudelko abc1 = new Pudelko(5, 2, 8, UnitOfMeasure.meter);

                Console.WriteLine(abc + abc1);


                var pudelko = Pudelko.Parse("1 cm x 1 m x 1 mm");
                System.Console.WriteLine(pudelko);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
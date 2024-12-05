using System;
using System.Diagnostics.Tracing;
using static System.Net.Mime.MediaTypeNames;
namespace ExerciceThree
{
    public class ExerciceThree
    {
        public static void Main()
        {
            const string intDateMsg = "Introdueix el dia, mes i any en nombres";

            int day;
            int month;
            int year;
            int totalDaysMonth = 0;

            Console.WriteLine(intDateMsg); 
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());

            while (day < 1 || day > 31)
            {
                Console.WriteLine("Reintrodueix el dia");
                day = Convert.ToInt32(Console.ReadLine());
            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                totalDaysMonth = 31;
            } else
            {
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    totalDaysMonth = 30;
                } else
                {
                    if (month == 2)
                    {
                        if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                        {
                            totalDaysMonth = 29;
                        } else
                        {
                            totalDaysMonth = 28;
                        }
                    }
                }
            }
            if (totalDaysMonth != 0)
            {
                Console.WriteLine("El dia, el mes i l'any es troben dins del rang de data corresponent");
            }
            else
            {
                Console.WriteLine("El dia, el mes i l'any NO es troben dins del rang de data corresponent");
            }
            //POST: retorna si els números (dd, mm, yyyy) estan dins del rang de data corresponent
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1P2
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                DateTime date1, date2;

                int dateDiff, hourDiff, minDiff;



                Console.WriteLine("Enter Start Date");

                date1 = Convert.ToDateTime(Console.ReadLine());



                Console.WriteLine("Enter End Date");

                date2 = Convert.ToDateTime(Console.ReadLine());



                if (date1 < date2)

                {

                    dateDiff = Convert.ToInt32((date2 - date1).TotalDays);

                }

                else

                {

                    dateDiff = Convert.ToInt32((date1 - date2).TotalDays);

                }

                //ensures a positive difference between the dates entered (so chronology isnt needed)



                hourDiff = dateDiff * 24;

                minDiff = hourDiff * 60;

                // converts the difference in days to hours and minutes, respectively



                //Console.WriteLine(date1);

                //Console.WriteLine(date2);

                //Console.WriteLine(dateDiff); tests the user input

                Console.WriteLine("The difference between the dates is " + dateDiff + " Days, or " + hourDiff + " Hours, or " + minDiff + " Minutes.");

                Console.ReadKey();
            }
        }
    }
}

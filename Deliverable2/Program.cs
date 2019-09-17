using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Program
    {

        static void Main(string[] args)
        {
            int value1 = 0;
            int value2 = 0;
            Console.WriteLine(">Hello user, what are you in the mood for?" + "\n" + "Here are your options" + "\n" +
                "   1) Action" + "\n" + "   2) Chilling" + "\n" + "   3) Danger" + "\n" + "   4) Good Food");
            
              try
              {
                  value1 = Convert.ToInt32(Console.ReadLine());

              }
              catch
              {
                  Console.WriteLine("The Input was not understood");
                  Console.ReadLine();
              }





            Console.WriteLine(">How many people are you bringing with you?");
            try
            {
                value2 = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("The Input was not understood");
                Console.ReadLine();
                
            }

            // values for the first question
            if (value1 == 1)
            {
               
                Console.WriteLine("Okay if your in the mood for action then you should go Stock Car Racing");
                

            }
            else if (value1 == 2)
            {

                Console.WriteLine("Okay if your in the mood for chilling then you should go to hiking");

            }
            else if (value1 == 3)
            {

                Console.WriteLine("Okay if your in the mood for danger then you should go to skydiving");
            }
            else if (value1 == 4)
            {

                Console.WriteLine("Okay if your in the mood for good food then you should go to Taco Bell");
            }

            else
            {
                Console.WriteLine("The Input was not understood");
                Console.ReadLine();

            }

            //values of the 2nd question     
            if (value2 == 0)
            {
                string newvalue2 = " sneakers";
                Console.WriteLine("and travel in" + (newvalue2));
            }
            else if (value2 >= 1 && value2 <= 4)
            {
                string newvalue2 = " a sedan";
                Console.WriteLine("and travel in" + (newvalue2));
            }
            else if (value2 >= 5 && value2 <= 10)
            {
                string newvalue2 = " a Volkswagen bus";
                Console.WriteLine("and travel in" + (newvalue2));
            }
            else if (value2 >= 11)
            {
                string newvalue2 = " an airplane";
                Console.WriteLine("and travel in" + (newvalue2));
            }
            else
            {
                Console.WriteLine("The Input was not understood");


            }






            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }
    }
}

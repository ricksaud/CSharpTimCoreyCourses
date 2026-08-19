using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExthensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {


            PersonModel person = new PersonModel();
        



            person.FirstName = "What is your first name: ".RequestString();
            person.LastName = "What is your last name: ".RequestString();
            person.Age = "What is your age: ".RequestInt(0,120);

            Console.ReadLine();
        }

    }

    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";
            
            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;

        }



        public static int RequestInt(this string message, int minValue, int maxValue)
        {
         
            return message.RequestInt(true, minValue, maxValue);
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }


        private static int RequestInt(this string message, bool useMinMax, int minValue =0 , int maxValue=0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isInValidRange = true;

            while (isValidInt == false || isInValidRange == false)
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if(useMinMax == true)
                {

                    isInValidRange = (output >= minValue && output <= maxValue);
                  //  if(output >=minValue && output <= maxValue)
                   // {
                   //     isInValidRange = true;
                  //  } else
                  //  {
                  //      isInValidRange = false;
                  //  }
                }
            }


            return output;

        }

    }


    public class PersonModel {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int NumberOfChildren { get; set; }


    }

}

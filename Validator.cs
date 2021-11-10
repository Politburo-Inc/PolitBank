using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitBank
{
    internal static class Validator
    {
        public static int validate(string userInput, int processedInput, Action encapsulatedFunction)
        {
            try
            {
                processedInput = Convert.ToInt32(userInput);
                return processedInput;
            }
            catch (Exception)
            {

                Console.WriteLine("ERROR: INPUT FAILURE");
                encapsulatedFunction();
                return -1;
            }
        }
    }
}

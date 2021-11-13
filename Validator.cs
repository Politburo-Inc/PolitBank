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

        public static float validateFloat(string userInput, float processedInput, Action encapsulatedFunction)
        {
            try
            {
                processedInput = float.Parse(userInput);
                return processedInput;
            }
            catch (Exception)
            {

                Console.WriteLine("ERROR: INPUT FAILURE");
                encapsulatedFunction();
                return -1f;
            }
        }


        //public static int process(int processedInput, int switchMin, int switchMax, params Action[])
        //{
        //    List<int> switchCount = new List<int>();
        //    for (int i = 0; i < switchMax; i++)
        //    {
        //        switchCount.Add(i);
        //        switch (processedInput)
        //        {
        //            case switchCount[0]:
        //                break;
        //            case switchMax - 1:
        //            default:
        //                break;
        //        }
        //    }
        //}
    }
}

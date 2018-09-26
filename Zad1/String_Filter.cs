using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class String_Filter
    {
        /// <summary>
        /// Method check if string contans any digit
        /// </summary>
        /// <param name="input"> Checked string </param>
        /// <returns> 
        /// Result in boolen form
        /// </returns>
        private bool Check_If_Contains_Digits(string input)
        {
            bool isDigitPresent = input.Any(c => char.IsDigit(c));

            return isDigitPresent;
        }

        /// <summary>
        /// Method check if string is equal to "Date"
        /// </summary>
        /// <param name="input"> Checked string </param>
        /// <returns> Result in boolen form </returns>
        private bool Check_If_Contains_Date(string input)
        {
            bool containDare = input.Equals("Date");

            return containDare;
        }

        /// <summary>
        /// Method check string
        /// </summary>
        /// <param name="input"> Checking string </param>
        /// <returns> Result in Int form </returns>
        private int Check_String(string input)
        {
            if (Check_If_Contains_Date(input))
                return 1;
            if (Check_If_Contains_Digits(input))
                return 2;
            
            return 0;
        }

        public void Display_Results(string input)
        {
            Console.Clear();
            Console.WriteLine();

            switch (Check_String(input))
            {
                case 1:
                    var date = DateTime.Now;
                    Console.WriteLine($"\t<{date}>");
                    break;
                case 2:
                    Console.WriteLine("\tI'm not calculator");
                    break;
                default:
                    Console.WriteLine("\tHi!");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Algorithm_Programs
{
    class FindNumber
    {
        public void Find()
        {
            Console.WriteLine("Enter a limit:");
            double limit = Convert.ToInt32(Console.ReadLine());
            double n = Math.Pow(2, limit);
            Console.WriteLine("Enter a guess between 0 and {0}", n - 1);

        }
        public void Question(int firstValue, int lastValue)
        {
          
            int mid = (firstValue + lastValue) / 2;
            Console.WriteLine("is this  number " + mid + " is grater than your number ?");
            char answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'y')
            {
                Question(mid, lastValue);
            }
            else
            {
                Question(firstValue, mid);
            }
        }
    }
}
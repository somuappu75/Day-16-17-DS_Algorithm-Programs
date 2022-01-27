using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Algorithm_Programs
{
    public class PrimeNumbers
    {
        public void Check_Prime()
        {
            int i = 2;
            Console.WriteLine("Range is 0 to 1000-PrimeNumbers\n");
            while (i < 1000)
            {
                bool count = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count = true;
                        break;
                    }
                }
                if (count == false)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
        }
    }
}

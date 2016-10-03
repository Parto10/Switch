using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int intLength = 3;
            int intLength1 = 3;
            //for (int intIndex = 0; intIndex < intLength; intIndex++)
            //{
            //    for (int intIndex1 = 0; intIndex1 < intLength1; intIndex1++)
            //    {
            //        Console.WriteLine("[" + intIndex1 + "]");
            //        if (intIndex1 == 1)
            //        {
            //            //continue;
            //            break;

            //        }
            //    }
            //}
            for (int intIndex1 = 0; intIndex1 < intLength1; intIndex1++)
            {
                Console.WriteLine("[" + intIndex1 + "]");
                if (intIndex1 == 1)
                {
                    //continue;
                    break;
                    Console.WriteLine("yes");


                }
                Console.WriteLine("yes");
            }
            Console.ReadKey();
        }
    }
}

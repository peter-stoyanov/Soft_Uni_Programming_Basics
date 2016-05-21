using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigFactoriel
{
    class BigFactoriel
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            BigInteger result = 1;


            //loop starts from 1 to <= because the ZERO will fuck it all up!
            for (int i = 1; i <= inputNum; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_Lectures10042016
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime easter = new DateTime(2016,05,01);
            DateTime christmas = new DateTime(2016, 12, 24);

            TimeSpan diff = easter.Subtract(christmas);

            Console.WriteLine("{0:d-MMM-yyyy}", easter);

        }
    }
}

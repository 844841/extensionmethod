using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethod
{
    class Program
    {
        static void Main(String[] args)
        {
            string str = "zing zing amazing";
            int i = str.wordcount();
            Console.WriteLine(i);
        }
    }
   

}

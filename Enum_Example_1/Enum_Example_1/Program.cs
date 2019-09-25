using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Example_1
{
    class Program
    {
        public enum Season { WINTER, SPRING, SUMMER, FALL }
        static void Main(string[] args)
        {
            int x = (int)Season.SPRING;
            int y = (int)Season.FALL;
            Console.WriteLine("WINTER = {0}", x);
            Console.WriteLine("SUMMER = {0}", y);
        }
    }
}

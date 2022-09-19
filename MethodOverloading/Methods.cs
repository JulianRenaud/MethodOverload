using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        } 
        public static string Add(int x, int y, bool z)
        {
            if (z == true)
            {
                if (x + y == 1 || x + y == -1)
                {
                    return $"{x + y} dollar";
                }
                else
                {
                    return $"{x + y} dollars";
                }



            }
            else
            {
                return $"{x + y}";
            }
        }
    }
}

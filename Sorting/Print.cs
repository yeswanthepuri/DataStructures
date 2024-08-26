using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class Print
    {
        public static void WriteList(int[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

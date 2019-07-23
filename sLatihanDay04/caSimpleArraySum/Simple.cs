using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caSimpleArraySum
{
    class Simple
    {
        
            int arCount = Convert.ToInt32(Console.ReadLine());
            int[] ary = new int[arCount];
            int result = 0;
            int ctr = 0;
            //Console.WriteLine(arCount);
            string bebas = Console.ReadLine();
            Console.WriteLine(bebas);
            string[] ar = bebas.Split(' ');

            foreach (var item in ar)
            {
                Console.WriteLine(item);
                ary[ctr] = Convert.ToInt32(item);
                ctr++;
                
            }

            foreach (var item in ary)
            {
                result = result + item;
            }

            Console.ReadLine();
        }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caSimpleArraySum
{
    class Program
    {
       static int simpleArraySum(int[] ar) {

           int hasil = 0;
           for (int i = 0; i <= ar.Length; i++)
           {
               
               hasil = ar[i] + hasil;
           }
        return hasil;

    }

    static void Main(string[] args) {
        Console.Write("Length = ");
        int arCount = int.Parse(Console.ReadLine());

        //int arCount = int.Parse(Console.ReadLine()); // input tanpa text
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

        int result = simpleArraySum(ar);

        Console.WriteLine(result);
  
    }
    }
}

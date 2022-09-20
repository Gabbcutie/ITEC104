using System;
using System.Collections.Generic;
using System.Linq;
using.System.Text;

namespace oddandevenintegers
{
    class Program
{
    static void Main(string[] args)
    {
        int []a1 = new int[10];
        int []a2 = new int[10];
        int []a3 = new int[10];
        int k, n = 0, j = 0, z;
        Console.Write("\n\n Odd and Even Integers in different array\n");
        Console.Write("Enter the element of the array");
        z = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter {0} elements in the array \n", z);
        for(k = 0, k < z; k++)
        {
            Console.Write("Element of {0}m",z);
            a1[k] = Convert.ToInt32(Console.ReadLine());
        }
        for(k = 0,k < z; k++)
        { 
            if (a1[k] % 2 == 0)
            { 
                a2[m]=a1[k];
                    m++;
            }
            else
            { 
                a3[j]=a1[k];
                    j++;
            }
        }
        Console.Write("\n\n The Odd Integer Element are \n");
        for(k = 0; k < j; k++)
        {
            Console.Write("{0} ", a3[k]);
        }
        Console.Write("\n\n The Even Integer Element are \n");
        for(k = 0; k < m; k++)
        {
            Console.Write("{0} ", a2[k]);
        }
        Console.Write("\n\n");
        Console.Readline();
    }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._21
{
    internal class Program
    {
        public static void Array(string[] array)
        {
            bool flag = true;
            string temp;
            int numLength = array.Length;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (array[j + 1].CompareTo(array[j]) < 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            Console.WriteLine("After Bubble Sort");
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }

    
    static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Elemets");
            int n=int.Parse(Console.ReadLine());
            string[] Arr=new string[n];
            Console.WriteLine("Enter array elements");
            for (int i=0;i<n;i++)
            {
                Arr[i] = Console.ReadLine();

            }
            Console.WriteLine("Array Elements");
            for(int i=0;i<n; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            Array(Arr);
            Console.ReadKey();


        }
    }
}

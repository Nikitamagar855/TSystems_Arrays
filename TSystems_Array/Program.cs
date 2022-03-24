using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_Array
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] num = new int[5];//declaring array
            num=new int []{ 8,7,5,11,7,44 };//value given to array
            Console.WriteLine("display array by using for");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);

            }
            Console.WriteLine("display array by using foEach");
            foreach(int r in num)
            {
                Console.WriteLine(r);
            }

          string[]  name =new string  [] {"swami","susangram","yash","Niki","roshu"};
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("========================Display array by using FOEACH================");
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
            //sorting of array
            Array.Sort(num);
            Console.WriteLine("======Array of after sorting===========");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            //copy array into another array
            Console.WriteLine("Copying of our array into new array");
            int[] newarr = new int[3];
            Array.Copy(num, 1, newarr, 0, 3);
            for (int i = 0; i < newarr.Length; i++)
            {
                Console.WriteLine(newarr[i]);
            }
            Console.WriteLine("=================Reverse of an array===============");
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("Clear array by using  clear");
            Array.Clear(num ,1,3);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }




            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayslesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] temp = new int[5];
            //int index = 0;
            //for (int i = array1.Length-1; i >=0 ; i--)
            //{
            //    temp[index] = array1[i];
            //    index++;
            //}

            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine(temp[i]);
            //}

            //int countofstudents = int.Parse(Console.ReadLine());
            //Random random = new Random();
            //byte[] hight = new byte[countofstudents];
            //int all = 0;
            //for (int i = 0; i < hight.Length; i++)
            //{
            //    hight[i] = (byte) random.Next(140, 255);
            //    all += hight[i];
            //}
            //Console.WriteLine((double)all/countofstudents); 

            //int [,] MatrixArray= new int[int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())];
            //int counter = 0;
            //for (int i = 0; i < MatrixArray.GetLength(1); i++)
            //{
            //    counter += i;
            //}
            //for (int i = 0; i < MatrixArray.GetLength(0); i++)
            //{
            //    for (int ii = 0; ii < MatrixArray.GetLength(1); ii++)
            //    {
            //        MatrixArray[i, ii] = counter;

            //        Console.Write(MatrixArray[i,ii]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] array = {5, 8, 12, 46, 1, 22, 45};
            //int maxvalue=array[0];
            //int minvalue=array[0];
            //int nmax = 0;
            //int nmin = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]} ");
            //}
            //Console.WriteLine();
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (maxvalue <= array[i])
            //    { maxvalue = array[i];
            //        nmax = i;
            //    }
            //}
            //Console.WriteLine(maxvalue);
            //Console.WriteLine(nmax);
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (minvalue >= array[i])
            //    { minvalue = array[i];
            //        nmin = i;
            //    }
            //}
            //Console.WriteLine(minvalue);
            //Console.WriteLine(nmin);

            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int ii = 0; ii < array.GetLength(1); ii++)
                {
                    
                    if (i==ii)
                    {
                        array[i, ii] = 1;
                    }

                    Console.Write($"{array[i, ii]}");
                }
                Console.WriteLine();
            }


            //List<int> list = new List<int>() { 1,2,10,16,165,1111,0};
            //list.Add(2);

            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Random rand = new Random();
            //var list = new List<int> {rand.Next(2,51)};

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 



        }
    }
}

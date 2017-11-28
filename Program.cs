using System;

namespace Puzzles
{
    class Program
    {

        static Random r = new Random();
        
        static void minMaxSum(int[] arr)
        {
            int min, max, sum;
            min = max = arr[0];
            sum = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                else if(arr[i] < min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine("Min: " + min + ", Max: " + max + ", Sum: " + sum);
        }

        static void arrPrint(string[] arr)
        {
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine();
            TossCoin();
            Console.WriteLine();
            Console.WriteLine(TossMultipleCoins(10));
            Console.WriteLine();
            arrPrint(Names());

        }

        static int[] RandomArray()
        {
            int[] arr = new int[10];
            for(int i = 0; i < 10; i++)
            {
                arr[i] = r.Next(5, 25);
            }
            return arr;
        }

        static string TossCoin()
        {
            Console.WriteLine("Tossing a coin!");
            string result = r.Next() % 2 == 0 ? "Heads" : "Tails";
            Console.WriteLine(result);
            return result;
        }

        static double TossMultipleCoins(int num)
        {
            double ratio = 0;
            for(int i = 0; i < num; i++)
            {
                ratio += TossCoin() == "Heads" ? 1 : -1;
            }
            return ratio / num;
        }

        static string[] Names()
        {
            string[] nameList = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string temp;
            int[] indices = new int[2];
            for(int i = 0; i < 10; i++)
            {
                indices[0] = r.Next(0, nameList.Length);
                indices[1] = r.Next(1, nameList.Length);
                temp = nameList[indices[1]];
                nameList[indices[1]] = nameList[indices[0]];
                nameList[indices[0]] = temp;
            }
            arrPrint(nameList);
            int count = 0;
            for(int i = 0; i < nameList.Length; i++)
            {
                if(nameList[i].Length > 5)
                {
                    count ++;
                }
            }
            string[] longNames = new string[count];
            count = 0;
            for(int i = 0; i < nameList.Length; i++)
            {
                if(nameList[i].Length > 5)
                {
                    longNames[count] = nameList[i];
                    count++;
                }
            }
            return longNames;
        }
    }
}

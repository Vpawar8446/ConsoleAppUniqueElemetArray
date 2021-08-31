using System;

namespace ConsoleAppUniqueElemetArray
{
    class UniqueElement
    {
        public int ArrayElem(int[] arr)
        {
            int n = arr.Length, count, notRepeted = 0, unique = 0;
            bool[] visited = new bool[n];
            for(int i = 0; i < n; i++)
            {
                count = 1;
                if(visited[i] == true)
                {
                    continue;
                }
                for(int j = i + 1; j < n; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                if(count == 1)//Replace count == 2 to show elements which are repeted twice
                {
                    notRepeted++;
                }
                Console.WriteLine(arr[i] + "\t\t\t" +count);
                unique++;
            }
            Console.WriteLine("Number of unique Elements: " +unique);
            return notRepeted;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int num = 10;
            Console.Write("Enter Number of Elemntes in the array : ");
            Console.WriteLine();
            num = Convert.ToInt32(Console.ReadLine());
            arr = new int[num];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Array Element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Elements\t Repeted Times");
            Console.Write("Elements are not repeted: " + new UniqueElement().ArrayElem(arr));
        }
    }
}



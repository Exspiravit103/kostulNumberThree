namespace Kostul3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите размер масива");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальный порог");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("введите максимальный порог");
            int max = int.Parse(Console.ReadLine());
            int[] arr = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                arr[i] = random.Next(min,max+1);
            }
            Console.WriteLine("До сортировки");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            //соритовка 
            int memory;
            bool unsorted = true;
            while(unsorted)
            {
                unsorted = false;
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        memory = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = memory;
                        unsorted = true;
                        break;
                    }
                }
            }
            Console.WriteLine("\nПосле");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }

        }
    }
}

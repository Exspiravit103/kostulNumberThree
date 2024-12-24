using Microsoft.VisualBasic.FileIO;

namespace Kostul3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0,101);
            }
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\nВВедите индекс для удаления(нумирация насинается с 0)");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int[] result = new int[arr.Length-1];
            for (int i = 0;i < result.Length;i++)
            {
                if (i<index)
                {
                    result[i] = arr[i];
                }
                else
                {
                    result[i] = arr[i+1];
                }
            }
            arr = result;
            Console.WriteLine("Результат: ");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}

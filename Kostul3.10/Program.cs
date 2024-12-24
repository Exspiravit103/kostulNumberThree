namespace Kostul3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // КОПИПАСТ!!!
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
                arr[i] = random.Next(min, max + 1);
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}

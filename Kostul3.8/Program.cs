namespace Kostul3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool find = false;
            int[] arr = new int[10];
            int x = int.Parse(Console.ReadLine());
            int[] memory = { -1, -1 };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0,11);
            }
            foreach ( int i in arr)
            {
                Console.Write(i + " ");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == x && arr[i] != arr[j])
                    {
                        memory[0] = i;
                        memory[1] = j;
                        find = true;
                    }
                }
            }
            if (find)
            {
                Array.Sort(memory);
                Console.WriteLine("\n");
                foreach (int i in memory)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                Console.WriteLine("таких елементов нет");
            }
        }
    }
}

namespace Kostul3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер масива");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}

namespace Kostul3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            string result = string.Empty;
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0,101);
            }
            if (arr[0]>arr[1])
            {
                result += arr[0] + " ";
            }
            for (int i = 1;i < arr.Length-2;i++)
            {
                if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                {
                    result += arr[i] + " ";
                }
            }
            if (arr[arr.Length-1] > arr[arr.Length - 2])
            {
                result += arr[arr.Length];
            }
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");
            Console.WriteLine(result);
        }
    }
}

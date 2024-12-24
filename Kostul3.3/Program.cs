namespace Kostul3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти минимальную разницу между соседними елемннтами");
            Random random = new Random();
            int[] arr = new int[10];
            int[] memoryArr = { -1, -1 };
            int memory = 10; 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 11);
            }
            foreach (int i  in arr)
            {
                Console.Write(i+" ");
            }
            for (int i = 0;i < arr.Length-1; i++)
            {
                if ((Math.Abs(arr[i]-arr[i+1]))<memory)
                {
                    Math.Abs(memory = arr[i]-arr[i+1]);
                    memoryArr[0] = i;
                    memoryArr[1] = i+1;
                }
            }
            Console.WriteLine("\n");
            foreach (int i in memoryArr)
            {
                Console.Write(i+" ");
            }
        }
    }
}

namespace Kostul3._4
{
//4. Два массива — два противника
//Ты получил два массива одинаковой длины.Твоя задача — создать третий массив, где каждый элемент равен разнице соответствующих элементов из первого и второго массивов. Если разница меньше нуля, в третий массив помещается 0.
//Пример:
//Массив 1: [10, 20, 30]
//Массив 2: [15, 10, 40]
//Решение: [0, 10, 0]

    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] firstArr = new int[10];
            int[] secondArr = new int[10];
            int[] finalArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                firstArr[i] = random.Next(0,101);
                Thread.Sleep(10);
                secondArr[i] = random.Next(0, 101);
                Thread.Sleep(10);
            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                if ((firstArr[i] - secondArr[i]) < 0)
                {
                    finalArr[i] = 0;
                }
                else
                {
                    finalArr[i] = (firstArr[i] - secondArr[i]);
                }
            }
            foreach (int i in firstArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            foreach (int i in secondArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            foreach (int i in finalArr)
            {
                Console.Write(i + " ");
            }
        }
    }
}

namespace kostulNumberThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты должен создать новый массив, в котором каждый элемент будет умножен на свое место в исходном массиве(по индексу).\nНо есть одно исключение: если индекс элемента — это простое число, элемент умножается на два.\n");
            Random random = new Random();
            string result = string.Empty;
            int randomInRange = random.Next(0, 101);
            int[] arr = new int[10];
            int[] newArr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                randomInRange = random.Next(0, 101);
                arr[i] = randomInRange;
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                if (PRIMECHECK(i) && i != 0)
                {
                    newArr[i] = arr[i] * 2;
                }
                else
                {
                    newArr[i] = arr[i] * i;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                result = result + arr[i] + " ";
            }
            Console.WriteLine($"{result}\n");
            result = string.Empty;
            for (int i = 0; i < newArr.Length; i++)
            {
                result = result + newArr[i] + " ";
            }
            Console.WriteLine($"{result}\n");

        }
        /// <summary>
        /// number Prime checking
        /// </summary>
        /// <param name="n">number what need check</param>
        /// <returns>true or false</returns>
        static bool PRIMECHECK(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (i != n && n%i==0)
                {
                    return false;
                }
            }
            return true;
            
        }
    }
}

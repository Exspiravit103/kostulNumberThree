namespace Kostul3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string descryptWord = "\0", result = string.Empty;
            Console.WriteLine("Дан масив который является шифром(не билом) каждый елемент массива это номер числа в алфавите(латинсокм)\n\r нужно расшифровать");
            int[] encryptWord = { 5, 24, 19, 16, 9, 18, 1, 22, 9, 20, 31, 28 };
            string[] alpabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            for (int i = 0; i < encryptWord.Length; i++)
            {
                result = result + encryptWord[i] + " ";
            }
            Console.WriteLine($"{result}\n");
            foreach (int i in encryptWord)
            {
                descryptWord += alpabet[i - 1];
            }
            Console.WriteLine(descryptWord);
        }
    }
}

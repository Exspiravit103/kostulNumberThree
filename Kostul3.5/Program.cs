namespace Kostul3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив для шифра Цезаря Введите отступ:");
            int i = 0;
            char[] word = { 'e', 'x', 's', 'p', 'i', 'r', 'a', 'v', 'i', 't' };
            int key = int.Parse(Console.ReadLine());
            foreach (char c in word)
            {
                word[i] = (char)('a'+(c-'a'+key)%26);
                i++;
            }
            Console.WriteLine(new string(word));
            
        }
    }
}

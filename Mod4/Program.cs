namespace Mod4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 4.1.4
            string A = "abc";
            string B = "cba";
            Boolean C = A != B;
            Console.WriteLine("Задание 4.1.4 Ответ: {0}", C);

            //Задание 4.1.5
            int A1 = 3;
            int B1 = 4;
            double X = 2;
            double Y = 1;
            bool C1 = A1 < B1 | X > Y;
            Console.WriteLine("Задание 4.1.5 Ответ: {0}", C1);
        }
    }
}
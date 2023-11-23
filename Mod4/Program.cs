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

            //Задание 4.1.10
            var inv = true;
            var result = !inv;
            Console.WriteLine(result);

            //Задание 4.1.16
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш цвет красный");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш цвет зеленый");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш цвет бирюзовый");
            }

            //Задание 4.1.18 Переключатель
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color1 = Console.ReadLine();

            switch (color1)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет красный");
                break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет зеленый");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет бирюзовый");
                break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ваш цвет желтый");
                    break;
            }
        }
    }
}
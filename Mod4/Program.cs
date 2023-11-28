﻿using System.Security.Cryptography;

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

            //Цикл For
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Итерация {0}", i);
                switch(Console.ReadLine())
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
            // Цикл While
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine("Итерация {0}",k);
                switch (Console.ReadLine())
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
                k++;
            }

            //Цикл do While
            int t = 0;
            do
            {
                Console.WriteLine("Итерация {0}", t);
                switch (Console.ReadLine())
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
                t++;
            }
            while (t < 3);

            //Цикл foreach
            Console.WriteLine("Работа цикла foreach");
            string[] favcolors = new string[3];
            for (int j = 0; j < favcolors.Length; j++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", j + 1);
                favcolors[j] = Console.ReadLine();
            }
            foreach(var color2 in favcolors)
            {
                switch (color2)
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
            //Нахождение наименьшего числа в массиве
            var numbers = new[] { 6, 30, 14, 2, 15 };
            var minValue = 10000;
            var minIndex = -1;
            for (int ind = 0; ind < numbers.Length; ind++)
            {
                if (numbers[ind] < minValue)
                {
                    minValue = numbers[ind];
                    minIndex = ind;
                }
            }
            Console.WriteLine("Наименьший элемент массива имеет индекс {0}, значение этого элемента = {1}", minIndex + 1, numbers[minIndex]);

            //Представление строк как массив

            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");
            for(int l = 0; l < name.Length; l++)
            {
                Console.Write("{0} ", name[l]);
                if (name.Length == l+1)
                {
                    Console.WriteLine("последняя буква вашего имени: {0}", name[l]);
                }
            }

            // Задание 4.3.7 Обратный порядок букв в имени

            Console.Write("Введите Ваше имя: ");
            var myName = Console.ReadLine();
            Console.Write("Ваше имя в обратном порядке: ");
            for (int n = myName.Length -1; n > -1; n--)
            {
                Console.Write("{0}", myName[n]);
            }
            Console.WriteLine();
            //Двумерный массив в foreach

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nДлина массива: {0}", array.Length);
            Console.WriteLine("Колличество строк: {0}", array.GetUpperBound(0) + 1 + " ");
            Console.WriteLine("Количество колонок: {0}", array.GetUpperBound(1) + 1 + " ");

            // Задание 4.3.11 Вывод двумерного массива, перебор со столбца
            
            int[,] array1 = { { 1, 2, 3}, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13} };
            for (int i1 = 0; i1 < array1.GetUpperBound(1) + 1; i1++)
            {
                for (int k1 = 0; k1 < array1.GetUpperBound(0) + 1; k1++)
                {
                    Console.Write(array1[k1,i1] + " ");
                }
                Console.WriteLine();
            }
            // Задание 4.3.12 Сортировка одномерного массива

            Console.WriteLine("Сортировка массива");
            int[] array2 = { 5, 6, 9, 1, 2, 3, 4 };
            int temp;
            for (
                
                int i2 = 0; i2 < array2.Length;)
            {
                if (i2 + 1 == array2.Length)
                {
                    i2++;
                    continue;
                }
                if (array2[i2] > array2[i2 + 1])
                {
                    temp = array2[i2];
                    array2[i2] = array2[i2 + 1];
                    array2[i2 + 1] = temp;
                    i2 = 0;
                }
                else
                {
                    i2++;
                }
            }
            Console.WriteLine("Отсортированный массив: ");
            for (int i3 = 0; i3 < array2.Length; i3++)
            {
                Console.Write(array2[i3] + " " + ""); 
            }

            //Задание 4.3.13 Сумма элементов массива

            Console.WriteLine("\nЗадание 4.3.13 Сумма элементов массива");
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            var sumArr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sumArr = sumArr + arr[i];
            }
            Console.WriteLine("Сумма элементов массива равна: {0}", sumArr);

            //Задание 4.3.14 Перебор зубчатого массива

            Console.WriteLine("Задание 4.3.14 Перебор зубчатого массива");

            int[][] array3 = new int[3][];
            array3[0] = new int[2] { 1, 2};
            array3[1] = new int[3] { 1, 2, 3 };
            array3[2] = new int[5] { 1, 2, 3, 4, 5};

            for (int i = 0; i < array3.Length; i++)
            {
                for (int j = 0; j < array3[i].Length; j++)
                {
                    Console.Write(array3[i][j] + " ");
                } 
                Console.WriteLine(); 
            }

            //Задание 4.3.15 Количество положительных чисев в одномерном массиве
            Console.WriteLine("Задание 4.3.15 Количество положительных чисев в одномерном массиве");
            int[] array4 = { 5, -6, 9, -1, -2, -3, -4 };
            int num = 0;
            for (int i = 0; i < array4.Length; i++)
            {
                if (array4[i] > 0)
                {
                    num++;
                }
            }
            Console.WriteLine("Количество положительных чисел в массиве: {0}", num);

            //Задание 4.3.16 Количество положительных чисев в двумерном массиве

            int[,] array5 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int num1 = 0;
            for (int i = 0; i < array5.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array5.GetUpperBound(1) + 1; j++) 
                {
                    if (array5[i, j] > 0)
                    {
                        num1++;
                    }
                    Console.Write(array5[i, j] + " ");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine("Количество положительных чисел в двумерном массиве: {0}", num1);

            // Задание 4.3.17 Сортировка двумерного массива внутри одной строки

            Console.WriteLine("Отсортированный двумерный массив");

            int temp1;
            for (int i = 0; i < array5.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array5.GetUpperBound(1) + 1; j++)
                {
                    for (int h = j + 1; h < array5.GetUpperBound(1) + 1; h++)
                    {
                        if (array5[i, j] > array5[i, h])
                        {
                            temp1 = array5[i, j];
                            array5[i,j] = array5[i,h];
                            array5[i,h] = temp1;
                        }
                    }
                }
            }
            for (int i = 0; i < array5.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array5.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(array5[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Задание 4.4.2 Кортеж
            Console.WriteLine("Кортеж");
            (string name, int age) anketa;
            Console.Write("Введите Ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите ваш возраст:");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}\nВаш возраст: {1}",anketa.name, anketa.age);

            //Задание 4.4.3 Кортеж без имени

            var (name1, age1) = ("Евгения", 27);
            Console.WriteLine("Ваше имя: {0}\nВаш возраст: {1}", name1, age1);
            Console.Write("Введите Ваше имя: ");
            name1 = Console.ReadLine();
            Console.Write("Введите ваш возраст:");
            age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}\nВаш возраст: {1}", name1, age1);

            //Задание 4.4.5 Анкета питомца

            (string Name, string Type, double Age, int NameCount) Pet;
            Pet.NameCount = 0;
            Console.Write("Введите имя петомца: ");
            Pet.Name = Console.ReadLine();
            Console.Write("Введите тип питомца: ");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("введите возраст питомца: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < Pet.Name.Length; i++)
            {
                Pet.NameCount++;
            }
            Console.WriteLine("Анкета питомца");
            Console.WriteLine("Имя: {0}\nТип: {1}\nВозраст: {2}", Pet.Name, Pet.Type, Pet.Age);
            Console.WriteLine("Длина имени питомца: {0}", Pet.NameCount);

            //Практикум
            //Задание 4.5.1
            (string Name, string Surname, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) User;

            //Задание 4.5.6
            for (int j = 0; j < 3; j++)
            {
                //Задание 4.5.2
                Console.Write("Введите имя: ");
                User.Name = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                User.Surname = Console.ReadLine();
                Console.Write("Введите логин: ");
                User.Login = Console.ReadLine();

                //Задание 4.5.3 Длина логина
                User.LoginLength = User.Login.Length;

                //Задание 4.5.4
                Console.WriteLine("Есть ли у Вас питомец? Да или Нет: ");
                var hsPets = Console.ReadLine();
                if (hsPets == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                //Задание 4.5.5
                Console.Write("Введите возвраст пользователя: ");
                User.Age = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите три вашил любимых цвета: ");
                User.favcolors = new string[3];
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    Console.Write("Цвет №{0}", i + 1);
                    User.favcolors[i] = Console.ReadLine();
                }

            }            
        }
    }
}; 
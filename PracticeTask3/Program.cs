using System;

namespace PracticeTask3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в приложение по нахождению принадлежности точки заданной области!");

            // Ввод координат X и Y
            Console.WriteLine("\nВведите координаты точки для выявления принадлежности точки заданной области");
            Console.WriteLine("Введите координату Х");
            double x = Input(-100, 100);
            Console.WriteLine("Введите координату Y");
            double y = Input(-100, 100);

            // Проверка принадлежности точки с координатами x и y заданной области
            bool check = IsOwned(x, y);
            if (check)
                Console.WriteLine("\nТочка с координатами (" + x + ";" + y + ") принадлежит заданной области");
            else
                Console.WriteLine("\nТочка с координатами (" + x + ";" + y + ") НЕ принадлежит заданной области");

            Console.WriteLine("\nЗавершение работы в приложении по нахождению принадлежности точки заданной области");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }

        // Определение принадлежности точки заданной области
        public static bool IsOwned(double x, double y)
        {
            if (x >= -1 && x <= 1 && y >= -2 && y <= 1)
            {
                if ((x <= 0 && y <= -x) || (x >= 0 && y <= x))
                {
                    return true;
                }
            }
            return false;
        }

        // Ввод целого числа с ограничениями
        private static double Input(double min, double max)
        {
            double number;
            bool check;
            do
            {
                Console.Write("Ввод: ");
                check = double.TryParse(Console.ReadLine(), out number) && number >= min && number <= max;
                if (!check) Console.WriteLine($"Ошибка ввода! Введите число в пределах от {min} до {max} (включительно)");
            } while (!check);
            return number;
        }
    }
}
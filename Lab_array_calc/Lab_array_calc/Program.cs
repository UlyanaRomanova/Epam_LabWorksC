using System;

namespace Lab_array_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Работа с массивами.
            Console.WriteLine("Часть 1. Массив");
            // 1.Ввод элементов массива пользователем.
            Array.Input();
            // 2.Выбор и сортировка элементов массива.
            Array.SortingMethod();
            // 3.Вывод на экран отсортированных элементов массива.
            Array.Output();

            // Очищение консоли для отображения.
            Console.WriteLine("Нажмите любую клавишу, чтобы очистить экран");
            Console.ReadKey();
            Console.Clear();

            // Работа с калькулятором.
            Console.WriteLine("Часть 2. Калькулятор");
            // Ввод аргументов и операции над ними.
            Calculator.Input();
            // Вычисление результата.
            Calculator.Calculation();
            // Вывод результата на экран.
            Calculator.Output();

        }
    }
}

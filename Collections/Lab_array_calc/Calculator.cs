using System;

namespace Lab_array_calc
{
    class Calculator
    {
        // Объявление общих переменных: 2 аргумента, результат, операция над числами.
        static double firstArg = 0, secondArg = 0, result = 0;
        static char operation = ' ';

        // Метод ввода данных для вычислений.
        static public void Input()
        {
            // Объявление переменной - флага для проверки корректных значений.
            bool flagParse;

            // Запрос у пользователя на ввод первого аргумента вычислений.
            Console.Write("Введите первый аргумент вычисления: ");

            // Проверка на корректный ввод.
            flagParse = double.TryParse(Console.ReadLine(), out firstArg);
            // Цикл запроса, пока не будет введено корректное значение.
            while (flagParse != true)
            {
                Console.Write("Введите корректное число первого аргумента: ");
                flagParse = double.TryParse(Console.ReadLine(), out firstArg);
            }

            // Запроc у пользователя операции над числами.
            Console.Write("Выберите операцию: '+', '-', '*', '/' ");

            // Проверка на корректный ввод символа операции.
            flagParse = char.TryParse(Console.ReadLine(), out operation);
            // Цикл запросов на ввод символа операции, пока не будет введен корректный.
            if ((flagParse != true) || (operation != '+') || (operation != '-') || (operation != '*') || (operation != '/'))
            {
                while ((flagParse != true) || ((operation != '+') && (operation != '-') && (operation != '*') && (operation != '/')))
                {
                    Console.Write("Введите один символ из предложенных '+', '-', '*', '/': ");
                    flagParse = char.TryParse(Console.ReadLine(), out operation);
                }
            }

            // Запрос у пользователя на ввод второго аргумента вычислений
            Console.Write("Введите второй аргумент вычисления: ");

            // Проверка на корректный ввод. 
            flagParse = double.TryParse(Console.ReadLine(), out secondArg);
            // Цикл запроса, пока не будет введено корректное значение.
            while (flagParse != true)
            {
                Console.Write("Введите корректное число второго аргумента: ");
                flagParse = double.TryParse(Console.ReadLine(), out secondArg);
            }

        }

        // Метод вычисления.
        static public void Calculation()
        {
            // Выбор операции над введенными аргументами в зависимости от указанного пользователем.
            switch (operation)
            {
                case '+':
                    result = firstArg + secondArg;
                    break;
                case '-':
                    result = firstArg - secondArg;
                    break;
                case '*':
                    result = firstArg * secondArg;
                    break;
                case '/':
                    // обработка исключения "деление на 0" через try..catch.
                    try
                    {
                        // Создаем новое исключение, при втором аргументе равном 0.
                        if (secondArg == 0)
                        { throw new DivideByZeroException(); }
                        else
                        { result = firstArg / secondArg; }
                        break;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                        Console.ReadKey();
                        break;
                    }
            }
        }

        // Метод вывода результата на экран.
        static public void Output()
        {
            if ((secondArg == 0) && (operation == '/'))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Результат выражения {0} {1} {2} = {3}", firstArg, operation, secondArg, result);
                Console.ReadKey();
            }
        }
    }
}

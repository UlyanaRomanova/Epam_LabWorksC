using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_array_calc
{
    class Array
    {
        // Объявление общей переменной массива тип элементов double.
        static double[] mass;

        // Метод для ввода элементов массива. Проверка на коррекный ввод.
        static public void Input()
        {
            // Объявление необходимых для работы переменных: 
            // число элементов массива, элемент массива, флаг для проверки корректности ввода.
            int numberOfElements;
            double elementArray;
            bool flagParse;
            
            // Запрос на ввод количества элементов массива у пользователя.
            Console.Write("Введите количество элементов массива:");
            
            // Проверка на корректный ввод целого положительного числа.
            flagParse = int.TryParse(Console.ReadLine(), out numberOfElements);
            
            // Цикл запроса на ввод количества элементов, пока не будет введено корректное значение.
            while (flagParse != true)
            {
                Console.Write("Введите корректное число:");
                flagParse = int.TryParse(Console.ReadLine(), out numberOfElements);
            }

            // Инициализация массива с заданным ползователем количеством элементов.
            mass = new double[numberOfElements];

            // Заполнение ползователем элементов массива с проверкой на корректные значения.
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write("Введите {0} элемент массива:", (i + 1));
                flagParse = double.TryParse(Console.ReadLine(), out elementArray);
                mass[i] = elementArray;

                while (flagParse != true)
                {
                    Console.Write("Введите корректное число {0} элемента массива:", (i + 1));
                    flagParse = double.TryParse(Console.ReadLine(), out elementArray);
                }
            }
            
        }

        // Метод сортировки элементов массива. Есть выбор по возрастанию или по убыванию.
        static public void SortingMethod()
        {
            // Переменная строкового типа для работы.
            string method=" ";
            
            // Запрос метода сортировки (по возрастанию или по убыванию у пользователя).
            // Запрос будет повторяться, пока не будет ввдеено корректное значение. (Регистр не важен, учтены оба).
            do
            {
                Console.Write("Выберите метод сортировки: по возрастанию [U] или по убыванию [D]:");
                method = Console.ReadLine();
            } while ((method != "U") && (method != "u") && (method != "D") && (method != "d"));
            
            // Если выбран метод "по возрастанию", отсортировать массив по возрастанию.
            if ((method == "U") || (method == "u"))
            {
                System.Array.Sort(mass);
            }

            // Если выбран метод "по убыванию", отсортировать массив по убыванию.
            else if ((method == "D") || (method == "d"))
            {
                System.Array.Sort(mass);
                System.Array.Reverse(mass);
            }
                       
            
        }

        // Метод вывода массива на экран.
        static public void Output() 
        {
            foreach (double index in mass) 
            {
                Console.WriteLine(index);
            }
        }


    }
}

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Lab_array_calc
{
    class Program
    {
        static void Main()
        {
            // Работа с калькулятором.
            Console.WriteLine("Часть Калькулятор");
            // Ввод аргументов и операции над ними.
            Calculator.Input();
            // Вычисление результата.
            Calculator.Calculation();
            // Вывод результата на экран.
            Calculator.Output();

            // Создание объектов класса "фрукты".
            Fruits AppleGold = new Fruits("Яблоко", "Голден", 105.00m, 15.0);
            Fruits AppleAida = new Fruits("Яблоко", "Айдаред", 129.39m, 26.2);
            Fruits AppleGreSm = new Fruits("Яблоко", "Гренни Смит", 119.99m, 45.6);
            Fruits PearKonf = new Fruits("Груша", "Концеренц", 157.79m, 68.5);
            Fruits PearForel = new Fruits("Груша", "Форель", 219.99m, 10.4);
            Fruits PersimmonKor = new Fruits("Хурма", "Королек", 84.19m, 74.8);
            Fruits GrapeKish = new Fruits("Виноград", "Киш-Миш", 136.89m, 12.0);
            Fruits GrapeTaify = new Fruits("Виноград", "Тайфи", 157.89m, 5.4);
            Fruits ApricotDessert = new Fruits("Абрикос", "Десертный", 385.00m, 14.3);
            Fruits ApricotRuss = new Fruits("Абрикос", "Россиянин", 279.50m, 9.8);

            // Объявление коллекции их элементов. 
            List<Fruits> CollectionFruit = new List<Fruits>() { AppleGold, AppleAida, AppleGreSm, PearKonf,PearKonf,PersimmonKor,GrapeKish, GrapeTaify,ApricotDessert, ApricotRuss };
            
            // Коллекция с отсортированными элементами. Сортировка по возрастанию по полю "Тип", затем по убыванию по полю "Цена".
            List<Fruits> CollectionSort = CollectionFruit.OrderBy(x => x.type).ThenByDescending(y => y.price).ToList();
            
            Console.Clear();
            Console.WriteLine("Коллекции");
            Console.WriteLine();

            // Вывод элементов отсортированной коллекции на экран
            foreach (var unit in CollectionSort)
            {
                Console.WriteLine("{0} '{1}' в количестве {3} кг стоимостью {2} руб за кг", unit.type, unit.sort, unit.price, unit.quantity);
            }
        }
    }
}

 using System;

namespace Lab_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса "Урожай" с использованием класса "Овощ".
            Harvest VegPotato = new Vegetable(true,"Картофель");

            // Создание объекта класса "Урожай" с использованием класса "Фрукт".
            Harvest FruApricot = new Fruit(true, "Абрикос");

            // Создание объекта класса "Фрукт".
            Harvest FruPlum = new Fruit(false, "Слива");

            // Создание объекта класса "Ягода". 
            Barry<string> Grape = new Barry<string>(true,"Виноград");
            // Создание объекта класса "Ягода" для проверки обобщенности класса.
            Barry<int> UnknowGrape = new Barry<int> (true, 2277);

            // Создание объекта класса "Яблоко".
            Apple AppGala = new Apple(false,"Яблоко","Роял Гала");

            // Создание объекта класса "Груша".
            Pear PearHoney = new Pear(true, "Груша", "Медовая");

            // Создание объекта класса Vegetable
            Vegetable vegCarrot = new Vegetable(true, "Морковь");

            // Метод "Созревание" у объекта класса "Урожай", созданного с использованием класса "Овощ".
            VegPotato.Maturation();
            // Метод "Созревание" у объекта класса "Урожай", созданного с использованием класса "Фрукт".
            FruApricot.Maturation();
            // Метод "Созревание" у объекта класса "Фрукт" (должен перекрыть родительский метод).
            FruPlum.Maturation();
            // Метод "Показать как растет ягода" у объекта класса "Ягода".
            Grape.ShowHowGrow();
            // Метод "Растет на дереве" у объекта класса "Яблоко" (должен перекрыть родительский метод класса "Фрукт").
            AppGala.GrowOnTrees();
            // Метод "Созревание" у объекта класса "Груша", вызывает родительский метод класса "Фрукт".
            PearHoney.Maturation();
            // Метод "Растет на дереве" у объекта класса "Груша" (должен перекрыть родительский метод класса "Фрукт").
            PearHoney.GrowOnTrees();
            // Вывести на экран выручку от продажи яблок (15 кг по цене 125,9), используя метод родительского класса.
            Console.WriteLine(AppGala.BuyProduct(125.9 , 15));
            Console.WriteLine();

            Console.WriteLine("-----Lab_OOP-2-----");
            Console.WriteLine();
            Console.WriteLine("Метод ToString переопределен для класса Vegetable");
            // Добавлено вычисление стоимости для вывода в переопределенном методе ToString.
            vegCarrot.BuyProduct(25.4 , 10);
            // Вызов переопределенного метода ToString. Метод переопределен в классе Vegetable.
            Console.WriteLine (vegCarrot.ToString());

            Console.WriteLine("--------------------");
            Console.WriteLine("Метод Equals переопределен для класса Vegetable");
            // Вызов переопределенного метода Equals
            Console.WriteLine(vegCarrot.Equals(VegPotato));
            Console.WriteLine(vegCarrot.Equals(AppGala));

            Console.WriteLine("--------------------");
            Console.WriteLine("Обобщенный класс Barry. Создан новый объект класса, название которого принимает не строковое, а числовое значение.");
            // Метод "Показать как растет ягода" у объекта класса "Ягода", чтобы показать работу обобщенного класса.
            UnknowGrape.ShowHowGrow();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_OOP
{
    // Описание класса "Фрукт", который наследуется от класса "Урожай".
    class Fruit : Harvest
    {
        // Переменная "Вид фрукта".
        public string TypeOfFruit { get; set; }

        // Переменная "Цена за кг".
        public double Price { get; set; }

        // Переменная "Количество".
        public double Quantity { get; set; }

        // Конструктор класса "Фрукт", используя конструктор родительского класса "Урожай". 
        public Fruit(bool maturity, string typeOfFruit) : base(maturity)
        {
            TypeOfFruit = typeOfFruit;
        }

        // Метод класса "Определение стоимости = цена за кг * количество".
        public double BuyProduct(double price, double quantity)
        {
            double total = price * quantity;
            return (total);
        }

        // Метод класса "Растет на дереве".
        public virtual void GrowOnTrees() 
        {
            Console.WriteLine("Фрукт растет на дереве");
        }

        // Реализация родительского метода "Созревание" в классе "Фрукт".
        public override void Maturation()
        {
            if (Maturity)
            {
                Console.WriteLine("Фруктовая культура {0} созрела", TypeOfFruit);
            }
            else
            {
                Console.WriteLine("Фруктовая культура {0} еще не зрелая", TypeOfFruit);
            }
        }
    }
}

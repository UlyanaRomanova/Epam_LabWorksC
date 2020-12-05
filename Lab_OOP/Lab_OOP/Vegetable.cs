using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_OOP
{
    // Описание класса "Овощ", который наследуется от класса "Урожай".
    class Vegetable : Harvest
    {
        // Переменная "Вид овоща".
        public string TypeOfVegitable { get; set; }

        // Переменная "Цена за кг".
        public double Price { get; set; }

        // Переменная "Количество".

        public double Quantity { get ; set; }
        // Конструктор класса "Овощ", используя конструктор родительского класса "Урожай".
        public Vegetable(bool maturity, string typeOfVegitable) : base(maturity)
        {
            TypeOfVegitable = typeOfVegitable;
        }

        // Метод класса "Определение стоимости = цена за кг * количество".
        public double BuyProduct(double price, double quantity) 
        {
            double total = price * quantity;
            return (total);
        }

        // Реализация родительского метода "Созревание" в классе "Овощ".            
        public override void Maturation()
        {
            if (Maturity)
            {
                Console.WriteLine("Овощная культура {0} созрела", TypeOfVegitable);
            }
            else
            {
                Console.WriteLine("Овощная культура {0} еще не зрелая", TypeOfVegitable);
            }
        }
    }
}

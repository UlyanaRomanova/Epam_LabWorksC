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

        // Переменная, содержащая общую стоимость продукта.
        double Buy = 0.0;
        
        // Конструктор класса "Овощ", используя конструктор родительского класса "Урожай".
        public Vegetable(bool maturity, string typeOfVegitable) : base(maturity)
        {
            TypeOfVegitable = typeOfVegitable;
        }

        // Метод класса "Определение стоимости = цена за кг * количество".
        public double BuyProduct(double price, double quantity) 
        {
            double total = price * quantity;
            // Добавлена переменная для участия в методе ToString
            Buy = total;
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

        // Переопределение метода ToString
        public override string ToString()
        {
            return String.Format("{0} был(а) продан(а) за {1} рублей ", TypeOfVegitable, Buy);
        }

        // Переопределение метода Equals
        public override bool Equals(object obj)
        {
            return obj is Vegetable vegetable &&
                   Maturity == vegetable.Maturity &&
                   TypeOfVegitable != vegetable.TypeOfVegitable;
        }
    }
}

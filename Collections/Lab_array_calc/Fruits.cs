using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_array_calc
{
    // Класс "Фрукты". Тип, сорт, цена, количество.
    class Fruits
    {
        public string type;
        public string sort;
        public decimal price;
        public double quantity;

        public Fruits(string type, string sort, decimal price, double quantity)
        {
            this.type = type;
            this.sort = sort;
            this.price = price;
            this.quantity = quantity;
        }
    }
}

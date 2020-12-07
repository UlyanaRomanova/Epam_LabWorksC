using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_OOP
{
    // Описание класса "Груша", который наследуется от класса "Фрукт".
    class Pear : Fruit
    {
        // Переменная "Сорт груши".
        public string Sort { get; set; }

        // Конструктор класса "Груша", используя конструктор родительского класса.
        public Pear(bool maturity, string typeOfFruit, string sort) : base(maturity, typeOfFruit)
        {
            Sort = sort;
        }

        // Перекрытие метода родиельсокго класса "Растет на дереве".
        public override void GrowOnTrees()
        {
            Console.WriteLine("Груша сорта {0} растут в ближней части сада", Sort);
        }
    }
}

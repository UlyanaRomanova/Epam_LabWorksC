using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_OOP
{
    // Описание класса "Яблоко", который наследуется от класса "Фрукт".
    class Apple : Fruit
    {
        // Переменная "Сорт яблока".
        public string Sort { get; set; }

        // Конструктор класса "Яблоко", используя конструктор родительского класса.
        public Apple(bool maturity, string typeOfFruit, string sort) : base(maturity, typeOfFruit)
        {
            Sort = sort;
        }

        // Перекрытие метода родиельсокго класса "Растет на дереве".
        public override void GrowOnTrees()
        {
            Console.WriteLine("Яблоки сорта {0} растут в дальней части сада", Sort);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_OOP
{
    // Описание абстрактного класса "Урожай".
    abstract class Harvest
    {
        // Переменная "Зрелость" (или зрелый, или нет).
        public bool Maturity { get; set; }

        // Конструктор класса "Урожай".
        public Harvest(bool maturity) 
        {
            Maturity = maturity;
        }

        // Абстрактный метод "Созревание".
        abstract public void Maturation();

    }
}

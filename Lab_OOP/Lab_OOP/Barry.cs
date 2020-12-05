 using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_OOP
{
    // Описание класса "Ягода", который наследуется от класса "Урожай".
    class Barry : Harvest
    {
        // Переменная "Вид ягоды".
        public string TypeOfBarry { get; set; }

        // Конструктор класса "Ягода", используя конструктор родительского класса "Урожай".        
        public Barry(bool maturity, string typeOfBarry) : base(maturity)
        {
            TypeOfBarry = typeOfBarry;
        }

        // Метод класса "Показать как растет ягода".
        public void ShowHowGrow()
        {
            Console.WriteLine("{0} растет гроздьями", TypeOfBarry);
        }

        // Реализация родительского метода "Созревание" в классе "Ягода".
        public override void Maturation()
        {
            if (Maturity)
            {
                Console.WriteLine("Ягодная культура {0} созрела",TypeOfBarry);
            }
            else
            {
                Console.WriteLine("Ягодная культура {0} еще не зрелая", TypeOfBarry);
            }
        }
    }
}

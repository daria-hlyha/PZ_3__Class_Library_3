using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_3
{
    public class MistoSingleton
    {
        private static Misto instance;

        private MistoSingleton() {}

        public static Misto GetInstance(string nazva = null, double shyrota = 0.0, double dovgota = 0.0)
        {
            if (instance == null)
            {
                if (!string.IsNullOrEmpty(nazva) && shyrota != 0.0 && dovgota != 0.0)
                {
                    instance = new Misto(nazva, shyrota, dovgota);
                    Console.WriteLine($"Екземпляр створено: {nazva}, Широта: {shyrota}, Довгота: {dovgota}");
                }
                else
                {
                    Console.WriteLine("Неможливо створити екземпляр без параметрiв.");
                }
            }
            else if (instance.Nazva_Mista == nazva && instance.Shyrota == shyrota && instance.Dovgota == dovgota)
            {
                Console.WriteLine("Екземпляр з такими даними вже iснує.");
            }
            else
            {
                Console.WriteLine("Неможливо створити новий об'єкт з iншими параметрами. Повертаємо iснуючий екземпляр.");
            }

            return instance;
        }
    }
}

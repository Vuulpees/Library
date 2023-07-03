using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace kval02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Driver driver = new Driver("Иванов Иван Иванович", new DateTime(1990, 5, 10), "ул. Ленина, 10");
            Car car1 = new Car("Toyota Camry", 2018, "серебристый", "седан");
            Car car2 = new Car("Ford Focus", 2019, "черный", "хэтчбек");

            driver.Cars.Add(car1);
            driver.Cars.Add(car2);



            Console.WriteLine("Содержание объекта Driver:");
            Console.WriteLine("------------------------------");
            Console.WriteLine(driver.ToString());
            Console.WriteLine();

            Console.WriteLine("Содержание объектов Car:");
            Console.WriteLine("-----------------------");
            foreach (var car in driver.Cars)
            {
                Console.WriteLine(car.ToString());
            }

            Console.ReadKey();



        }
    }
}

    


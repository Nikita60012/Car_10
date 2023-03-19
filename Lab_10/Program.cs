using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Car volga = new Car("Волга");
            Car moskvich = new Car("Москвич");
            Car niva = new Car("Нива");
            Car jiguli = new Car("Жигули");
            Garage garage = new Garage();
            garage.add(volga);
            garage.add(moskvich);
            garage.add(niva);
            garage.add(jiguli);
            Washing wash = Washer.washing;
            wash(garage.parkedCars);
        }
    }
    class Car
    {
        public string name;
        public Car(string name)
        {
            this.name = name;
        }
    }
    class Garage
    {
        public List<Car> parkedCars = new List<Car>();
        public void add(Car car)
        {
            parkedCars.Add(car);
        }
    }
    class Washer
    {
        public static void washing(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine("Мытьё " + car.name + " завершено");
            }
        }
    }
    delegate void Washing(List<Car> cars);
}
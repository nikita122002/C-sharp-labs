using System;

namespace ЛР3_Car
{
    class Car
    {
        protected int numberOfCars;
        public int NumberOfCars
        {
            get { return numberOfCars; }
            private set { numberOfCars = value; }
        }
        protected int enginePower;
        protected float price;
        protected float weight;
        protected string typeOfCar;
        protected float totalPrice;
        public Car(int numberOfCars, int enginePower, float price, float weight, string typeOfCar)
        {
            this.numberOfCars = numberOfCars;
            this.enginePower = enginePower;
            this.price = price;
            this.weight = weight;
            this.typeOfCar = typeOfCar;

        }
        public void ShowInformation()
        {
            Console.WriteLine("Количество машин: {0}\n" +
                "Мощность двигателя: {1}\n" +
                "Средняя цена: {2}\n" +
                "Средний масса:{3} \n" +
                "Тип машины: {4}\n",
               numberOfCars, enginePower, price, weight, typeOfCar);
        }
        public void AddNumberOfCars()
        {
            string newNumberOfCars;
            do
            {
                Console.Write("Введите новое количество машин: ");
                newNumberOfCars = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(newNumberOfCars, out numberOfCars));
        }
        public void TotalPrice()
        {
            totalPrice = numberOfCars * price;
            Console.WriteLine("Общая цена всех машин: " + totalPrice);
        }
        class Cars
        {
            Car[] arr;
            public Cars(int size) { arr = new Car[size]; }
            public Car this[int index]
            {
                get
                {
                    return arr[index];
                }
                set
                {
                    arr[index] = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars;
            int enginePower;
            float price;
            float weight;
            string typeOfCar = "";
            string input;
            int number = 0;
            do
            {
                Console.WriteLine("Введите количество машин: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out numberOfCars));
            do
            {
                Console.WriteLine("Введите мощность двигателя в л.с.: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out enginePower));
            do
            {
                Console.WriteLine("Введите цену одной машины в $: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out price));
            do
            {
                Console.WriteLine("Введите массу одной машины в кг: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out weight));
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите тип машины:\n" +
                    "1. Седан\n" +
                    "2. Купе\n" +
                    "3. Универсал\n");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number) || (number != 1 && number != 2 && number != 3));
            switch (number)
            {
                case 1:
                    typeOfCar = "Седан";
                    break;
                case 2:
                    typeOfCar = "Купе";
                    break;
                case 3:
                    typeOfCar = "Универсал";
                    break;
            };
            Car car = new Car(numberOfCars, enginePower, price, weight, typeOfCar);
            while (true)
            {
                do
                {                  
                    Console.WriteLine("Выберите действие:\n" +
                        "1. Вывести информацию\n" +
                        "2. Изменить количество машин\n" +
                        "3. Вывести общую цену машин\n");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out number) && (number != 1 || number != 2 || number != 3));
                switch (number)
                {
                    case 1:
                        car.ShowInformation();
                        break;
                    case 2:
                        car.AddNumberOfCars();
                        break;
                    case 3:
                        car.TotalPrice();
                        break;
                }
            }
        }
    }
}
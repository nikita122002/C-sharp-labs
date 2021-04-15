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
            Console.WriteLine("Number of cars: {0}\n" +
                "Engine power: {1}\n" +
                "Average price: {2}\n" +
                "Average weight:{3} \n" +
                "Body type: {4}\n",
               numberOfCars, enginePower, price, weight, typeOfCar);
        }
        public void AddNumberOfCars()
        {
            string newNumberOfCars;
            do
            {
                Console.Write("Enter the new number of cars: ");
                newNumberOfCars = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(newNumberOfCars, out numberOfCars));
        }
        public void TotalPrice()
        {
            totalPrice = numberOfCars * price;
            Console.WriteLine("Total price of all cars: " + totalPrice);
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
                Console.WriteLine("Enter the number of cars: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out numberOfCars));
            do
            {
                Console.WriteLine("Enter the engine power : ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out enginePower));
            do
            {
                Console.WriteLine("Enter the price of one car: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out price));
            do
            {
                Console.WriteLine("Enter the weight of one machine: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out weight));
            do
            {
                Console.Clear();
                Console.WriteLine("Choose a body type:\n" +
                    "1. Sedan\n" +
                    "2. Сoupe\n" +
                    "3. Hatchback\n");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number) || (number != 1 && number != 2 && number != 3));
            switch (number)
            {
                case 1:
                    typeOfCar = "Sedan";
                    break;
                case 2:
                    typeOfCar = "Сoupe";
                    break;
                case 3:
                    typeOfCar = "Hatchback";
                    break;
            };
            Car car = new Car(numberOfCars, enginePower, price, weight, typeOfCar);
            while (true)
            {
                do
                {                  
                    Console.WriteLine("Select an action:\n" +
                        "1. Display information\n" +
                        "2. Change the number of machines\n" +
                        "3. Print the total price of the cars\n");
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
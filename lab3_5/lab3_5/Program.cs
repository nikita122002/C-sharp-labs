using System;

namespace lab5
{
    class Car
    {
        protected int numberOfCars;
        public Car() { }
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
        public virtual void ShowInformation()
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
    class Driver : Car
    {
        private int satiety = 0;
        public int Satiety
        {
            get { return satiety; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("Водитель не голоден");
                }
                else satiety = value;
            }
        }
        private int energy;
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("Энергия водителя переполнена");
                }
                else energy = value;
            }
        }
        private int happiness = 0;
        public int Happiness
        {
            get { return happiness; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("водитель счастлив");
                }
                else happiness = value;
            }
        }
        private int sleep = 0;
        public int Sleep
        {
            get { return sleep; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("Водитель хочет спать");
                }
                else sleep = value;
            }
        }
        public Driver() { }
        public Driver(int numberOfCars, int enginePower, float price, float weight, string typeOfCar) : base(numberOfCars, enginePower, price, weight, typeOfCar) { }
        public virtual void Feel()
        {
            Console.WriteLine("Уровень сытости: " + Satiety + " из 100");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Уровень энергии " + Energy + " из 100");
        }
        public virtual void Do_smh()
        {
            Console.WriteLine("Уровень счастья: " + Happiness + " из 100");
        }
        public virtual void Rest()
        {
            Console.WriteLine("Уровень сонливости: " + Sleep + " из 100");
        }
        public void StateInformation()
        {
            Console.WriteLine("Уровень сытости: " + Satiety + " из 100");
            Console.WriteLine("Уровень энергии " + Energy + " из 100");
            Console.WriteLine("Уровень счастья: " + Happiness + " из 100");
            Console.WriteLine("Уровень сонливости: " + Sleep + " из 100");
        }
    }
    class First_driver : Driver
    {
        private string carColor;
        public string CarColor
        {
            get { return carColor; }
            set { carColor = value; }
        }
        public First_driver(int numberOfCars, int enginePower, float price, float weight, string typeOfCar, string carColor) : base(numberOfCars, enginePower, price, weight, typeOfCar)
        {
            this.carColor = carColor;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Цвет машины: " + carColor);
        }
        public override void Feel()
        {
            Satiety = Satiety + 10;
            Energy = Energy + 10;
            Happiness = Happiness + 5;
            Sleep = Sleep + 5;
            base.Feel();
        }
        public override void Eat()
        {
            if (Energy == 0) Console.WriteLine("Пополните энергию водителя");
            else
            {
                Energy = Energy - 10;
                Satiety = Satiety - 5;
                Happiness = Happiness + 10;
                Sleep = Sleep + 10;
            }
            base.Eat();
        }
        public override void Do_smh()
        {
            Sleep = Sleep + 5;
            Happiness = Happiness + 10;
            base.Do_smh();
        }
        public override void Rest()
        {
            Sleep = 0;
            Satiety = 0;
            Energy = Energy + 20;
            base.Rest();
        }
    }
    class Second_driver : Driver
    {
        private string eyesColor;
        public string EyesColor
        {
            get { return eyesColor; }
            set { eyesColor = value; }
        }
        public Second_driver() { }
        public Second_driver(int numberOfCars, int enginePower, float price, float weight, string typeOfCar, string eyesColor) : base(numberOfCars, enginePower, price, weight, typeOfCar)
        {
            this.eyesColor = eyesColor;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Цвет глаз: " + eyesColor);
        }
        public override void Feel()
        {
            Satiety = Satiety + 20;
            Energy = Energy + 15;
            Happiness = Happiness + 10;
            Sleep = Sleep + 10;
            base.Feel();
        }
        public override void Eat()
        {
            base.Eat();
            if (Energy == 0) Console.WriteLine("Покормите  водителя");
            else
            {
                Energy = Energy - 5;
                Satiety = Satiety + 5;
                Happiness = Happiness + 15;
                Sleep = Sleep + 15;
            }
        }
        public override void Do_smh()
        {
            Sleep = Sleep + 5;
            Happiness = Happiness + 5;
            base.Do_smh();
        }
        public override void Rest()
        {
            Sleep = 0;
            Satiety = 0;
            Energy = Energy + 20;
            base.Rest();
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
            Driver driver = new Driver(numberOfCars, enginePower, price, weight, typeOfCar);
            Second_driver second_driver = new Second_driver(5, 100, 30, 3500, "Sedan", "Black");
            while (true)
            {
                do
                {
                    Console.WriteLine("Select an action:\n" +
                    "1. Display information\n" +
                    "2. Change the number of machines\n" +
                    "3. Print the total price of the cars\n " +
                    "4. Feed\n" +
                    "5. Dosmh\n" +
                    "6. Rest\n");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out number) && (number != 1 || number != 2 || number != 3));
                Console.Clear();
                switch (number)
                {
                    case 1:
                        driver.ShowInformation();
                        break;
                    case 2:
                        driver.StateInformation();
                        break;
                    case 3:
                        driver.Feel();
                        break;
                    case 4:
                        driver.Eat();
                        break;
                    case 5:
                        driver.Do_smh();
                        break;
                    case 6:
                        driver.Rest();
                        break;
                }
            }
        }
    }
}

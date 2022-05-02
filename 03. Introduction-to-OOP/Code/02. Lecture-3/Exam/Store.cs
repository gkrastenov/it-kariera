using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    public class Store
    {
        private string name;
        private List<Car> listOfCar;

        public Store(string name)
        {
            RenameStore(name);
            listOfCar = new List<Car>(); // но да създава валидно състояние в полето рефериращо към списък от коли
        }

        public List<Car> ListOfCar
        {
            get { return listOfCar; }
        }

        public string Name
        {
            get { return name; }       
            private set { name = value; }
        }

        /// <summary>
        /// Методът трябва да добавя в списъка с коли подадения.
        /// </summary>
        /// <param name="car">Подадената кола от Program.cs</param>
        public void AddCar(Car car)
        {
            listOfCar.Add(car);
        }

        /// <summary>
        /// Тази команда добавя дадената кола към списъка от коли на автокъщата.
        /// </summary>
        /// <param name="car">Подадената кола от Program.cs</param>
        /// <returns>Ако колата е успешно премахната (тоест такава е имало в списъка),
        /// методът трябва да връща true като стойност, в обратен случай false.</returns>
        public bool SellCar(Car car) // когато го подавам се прави щаблон на обекта и съответно се създава нова референция
        {
            Car foundedCar = listOfCar.Find(x => x.Number == car.Number);
            if (foundedCar != null)
            {
                // listOfCar.Remove(car); няма да работи защото обекта car не е "original" а е създадения нов шаблонен обект "shadow object"
                listOfCar.Remove(foundedCar);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Тази команда сумира цените на всички коли от списъка сколи на автокъщата
        /// </summary>
        /// <returns>Методът следва да сумира всички цени на колите в автокъщата и да върне double стойност</returns>
        public double CalculateTotalPrice()
        {
            /* first approach
            double sum = 0;
            for (int i = 0; i < listOfCar.Count; i++)
            {
                sum += listOfCar[i].Price;
            }
            return sum;
            */

            // second approach
            return listOfCar.Sum(car => car.Price);
        }

        /// <summary>
        /// Методът следва да обхожда всички коли от списъка с коли на дадената автокъща и да намери референция към тази, 
        /// която има най-висока цена. Няма да има коли с еднакви цени. Трябва да върнете стойност обект от тип Car.
        /// </summary>
        /// <returns></returns>
        public Car GetCarWithHighestPrice()
        {
            return listOfCar.OrderByDescending(car => car.Price).First();

            // second approach
            // double maxPriceOfCar = listOfCar.Max(car => car.Price);
            // return listOfCar.First(car => car.Price == maxPriceOfCar);
        }

        public Car GetCarWithLowestPrice()
        {
            return listOfCar.OrderBy(car => car.Price).First();
        }

        /// <summary>
        /// Променя името на автокъщата
        /// Методът следва да промени стойността в полето name, като разбира се се подчинява 
        /// на правилата за валидация, описани в по-долната секция
        /// </summary>
        /// <param name="newName">име от Program.cs</param>
        public void RenameStore(string newName)
        {
            if(IsValidName(newName))
                this.Name = newName;
        }

        /// <summary>
        /// Има за цел да продаде всички коли от една автокъща.
        /// Методът следва да премахне всички коли от списъка
        /// </summary>
        public void SellAllCars()
        {
            listOfCar.Clear();
        }

        private bool IsValidName(string name)
        {
            if(name.Length < 5)
            {
                throw new ArgumentException("Invalid store name!");
            }
            return true;
        }

        public override string ToString()
        {
            if(listOfCar.Count == 0)
            {
                return $"Store {this.name} has no available cars.";
            }

            string result = $" Store {this.name} has {listOfCar.Count} car/s:\n";
            for (int i = 0; i < listOfCar.Count - 1; i++)
            {
                result += listOfCar[i].ToString() + '\n';
            }
            result += listOfCar[listOfCar.Count - 1].ToString();
            return result;
        }
    }
}
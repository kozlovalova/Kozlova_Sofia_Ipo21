using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    using System;

    class Student //1 задание
    {
        public string Name { get; set; } = string.Empty;
    }

    class Child //2 задание
    {
        public int Age { get; set; }

        public Child() { }
    }

    class Car //3 - 4 задание
    {
        private int year; //3 задание

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
            }
        }

        public string Name { get; set; } //4 задание
        public string Color { get; set; }

        public Car() { }
    }

    class Product //5 задание
    {
        protected string name;

        public string Name
        {
            get
            {
                return name;
            }
            private set { }
        }

        public Product()
        {
            this.name = "Рамиль";
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student(); //1 задание
            student.Name = "Анна";

            Child child = new Child(); //2 задание
            child.Age = 10;

            Car car = new Car(); //3 задание
            car.Year = 2023;

            Car kia = new Car(); //4 задание
            kia.Name = "KIA SOUL";
            kia.Color = "green";

            Product product = new Product(); //5 задание
            Console.WriteLine(product.Name); //Рамиль
        }
    }
}

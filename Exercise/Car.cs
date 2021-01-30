using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Car:IComparable<Car>
    {
        public Car(string brand, Color colour, int horsePower)
        {
            this.Brand = brand;
            this.Colour = colour;
            this.HorsePower = horsePower;

        }

        public Car(string brand,Color colour, int horsePower,Person driver):this(brand,colour,horsePower)
        {
            this.Driver = driver;
        }
        public string Brand { get; set; }         
        public int HorsePower { get; set; }
        public Color Colour { get; set; }
        public Person Driver { get; set; }

        public int CompareTo(Car car)
        {
            if (this.HorsePower < car.HorsePower)
            {
                return -1;
            }

            else if (this.HorsePower == car.HorsePower)
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }
    }
}

using System;
using Assignment1.Engine;
using Assignment1.ColourDecoration;
using Assignment1.Main;

namespace Assignment1.Vehicles
{
    public abstract class Vehicle
    {
        // specification for the car
        protected Brand brand;
        protected ICarColour carColour;
        protected EngineClass engine;
        protected Numberplate numberplate;
        protected IWheel wheel;

        // counter
        public static int counter = 0;
        protected int id;
        private double price;

        protected Vehicle(ICarColour carColour, IWheel wheel, Brand brand, Numberplate numberplate, EngineClass engine)
        {
            this.brand = brand;
            this.carColour = carColour;
            this.numberplate = numberplate;
            this.wheel = wheel;
            this.engine = engine;

            id = ++counter;
            price = wheel.Price() + carColour.CalculatePrice() + brand.GetPrice() + engine.GetPrice();
        }

        public Numberplate Numberplate { get { return this.numberplate; } set { this.numberplate = value; } }
        public int ID { get { return id; } }
        public double Price
        {
            get
            {
                return this.price;
            }
            set { price = value;}
        }


        public override string ToString()
        {
        return "\n---------------------------\nID: " + ID+ ",\n" 
            + this.Description() + ",\n" 
            + brand.GetDescription() + ",\n" 
            + carColour.Description() + ",\n" 
            + wheel.Description() + ",\n" 
            + engine.GetDescription()+ ",\n" 
            + Price  + ",\n" 
            + this.numberplate.SpecificNumberplate 
            + "\n---------------------------";
        }

        public abstract string Description();
    }
}

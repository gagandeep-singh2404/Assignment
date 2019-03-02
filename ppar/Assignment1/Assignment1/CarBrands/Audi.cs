using System;
namespace Assignment1.CarBrands
{
    public class Audi: Brand
    {

        public override string GetDescription()
        {
            return "Brand: Audi\nVersion: ";
        }

        public override int GetPrice()
        {
            return 25000;
        }
    }
}

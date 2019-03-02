using System;
namespace Assignment1.CarBrands
{
    public class Ford: Brand
    {
        public override string GetDescription()
        {
            return "Brand: Ford \nVersion: ";
        }

        public override int GetPrice()
        {
            return 20000;
        }
    }
}

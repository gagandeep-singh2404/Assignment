using System;
namespace Assignment1
{
    public class BMW: Brand
    {

        public override string GetDescription()
        {
            return "Brand: BMW \nVersion: ";
        }

        public override int GetPrice()
        {
            return 30000;
        }
    }
}

using System;
namespace Assignment1
{
    public class VW : Brand
    {

        public override string GetDescription()
        {
            return "Brand: VW\nVersion: ";
        }

        public override int GetPrice()
        {
            return 20000;
        }
    }
}
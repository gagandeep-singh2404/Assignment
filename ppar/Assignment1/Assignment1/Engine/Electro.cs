using System;
namespace Assignment1.Engine
{
    public class Electro: EngineClass
    {
        public Electro()
        {
        }

        public override string GetDescription()
        {
            return "Engine: Electro";
        }

        public override int GetPrice()
        {
            return 10000;
        }
    }
}

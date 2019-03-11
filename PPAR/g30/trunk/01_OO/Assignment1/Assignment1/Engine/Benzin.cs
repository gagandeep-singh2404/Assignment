using System;
using Assignment1.Engine;
namespace Assignment1
{
    public class Benzin: EngineClass
    {
        public Benzin()
        {
        }

        public override string GetDescription()
        {
            return "Engine: Benzin";
        }

        public override int GetPrice()
        {
            return 5000;
        }
    }
}

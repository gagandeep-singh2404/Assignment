using System;
namespace Assignment1.Engine
{
    public class Hybrid: EngineClass
    {
        public Hybrid()
        {
        }

        public override string GetDescription()
        {
            return "Engine: Hybrid";
        }

        public override int GetPrice()
        {
            return 7000;
        }
    }
}

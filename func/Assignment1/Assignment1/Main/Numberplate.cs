using System;
namespace Assignment1.Main
{
    public class Numberplate
    {
        private string specificNumberplate;

        public Numberplate(string numberplate)
        {
            specificNumberplate = numberplate;
        }

        public string SpecificNumberplate { get { return specificNumberplate; } }
    }
}

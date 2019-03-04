using System;
using System.Text.RegularExpressions;

namespace Assignment2.Individuals
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class IndividualProperty : Attribute
    {
        public Regex Regex { get; private set; } = null;
        public string RegexString {
            set
            {
                this.Regex = new Regex(value);
            }

            get { return this.Regex.ToString(); }
        }
    }
}

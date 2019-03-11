using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdministrationAssignment.User
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class IndividualProperty : Attribute
    {
        public Regex Regex { get; private set; } = null;
        public string RegexString
        {
            set
            {
                this.Regex = new Regex(value);
            }

            get { return this.Regex.ToString(); }
        }
    }
}
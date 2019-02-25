using System;
using Assignment2.Commands;
using Assignment2.Main;

namespace Assignment2.Individuals
{
   
    [Serializable]
    public abstract class Person
    {
       protected static int currentPerson;
       private AddCommand command = new AddCommand();
      


       
        public int ID { get; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Firstname { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Lastname { get; set; }
        [IndividualProperty(RegexString = StaticData.EMAILREGEX)] public string Email { get; set; }
        [IndividualProperty(RegexString =StaticData.ONLYCHARS)] public string Nationality { get; set; } = "";

        public Person()
        {
            this.ID = ++ currentPerson;
        }

    }
}

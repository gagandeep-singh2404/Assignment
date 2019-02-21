using System;
namespace Assignment2.Individuals
{
   
    public abstract class Person
    {
       protected static int currentPerson;
        [IndividualProperty] public int ID { get; }
        [IndividualProperty] public string Firstname { get; set; } = "";
        [IndividualProperty] public string Lastname { get; set; } = "";
        [IndividualProperty] public string Email { get; set; } = "";
        [IndividualProperty] public string Nationality { get; set; } = "";

        public Person()
        {
            this.ID = ++ currentPerson;
        }

    }
}

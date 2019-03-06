using System;
using NewAssignment2.Main;

namespace NewAssignment2.Individuals
{
    public class Person
    {

        public static int counter = 0;


        public int ID { get; private set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Firstname { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Lastname { get; set; }
        [IndividualProperty(RegexString = StaticData.EMAILREGEX)] public string Email { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Nationality { get; set; }



        public Person()
        {
            ID = ++counter;
        }
    }
}
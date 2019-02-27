using System;
using Assignment2.Main;

namespace Assignment2.Individuals
{
    public class Staff:Person
    {
        [IndividualProperty(RegexString = StaticData.ONLYNUMBER)] public string WorkHours { get; set; }
    }
}

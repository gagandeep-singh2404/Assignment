using System;
using NewAssignment2.Main;

namespace NewAssignment2.Individuals
{
    public class Lecturer : Person
    {
        [IndividualProperty(RegexString = StaticData.ONLYNUMBER)] public string Phonenumber { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string LecturersAbbreviation { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYNUMBER)] public string DateStarted { get; set; }

    }
}

using System;
using System.Xml.Serialization;
using NewAssignment2.Main;

namespace NewAssignment2.Individuals
{
    [Serializable]
    public class Lecturer : Person
    {
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Phonenumber { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string LecturersAbbreviation { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string DateStarted { get; set; }

    }
}

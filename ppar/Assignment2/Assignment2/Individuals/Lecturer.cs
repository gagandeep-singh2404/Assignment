using System;
using Assignment2.Main;

namespace Assignment2.Individuals
{
    public class Lecturer:Person
    {
      [IndividualProperty(RegexString = StaticData.ONLYNUMBER)] public string Phonenumber { get; set; }
      [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string LecturersAbbreviation  { get; set; }
      [IndividualProperty(RegexString = StaticData.ONLYNUMBER)] public string DateStarted  { get; set; }

    }
}

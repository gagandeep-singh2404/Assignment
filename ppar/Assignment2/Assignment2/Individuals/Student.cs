using System;
using Assignment2.Main;

namespace Assignment2.Individuals
{
    public class Student:Person
    {
       [IndividualProperty(RegexString =StaticData.ONLYCHARS)] public string StudyProgram { get; set; }
       [IndividualProperty(RegexString =StaticData.ONLYCHARS)] public string Cohort { get; set; }
       [IndividualProperty(RegexString =StaticData.ONLYCHARS)] public string Class { get; set; }

    }
}

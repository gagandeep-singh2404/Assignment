using System;
namespace Assignment2.Individuals
{
    public class Student
    {
       [IndividualProperty] public string StudyProgram { get; set; }
       [IndividualProperty] public string Cohort { get; set; }
       [IndividualProperty] public string Class { get; set; }

    }
}

using System;
namespace Assignment2.Individuals
{
    public class Lecturer
    {
      [IndividualProperty] public string Phonenumber { get; set; }
      [IndividualProperty] public string LecturersAbbreviation  { get; set; }
      [IndividualProperty] public DateTime DateStarted  { get; set; }

    }
}

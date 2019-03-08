using System;
using System.Xml.Serialization;
using NewAssignment2.Main;

namespace NewAssignment2.Individuals
{
    [Serializable]
    public class Student : Person
    {
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string StudyProgram { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Cohort { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Class { get; set; }


         public override string ToString(){ 
            return base.ToString() + "Study Programm: "+StudyProgram+", Cohort: "+ Cohort+", Class "+ Class+ "\n---------------------------------------------\n\n";
        }
    }
}

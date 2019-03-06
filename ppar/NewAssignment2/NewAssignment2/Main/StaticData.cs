using System;
namespace NewAssignment2.Main
{
    public static class StaticData
    {
        public const string FILE = "../Data/UserFile.xml";
        public const string EMAILREGEX = @"^([\w\.-]+)@fontys.nl\b";  // muss das noch machen
        public const string DATEREGEX = @"^([\w\.-]+)@(\bstudent|lecture)\b.fontys.nl\b"; // noch verbesserst
        public const string ONLYNUMBER = @"^\d{1,20}+$";
        public const string ONLYCHARS = @"^[a-zA-Z]+$";
    }
}

using System;
namespace NewAssignment2.Main
{
    public static class StaticData
    {
        public const string FILE = "./Data/UserFile.xml";
        public const string EMAILREGEX = @"^([\w\.-]+)@fontys.nl\b";  
        public const string DATEREGEX = @"^\s*(3[01]|[12][0-9]|0?[1-9])\-(1[012]|0?[1-9])\-((?:19|20)\d{2})\s*$"; 
        public const string ONLYNUMBER = @"^[0-9]*$";
        public const string ONLYCHARS = @"^[a-zA-Z]+$";
    }
}

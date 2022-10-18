using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }
        public string DateString
        {
            get => OtherInfo.Substring(OtherInfo.Length - 10);
        }
        public DateTime DateValue 
        {
            get => DateTime.Parse(OtherInfo);
        }
    }
}

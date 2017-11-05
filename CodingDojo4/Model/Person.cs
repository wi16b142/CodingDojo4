using System;

namespace CodingDojo4.Model
{
    class Person
    {
        public Person()
        {
            this.socialSecurityNumber = 0;
            this.lastName = "";
            this.firstName = "";
            this.birthdate = new DateTime(1900, 01, 01);
        }
        public Person(int socialSecurityNumber, string lastName, string firstName, DateTime date)
        {
            this.socialSecurityNumber = socialSecurityNumber;
            this.lastName = lastName;
            this.firstName = firstName;
            this.birthdate = date;
        }
        public int socialSecurityNumber { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime birthdate { get; set; }
    }
}

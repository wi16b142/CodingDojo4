using CodingDojo4.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo4.ViewModel
{
    public class PersonViewModel : ViewModelBase
    {
        private Person person;
        public PersonViewModel(int socialSecurityNumber, string lastName, string firstName, DateTime birthdate)
        {
            this.person = new Person(socialSecurityNumber, lastName, firstName, birthdate);
        }
        
        public string FirstName
        {
            get => person.firstName;
            set
            {
                person.firstName = value;
                RaisePropertyChanged();
            }
        }

        public string LastName
        {
            get => person.lastName;
            set
            {
                person.lastName = value;
                RaisePropertyChanged();
            }
        }

        public DateTime Birthdate
        {
            get => person.birthdate;
            set
            {
                person.birthdate = value;
                RaisePropertyChanged();
            }
        }

        public int SocialSecurityNumber
        {
            get => person.socialSecurityNumber;
            set
            {
                person.socialSecurityNumber = value;
                RaisePropertyChanged();
            }
        }
        
    }
}

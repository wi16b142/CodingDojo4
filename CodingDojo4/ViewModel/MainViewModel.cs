using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using CodingDojo4.Model;
using System;
using GalaSoft.MvvmLight.CommandWpf;

namespace CodingDojo4.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<PersonViewModel> entry = new ObservableCollection<PersonViewModel>();
        
        private string lastname = "";
        private string firstname = "";
        private DateTime birthdate = DateTime.Today;
        private int socialSecurityNumber = 0;
        public RelayCommand btnAddClick;
        public RelayCommand btnLoadClick;
        public RelayCommand btnSaveClick;
        private RelayCommand fetchData;

        public MainViewModel()
        {
            BtnAddClick = new RelayCommand(AddPerson, ()=> { if (Lastname.Length > 2) { return true; } else { return false; } });
            BtnLoadClick = new RelayCommand(LoadData, CanExecuteLoadData);
            BtnSaveClick = new RelayCommand(SaveData, ()=> { if (Entry.Count > 0) { return true; } else { return false; } });
            FetchData = new RelayCommand(AddPerson);

            Entry.Add(new PersonViewModel(1234, "Böck", "Sascha", new DateTime(1990,04,29)));
            Entry.Add(new PersonViewModel(5678, "Maier", "Hermann", new DateTime(1997, 12, 12)));
            Entry.Add(new PersonViewModel(1897, "Stark", "Ned", new DateTime(1980, 02, 01)));
        }

        public ObservableCollection<PersonViewModel> Entry
        {
            get { return entry; }
            set { entry = value; }
        }

        public RelayCommand BtnAddClick
        {
            get { return btnAddClick; }
            set { btnAddClick = value; }
        }
        public RelayCommand BtnLoadClick
        {
            get { return btnLoadClick; }
            set { btnLoadClick = value; }
        }

        public RelayCommand BtnSaveClick
        {
            get { return btnSaveClick; }
            set { btnSaveClick = value; }
        }

        public RelayCommand FetchData
        {
            get { return fetchData; }
            set { fetchData = value; }
        }

        public int SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber = value; RaisePropertyChanged(); }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; RaisePropertyChanged(); }
        }

        public  string Firstname
        {
            get { return firstname; }
            set { firstname = value; RaisePropertyChanged(); }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; RaisePropertyChanged(); }
        }

        private void AddPerson()
        {
            Entry.Add(new PersonViewModel(SocialSecurityNumber, Lastname, Firstname, Birthdate));
            Firstname = "";
            Lastname = "";
            SocialSecurityNumber = 0;
            Birthdate = DateTime.Today;    
        }

        private bool CanExecuteLoadData()
        {
            //check if file exists
            return false;
        }

        private void LoadData()
        {
            //load Data from csv
            //for each row, fetchData
        }

        public void SaveData()
        {
            //save Data as csv
            Firstname = "Sascha";
        }

    }
}
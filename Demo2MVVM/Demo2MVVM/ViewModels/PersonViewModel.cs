using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo2MVVM.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {

        #region Properties
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged();
                }
            }
        }

        string firstLastName;
        public string FirstLastName
        {
            get { return firstLastName; }
            set
            {
                if (firstLastName != value)
                {
                    firstLastName = value;
                    OnPropertyChanged();
                }
            }
        }

        string secondLastName;
        public string SecondLastName
        {
            get { return secondLastName; }
            set
            {
                if (secondLastName != value)
                {
                    secondLastName = value;
                    OnPropertyChanged();
                }
            }
        }


        string fullName;
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    OnPropertyChanged();
                }
            }
        }


        int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Comandos 
        public ICommand Save { protected set; get; }        
        #endregion

        public PersonViewModel()
        {

            Save = new Command(() =>
            {
                //Business logic=>Ins Database
                //Business logic=>Call API
            });


        }



    }
}

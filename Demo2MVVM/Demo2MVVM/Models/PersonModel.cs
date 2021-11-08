using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2MVVM.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FirstLastName { get; set; }        
        public string SecondLastName { get; set; }

        public DateTime DateOfBirthday { get; set; }

    }
}

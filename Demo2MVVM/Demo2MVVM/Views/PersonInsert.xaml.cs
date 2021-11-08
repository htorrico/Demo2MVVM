using Demo2MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo2MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonInsert : ContentPage
    {
        public PersonInsert()
        {
            InitializeComponent();
            this.BindingContext = new PersonViewModel();
        }
    }
}
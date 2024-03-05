using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module2_Exercise01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoBindingContext : ContentPage
    {
        public NoBindingContext()
        {
            InitializeComponent();
        }
        private async void OnBackToMainPage(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }
    }
}
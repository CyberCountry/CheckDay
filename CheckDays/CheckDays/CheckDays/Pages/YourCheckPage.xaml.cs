using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckDays.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YourCheckPage : ContentPage
    {
        public YourCheckPage()
        {
            InitializeComponent();
        }
        private async void BackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
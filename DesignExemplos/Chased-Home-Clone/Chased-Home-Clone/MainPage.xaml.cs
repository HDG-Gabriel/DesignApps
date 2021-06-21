using ChasedHomeClone.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chased_Home_Clone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtbLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());
        }
    }
}

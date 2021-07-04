using System;
using System.Collections.ObjectModel;
using Covid19App.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CasesPage : ContentPage
    {
        public ObservableCollection<CovidCase> Cases { get; }

        public CasesPage()
        {
            InitializeComponent();
            Cases = new ObservableCollection<CovidCase>()
            {
                new CovidCase("Brazil")    { ConfirmedCases = 50623, TotalRecovered = 10630, TotalDeaths = 1204},
                new CovidCase("Japan")     { ConfirmedCases = 1086, TotalRecovered = 235, TotalDeaths = 40},
                new CovidCase("Singapure") { ConfirmedCases = 456, TotalRecovered = 144, TotalDeaths = 10},
                new CovidCase("Nepal")     { ConfirmedCases = 1452, TotalDeaths = 230, TotalRecovered = 740},
                new CovidCase("Mexico")    { ConfirmedCases = 1000, TotalDeaths = 123, TotalRecovered = 700}
            };

            BindingContext = this;
        }
    }
}
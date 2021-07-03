namespace Covid19App.Data
{
    public class CovidCase
    {
        public string Country { get; private set; }
        public int ConfirmedCases { get; set; }
        public int TotalRecovered { get; set; }
        public int TotalDeaths { get; set; }

        public CovidCase(string country) => Country = country;
    }
}

public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateStandardDetails() + $"\nEvent Type: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}
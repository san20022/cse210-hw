using System;

class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string weatherForecast
    ) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering - {_weatherForecast}";
    }
}

using System;
public class OutdoorGatherings : Event
{
    private string _weatherStatement = "";
    public OutdoorGatherings(string eventTitle, string eventDesc, string eventDate, string eventTime, string streetAddress, string city, string state_Province, string zipCode, string country, string eventType, string details) : base(eventTitle, eventDesc, eventDate, eventTime, streetAddress, city, state_Province, zipCode, Country);
    {
        SetEventType(eventType);
        SetWeatherStatement(details);
        SetFullDetails(_weatherStatement);
    }
    public void SetWeatherStatement(string weatherStatement)
    {
        _weatherStatement = weatherStatement;
    }
}
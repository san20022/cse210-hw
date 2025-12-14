using System;
public class Reception : Event
{
    private string _rsvp = "";
    public Reception(string eventTitle, string eventDesc, string eventDate, string eventTime, string streetAddress, string city, string state_Province, string zipCode, string country, string details, string evenType, string resvp) : base(eventTitle, eventDesc, eventDate, eventTime, streetAddress, city, state_Province, zipCode, country)
    {
        SetEventType(evenType);
        SetRSVP(rsvp);
        string detailString = SetDetailsString(details, rsvp);
        SetFullDetails(detailString);
    }
    public void SetRSVP(string rsvp)
    {
        _rsvp = resvp;
    }
    public string SetDetailsString(string details, string rsvp)
    {
        _return $"\n{details}\n{rsvp}.";
    }
}
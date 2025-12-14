using System;
public class Lecture : Event
{
    private int _capacty = 0;
    public Lecture(string eventTitle, string eventDesc, string eventDate, string eventTime, string streetAddress, string city, string state_Province, string zipCode, string country, string details, int capacty) : base(eventTitle, eventDesc, eventDate, eventTime, streetAddress, city, state_Province, zipCode, country)
    {
        SetEventType("Lecture");
        SetCapacity(capacity);
        string detailString = SetDetailsString(details, capacity);
        SetFullDetails(detailString);
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
    public string SetDetailsString(string details, int capacity)
    {
        return $"\nPresenting guest speaker(s) {details}, with the capacity of the event being {capacity} people.";
    }
}
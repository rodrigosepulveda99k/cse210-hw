public class Event
{
    protected string title;
    protected string description;
    protected DateTime date;
    protected TimeSpan time;
    protected Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GenerateStandardDetails()
    {
        return $"Event Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}";
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}

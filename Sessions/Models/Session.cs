namespace Sessions.Model
{
    public class Session
    {
        public string Date { get; }
        public string Time { get; }

        public Session(string date, string time)
        {
            Date = date;
            Time = time;
        }
    }
}

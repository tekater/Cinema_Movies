namespace Sessions.Model
{
    public class Movie
    {
        public string Name { get; }
        public string Director { get; }
        public string Style { get; }
        public string Descriptions { get; }
        public Movie(string name, string dir, string style, string desc)
        {
            Name = name;
            Director = dir;
            Style = style;
            Descriptions = desc;
        }
    }
}

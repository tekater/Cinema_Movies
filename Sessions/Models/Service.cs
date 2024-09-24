using Sessions.Model;

namespace Sessions.Model
{
    
    public class Service
    {
        static readonly Movie Cinema1 = new Movie("Venom2", "Andy Serkis", "Fantasy", "American superhero film featuring the Marvel Comics character Venom.");
        static readonly Movie Movie2 = new Movie("SpiderMan3", "Sam Raimi", "Fantasy", "Spider-Man 3 is a 2007 American superhero film based on the Marvel Comics");
        static readonly Movie Movie3 = new Movie("Darkman", "Sam Raimi", "Fantasy", "Darkman is a 1990 American superhero film[5] directed and co-written by Sam Raimi.");
        static readonly IDictionary<string, Movie> MovieList = new Dictionary<string, Movie>
               {
                   {Cinema1.Name, Cinema1},
                   {Movie2.Name, Movie2},
                   {Movie3.Name, Movie3}
               };
        public readonly IDictionary<string, List<Session>> SessionList = new Dictionary<string, List<Session>>
               {
                   {Cinema1.Name, new List<Session>{new Session("33.23.2332", "25:00"), new Session("34.45.2654", "32:00")}},
                   {Movie2.Name, new List<Session>{new Session("32.14.2222", "26:00"), new Session("12.12.2212", "15:00")}},
                   {Movie3.Name, new List<Session>{new Session("24.08.1990", "27:00"), new Session("24.08.1990", "63:00") }}
               };

        public Movie GetMovie(string name)
        {
            MovieList.TryGetValue(name, out Movie movie);
            return movie;
        }

        public void AddMovie(string name, string director, string style, string description)
        {
            Movie movie = new Movie(name, director, style, description);
            MovieList.Add(movie.Name, movie);
        }
        public void DelMovie(string movie_name) 
        { 
            MovieList.Remove(movie_name);
            DelSession(movie_name);
        }

        public void AddSession(string movie_name, string date, string time)
        {
            if (MovieList.ContainsKey(movie_name))
            { 
                if(SessionList.ContainsKey(movie_name))
                {
                    SessionList[movie_name].Add(new Session(date, time));
                }

                SessionList.Add
                    (
                    movie_name, 
                    new List<Session> 
                { 
                    new Session(date, time) 
                }
                );
            }    
        }
        public void DelSession(string movie_name)
        {
            if (SessionList.ContainsKey(movie_name))
            {
                SessionList.Remove(movie_name);            
            }
        }
    }
}

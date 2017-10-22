namespace beerAPI.Models
{
    public class Beer
    {
        public int Id {get; set;}
        public string Name{get; set;}
        public string Brewery{get; set;}
        public string CountryOfOrigin{get; set;}
        public float Rating{get; set;}
        public string Type{get; set;}
    }
}
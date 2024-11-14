namespace APItest.Models.Movie
{
    public class CreateMovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class CreateMovieRequestModel
    {
        public List<CreateMovieRequestModel> Movies { get; set; } = new List<CreateMovieRequestModel>();

    }

    public class CreateMovieResponseModel 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}


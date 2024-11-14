namespace APItest.Models.Movie
{
    public class GetMovieModel
    {   
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class GetMovieRequestModel
    {
        public string Title { get; set; }
        
    }

    public class GetMovieResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class GetMovieListResponseModel
    {
        public List<GetMovieRequestModel> Movies { get; set; } = new List<GetMovieRequestModel>();
    }
}

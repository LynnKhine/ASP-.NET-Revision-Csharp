using System.ComponentModel.DataAnnotations.Schema;

namespace APItest.Entities;

[Table("Movie")]
public class MovieEntity 
{
    [Column("Id")]
    public int Id { get; set; }

    [Column("Title")]
    public string Title { get; set; }

    [Column("Genre")]
    public string Genre { get; set; }

    [Column("ReleaseDate")]
    public DateTime ReleaseDate { get; set; }
}
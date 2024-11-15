using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APItest.Entities
{
    [Table("Student")]
    public class StudentEntity
    {
        [Column("Id")]
        public string Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("IdNumber")]
        public string IdNumber { get; set; }

        [Column("Phone")]
        public string? Phone { get; set; }

        [Column("Email")]
        public string? Email { get; set; }

        [Column("Address")]
        public string? Address { get; set; }

        [Column("CreatedUserId")]
        public string CreatedUserId { get; set; }

        [Column("CreatedDateTime")]
        public DateTime CreatedDateTime { get; set; }

        [Column("UpdatedUserId")]
        public string UpdatedUserId { get; set; }

        [Column("UpdatedDateTime")]
        public DateTime UpdatedDateTime { get; set; }
    }

}

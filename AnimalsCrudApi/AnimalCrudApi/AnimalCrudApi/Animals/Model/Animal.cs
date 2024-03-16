using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalCrudApi.Animals.Model
{
    [Table("animals")]
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("full_name")]
        public string FullName { get; set; }
        [Required]
        [Column("gendre")]
        public string Gendre { get; set; }
        [Required]
        [Column("age")]
        public Int32 Age { get; set; }
    }
}

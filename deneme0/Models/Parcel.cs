using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme0.Models
{
    public class Parcel
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string il { get; set; }
        public string ilce { get; set; } 
        public string wkt { get; set; } 
    }
}

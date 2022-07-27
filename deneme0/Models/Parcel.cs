using System.ComponentModel.DataAnnotations;

namespace deneme0.Models
{
    public class Parcel
    {
        [Key]
        public int Id { get; set; }
        public string il { get; set; }
        public string ilce { get; set; } 
        public string wkt { get; set; } 
    }
}

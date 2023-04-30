using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace exam_30042023.Data.Models
{
    public class Event
    {
        //public Event()
        //{
        //    Users = new List<User>();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Event name cannot be shorter than 2 symbols and longer than 64")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(255, MinimumLength = 10, ErrorMessage = "Event description cannot be shorter than 10 symbol and longer than 255")]
        public string Description { get; set; }
        
        [Required]
        public DateTime PremiereDate { get; set; }

        public string Photo { get; set; }

        public string GetCatImage()
        {
            if (!string.IsNullOrEmpty(Photo))
            {
                return Photo;
            }
            else
            {
                return "https://cdn.pixabay.com/photo/2017/07/21/23/57/concert-2527495__480.jpg";
            }
        }
    }
}

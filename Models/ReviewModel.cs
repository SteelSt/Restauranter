using System;
using System.ComponentModel.DataAnnotations;

namespace Restauranter.Models
{
    public class Review
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name="Reviewer Name:")]
        public string ReviewerName { get; set; }

        [Required]
        [Display(Name="Restaurant Name:")]
        public string RestaurantName { get; set; }

        [Required]
        [MinLength(10)]
        [Display(Name="Review:")]
        public string UserReview { get; set; }

        [Required]
        [Display(Name="Stars:")]
        public int Rating { get; set; }

        [Required]
        [Display(Name="Date of Visit:")]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
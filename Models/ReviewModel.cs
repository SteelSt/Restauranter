using System;
using System.ComponentModel.DataAnnotations;

namespace Restauranter.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ReviewerName { get; set; }
        public string RestaurantName { get; set; }
        public string UserReview { get; set; }
        public int Rating { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReviewDate { get; set; }
    }
}
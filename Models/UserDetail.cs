using System.ComponentModel.DataAnnotations;

namespace WhatTheHecksForDinner.Models
{
    public class UserDetail {
        public Guid ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int TotalMealscooked { get; set; } = 0;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastLogin { get; set; }
    }

}
using System;
using System.ComponentModel.DataAnnotations;

namespace cinemapandas4.Models
{
    public class LoginUser
    {
        [Required (ErrorMessage="Email is required")]
        [EmailAddress (ErrorMessage="Please enter a valid email address")]
        public string LoginEmail { get; set; }

        [Required (ErrorMessage="Password is required")]
        [MinLength(4, ErrorMessage="Password must be at least 4 characters or longer")]
        [DataType("Password")]
        public string LoginPassword { get; set; }
    }
}

namespace MVCRegistration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class User
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Provide username", AllowEmptyStrings =false)]
        public string Username { get; set; }
        [Required(ErrorMessage ="Please Provide password", AllowEmptyStrings =false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50,MinimumLength =8, ErrorMessage = "Password must be 8 char long")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Confirm password does not match.")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Please provide full name.", AllowEmptyStrings = false)]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please provide a Email.", AllowEmptyStrings = false)]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
            ErrorMessage ="Please provide valid email address")]
        public string EmailID { get; set; }
    }
}

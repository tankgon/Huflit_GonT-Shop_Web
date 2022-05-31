using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ictshop.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "Email")]
        [StringLength(10)]
        public string userMail { get; set; }


        [Display(Name = "Password")]
        [StringLength(6)]
        public string password { get; set; }
    }
}
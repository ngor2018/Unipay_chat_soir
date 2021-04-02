using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Unipay_chat_soir.Models
{
    public class Compte
    {
        [Display(Name = "Login")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le login est obligatoire !")]
        public string login { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " Mot de passe obligatoire")]
        public string password { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestHellerová.Pages
{
    public class RegisterModel : PageModel
    {
        [Required (ErrorMessage = "Jméno musí být vyplněno!")]
        [Display(Name = " Jmeno ")]
        public string Jmeno { get; set; }

        [Required(ErrorMessage = "Email musí být vyplněn!")]
        [Display(Name = " JEmail ")]
        public string Email { get; set; }
        public void OnGet()
        {
        }
    }
}

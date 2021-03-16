using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestHellerová.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Jméno musí být vyplněno!")]
        [Display(Name = "Jméno")]
        public string Jmeno { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email musí být vyplněn!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [BindProperty]
        [Display(Name = "Počet odměn ")]
        public int Odmeny { get; set; } 

        [BindProperty]
        [Required(ErrorMessage = "Vypňte heslo!")]
        [Display(Name = "Heslo")]
        public string Heslo { get; set; } 

        [BindProperty]
        [Required(ErrorMessage = "Vyplňte heslo pro ověření­")]
        [Display(Name = "Heslo znovu")]
        public string Heslo_Znovu { get; set; } 

        [BindProperty]
        [Required(ErrorMessage = "Musíte souhlasit se zpracováním informací!")]
        [Display(Name = "Sohlas se zpracováním informací")]
        public bool Souhlas { get; set; } 

        [Display(Name = "Pobočka")]
        public string Pobocka { get; set; }

        [Required]
        [Display(Name = "Odkud jste se od nás dozvěděli?")]
        public KnowledgeSource Informace { get; set; }
        public List<SelectListItem> Pobocky { get; set; }
        public RegisterModel()
        {
            Pobocky = new List<SelectListItem>
            {
                new SelectListItem {Text = "Liberec"},
                new SelectListItem {Text = "Praha"},
                new SelectListItem {Text = "Plzeň "},
            };
        }
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Odmeny > 3 || Odmeny < 0)
            {
                return Page();
            }
            if (Heslo.Length < 6)
            {
                return Page();
            }
            if (Heslo != Heslo_Znovu)
            {
                return Page();
            }
            return RedirectToPage("Success", new { firstname = Jmeno, email = Email });
        }
    }
    public void OnGet()
    {
    }
}

   

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using PVA_Zápočet.Data;
using PVA_Zápočet.Models;

namespace PVA_Zápočet.Pages.CreditPages
{
    public class FormModel : GenericPageModel
    {
        [BindProperty]
        public Credit Credit { get; set; } = new Credit();
        private readonly ILogger<FormModel> _logger;

        public FormModel(ILogger<FormModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Credit.Created = DateTime.Now;
            _context.Credits.Add(Credit);
            _context.SaveChanges();
            Credit = new Credit();
            ModelState.Clear();
            return Page();
        }

        public void OnGet()
        {

        }


    }
}

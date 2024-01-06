using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PVA_Zápočet.Data;
using PVA_Zápočet.Models;


namespace PVA_Zápočet.Pages.CreditPages
{
    public class OutputModel : GenericPageModel
    {
        public List<Credit> Credits { get; set; } = new List<Credit>();
        public OutputModel(ApplicationDbContext context)
        {
            _context = context;
        }        

        public void OnGet()
        {
            Credits = _context.Credits.ToList(); 
        }
    }
}

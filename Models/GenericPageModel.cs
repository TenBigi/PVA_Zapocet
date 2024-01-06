using Microsoft.AspNetCore.Mvc.RazorPages;
using PVA_Zápočet.Data;

namespace PVA_Zápočet.Models
{
    public class GenericPageModel : PageModel
    {
        internal ApplicationDbContext _context;
        public string Message { get; set; } = string.Empty;
    }
}

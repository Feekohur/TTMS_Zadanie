using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TTMS_Zadanie.Models;

namespace TTMS_Zadanie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<User> workers = new List<User>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            workers.Add(new User());
            workers.Add(new User());
            workers.Add(new User());
            workers.Add(new User());
            workers.Add(new User());
        }
    }
}
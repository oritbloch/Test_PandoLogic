using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Redux;
using System.Data;



namespace WebApplication7.Pages
{
    public class IndexModel : PageModel
    {
        public string sdfsdf = "a";
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
           /* classTestFromDB.ClassConsumeFromDB cl = new classTestFromDB.ClassConsumeFromDB();
            
           var dt= cl.GetData(DateTime.Today.AddDays(-6),DateTime.Today);
            ViewData["dt"] = dt;*/
        }
    }
}
using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sessions.Model;

namespace Sessions.Pages
{
    public class SessionModel : PageModel
    {
        public readonly Service MSS;
        public SessionModel(Service mss) 
        {
            this.MSS = mss;
        }
        public void OnGet() {}

        public IActionResult qAddMovie(string name, string director, string style, string description)
        { 
            MSS.AddMovie(name, director, style, description);
            return Page();
        }
        public IActionResult qDelMovie(string name)
        {
            MSS.DelMovie(name);
            return Page();
        }

        public IActionResult qAddSession(string name, string date, string time)
        {
            MSS.AddSession(name, date, time);
            return Page();
        }
    }
}

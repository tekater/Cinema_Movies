using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sessions.Model;

namespace Sessions.Pages
{
    public class MovieInfoModel : PageModel
    {
        public readonly Service MSS;
        public MovieInfoModel(Service mss)
        {
            this.MSS = mss;
        }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public Movie SelectedMovie { get; set; }
        public IActionResult OnGet()
        {
            SelectedMovie = MSS.GetMovie(Name);
            if (SelectedMovie is null)
                return NotFound();            
            return Page();
        }
    }
}

using WebSite.Models;

namespace WebSite.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            CurrentRequest = new Request();
        }

        public Request CurrentRequest { get; set; }
    }
}

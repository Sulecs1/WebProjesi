using Microsoft.AspNetCore.Mvc;

namespace BlogProjemFront.ViewComponents{
    public class Search : ViewComponent{
        public IViewComponentResult Invoke(string s){
            ViewBag.SearchString=s;
            return View();
        }
    }
}
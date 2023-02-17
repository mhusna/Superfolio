using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Superfolio.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager manager = new ExperienceManager(new EfExperienceRepository());
        
        public IViewComponentResult Invoke()
        {
            var results = manager.TGetList();
            return View(results);
        }
    }
}

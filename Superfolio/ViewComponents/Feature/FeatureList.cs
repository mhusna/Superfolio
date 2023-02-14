using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Superfolio.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager manager = new FeatureManager(new EfFeatureRepository());
        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }
    }
}

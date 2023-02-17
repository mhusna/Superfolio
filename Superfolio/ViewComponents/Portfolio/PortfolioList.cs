using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Superfolio.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager manager = new PortfolioManager(new EfPortfolioRepository());

        public IViewComponentResult Invoke()
        {
            var results = manager.TGetList();
            return View(results);
        }
    }
}

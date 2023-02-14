using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Superfolio.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager manager = new ServiceManager(new EfServiceRepository());

        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }
    }
}

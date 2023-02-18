using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Superfolio.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager manager = new ContactManager(new EfContactRepository());
        public IViewComponentResult Invoke()
        {
            var results = manager.TGetList();
            return View(results[0]);
        }
    }
}

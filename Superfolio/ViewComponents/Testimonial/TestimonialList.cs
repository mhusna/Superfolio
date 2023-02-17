using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Superfolio.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager manager = new TestimonialManager(new EfTestimonialRepository());

        public IViewComponentResult Invoke()
        {
            var results = manager.TGetList();
            return View(results);
        }
    }
}

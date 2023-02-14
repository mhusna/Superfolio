using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Superfolio.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager manager = new SkillManager(new EfSkillRepository());

        public IViewComponentResult Invoke()
        {
            var results = manager.TGetList();
            return View(results);
        }
    }
}

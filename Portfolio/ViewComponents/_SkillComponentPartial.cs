using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

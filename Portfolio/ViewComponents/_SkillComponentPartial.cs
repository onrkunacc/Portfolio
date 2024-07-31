using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        private readonly PortfolioDbContext context;
        public _SkillComponentPartial(PortfolioDbContext dbContext)
        {
            context = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}

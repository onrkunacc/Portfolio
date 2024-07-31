using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        private readonly PortfolioDbContext context;
        public _ExperienceComponentPartial(PortfolioDbContext dbContext)
        {
            context = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}

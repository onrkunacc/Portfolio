using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        private readonly PortfolioDbContext context;
        public _FeatureComponentPartial(PortfolioDbContext dbContext)
        {
            context = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = context.Features.ToList();
            return View(values);
        }
    }
}

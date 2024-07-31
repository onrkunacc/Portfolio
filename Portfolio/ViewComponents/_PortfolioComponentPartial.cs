using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        private readonly PortfolioDbContext context;
        public _PortfolioComponentPartial(PortfolioDbContext dbContext)
        {
            context = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}

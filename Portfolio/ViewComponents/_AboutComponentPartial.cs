using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _AboutComponentPartial :ViewComponent
    {
        private readonly PortfolioDbContext context;
        public _AboutComponentPartial(PortfolioDbContext dbContext)
        {
            context = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = context.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}

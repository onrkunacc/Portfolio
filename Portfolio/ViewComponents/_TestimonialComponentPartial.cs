using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _TestimonialComponentPartial :ViewComponent
    {
        private readonly PortfolioDbContext context;
        public _TestimonialComponentPartial(PortfolioDbContext dbContext)
        {
            context = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}

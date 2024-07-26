using System.ComponentModel.DataAnnotations;

namespace Portfolio.DAL.Entities
{
    public class MyPortfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImgUrl { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}

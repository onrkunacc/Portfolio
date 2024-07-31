using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;
using Portfolio.DAL.Entities;

namespace Portfolio.Controllers
{
    public class MessageController : Controller
	{

		private readonly PortfolioDbContext _dbContext;

        public MessageController(PortfolioDbContext dbContext)
        {
			_dbContext = dbContext;
        }
        public IActionResult Inbox()
		{
			var values = _dbContext.Messages.ToList();
			return View(values);
		}
		[Route("ChangeIsReadToTrue/{id}")]
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = _dbContext.Messages.Find(id);
			value.IsRead = true;
            _dbContext.SaveChanges();
			return RedirectToAction("Inbox");
		}
		[Route("ChangeIsReadToFalse/{id}")]
		public IActionResult ChangeIsReadFalse(int id)
		{
			var value = _dbContext.Messages.Find(id);
			value.IsRead = false;
            _dbContext.SaveChanges();
			return RedirectToAction("Inbox");

		}
		[HttpGet]
		public IActionResult DeleteMessage(int id)
		{
			var value = _dbContext.Messages.Find(id);
            _dbContext.Messages.Remove(value);
            _dbContext.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult MessageDetail (int id)
		{
			var value = _dbContext.Messages.Find(id);
			return View(value);
		}

		[HttpPost]
		[Route("Message/SubmitMessage")]
		public async Task<IActionResult> SubmitMessage(Message message)
		{
			if (ModelState.IsValid)
			{
				message.SendDate = DateTime.Now;
				_dbContext.Messages.Add(message);
				await _dbContext.SaveChangesAsync();
				return Json(new { success = true });
			}
			return Json(new { success = false });
		}
	}
}

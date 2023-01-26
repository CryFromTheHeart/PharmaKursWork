using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PharmaKursWork.Models;
using PharmaKursWork.Servises;
using PharmaKursWork.ViewModels.ChallengerViewModels;

namespace PharmaKursWork.Controllers
{
    public class ChallengerController : Controller
    {
        private readonly DataContext _db;
        private readonly UserServise _userServise;
        public ChallengerController(DataContext db, UserServise userService)
        {
            _db = db;
            _userServise = userService;
        }
        public IActionResult Index()
        {
            var user = _userServise.getCurrentUser();


            if (user == null || user.Username == "Guest")
            {
                return RedirectToAction("Index", "Account");
            }

            var challenges = (from c in _db.Challenges
                              select c);

            var model = new ChallengerViewModel
            {
                ChallengeSelectList = new SelectList(challenges, "Id", "Name"),
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddChallenger(ChallengerViewModel model)
        {
            var data = model.ChallengerModel;

            var challenger = new Challenger
            {
                Id = data.Id,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Contraindications = data.Contraindications,
                ChallengeId = data.ChallengeId,
            };

            await _db.Challengers.AddAsync(challenger);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

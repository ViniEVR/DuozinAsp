using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Duozin.Repositories.interfaces;
using Duozin.Models;
using Duozin.Data;



namespace Duozin.Controllers
{
    public class DuozinController : Controller
    {


        private readonly IMidRepository? _midRepository;
        private readonly IDuozinRepository? _duozinRepository;
        

        public DuozinController(IMidRepository midRepository, IDuozinRepository duozinRepository)
        {
            _midRepository = midRepository;
            _duozinRepository = duozinRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Personagens()
        {
            var mids = _midRepository.GetMidList();
            return View(mids);
        }

        [HttpPost]
        public IActionResult StartDuozin(IFormCollection mids)
        {
            List<MidModel> checkedMids = _midRepository.GetMidsId(mids);

            List<MidModel> orderByAgeMids = _duozinRepository.OrderByAge(checkedMids);
            var winner = _duozinRepository.GetWinnerDuozin(orderByAgeMids);

            return View("Winner", winner);
        }
         
        public IActionResult Winner(int id)
        {
            return View();
        }
    }
}
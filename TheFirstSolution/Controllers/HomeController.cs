using System.Web.Mvc;
using AppServices.Interfaces;

namespace TheFirstSolution.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserInfoService _userInfoService;

        public HomeController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        public ActionResult Index()
        {
            var userInfo = _userInfoService.GetAll();

            return View(userInfo);
        }
    }
}

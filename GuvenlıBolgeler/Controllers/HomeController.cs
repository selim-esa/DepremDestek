using Data;
using Data.Repository;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace IhtiyacListesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private readonly UserRepository userRepository;

        User user = new User();
        public HomeController(DataContext context)
        {
            _context = context;
            userRepository = new UserRepository(_context);
        }
        [HttpGet]
        public IActionResult Index()
        {
            var users = _context.users.ToList();
            return View(users);
        }
        [HttpGet]
        public IActionResult Enkaz()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Enkaz(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();

            return View(user);
        }
        //Gida ihyiyacı
        [HttpGet]
        public IActionResult Gida()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Gida(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();

            return View(user);
            
        }
        //Diger ihtiyac
        [HttpGet]
        public IActionResult Diger()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Diger(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();

            return View(user);
        }
        //bagıs sayfası

       [HttpGet]
        public IActionResult Bagis()
        {
            return View();
        }


    }
}

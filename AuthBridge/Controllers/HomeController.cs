using AuthBridge.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AuthBridge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/kah")]
        public IActionResult Index()
        {
            // TODO: show MAS login page with button
            return View();
        }

        [HttpGet("/kah/auth/oidc/callback")]
        public IActionResult OIDCCallback()
        {
            // TODO: Handle Toppan authentication callback [CHUAN]
            // On Failure: redirect to error page
            // On Success: process sending get user info request

            // TODO: Send UserToken to get User Info [CHUAN]
            // On Failure: redirect to error page
            // On Success: process verify role

            // TODO: Verify authorization role [THIN]
            // On Failure: redirect to error page
            // On Success: process check existing user

            // TODO: Check existing user using NRIC FIN [THIN]
            // On Existed: generate user session (KAH session)
            // On Not Existed: process get user email

                // TODO: Send get user email request [THIN]
                // On Failure: retry 3 times => then follow On Success flow
                // On Success: process create/update user => generate user session

            // TODO: Create/update user [CHUAN]

            // TODO: Generate user session

            // TODO: Generate wsfed token???

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

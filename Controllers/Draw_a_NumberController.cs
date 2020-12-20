using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace White_Elephant.Controllers
{
    public class Draw_a_NumberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChooseOrnament()
        {
            return null;
        }
    }
}
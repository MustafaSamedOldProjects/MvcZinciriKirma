using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index2(tarih tarih)
        {
            var guncce = new List<DateTime>();
            var günFark =(tarih.Bitis - tarih.Baslangıc).Days+1;
            for (var i = tarih.Baslangıc; i < tarih.Bitis;i = i.AddDays(1))
            {
                guncce.Add(i);
            }
            var ustLoop = günFark / 15;
            var günce = tarih.Baslangıc;
            var onbesligunler = new List<DateTime>();
            var temp1 = tarih.Baslangıc;
            var brak = new List<int>();
            for (var i = 0; i < 365; i++)
            {
                if (i% 30 == 0)
                {
                    brak.Add(i);
                }
                onbesligunler.Add(temp1);
                temp1= temp1.AddDays(15);
            }
            var temp = new Looping() {
                BaslangicTarihi = tarih.Baslangıc,
                BitisTarihi = tarih.Bitis,
                onbesligunler = onbesligunler,
                günce = guncce,
                günFark = günFark,
                ustLoop = ustLoop,
                Brak = brak
            };
            return View(temp);
        }

        
    }
}

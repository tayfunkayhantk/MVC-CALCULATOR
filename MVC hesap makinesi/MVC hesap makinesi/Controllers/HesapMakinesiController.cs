using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_hesap_makinesi.Controllers
{
    public class HesapMakinesiController : Controller
    {
        // GET: HesapMakinesi
        
           public ActionResult HesapMakinesi(int sayi1 = 0, int sayi2 = 0, string islem123 = "+")
        {
            int sonuc = 0;
            switch (islem123)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
            }

            ViewBag.snc = sonuc;
            return View();
        }
    }
}
using System;
using Microsoft.AspNetCore.Mvc;


namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Random random = new Random();

        //The Conroller to receive the Luck number from the Route
        public IActionResult Index(int luck = 7) //Default value for luck is 7
        {
            LuckySpin.Model.spinController spin = new LuckySpin.Model.spinController();
            spin.ValA = random.Next(1, 10);
            spin.ValB = random.Next(1, 10);
            spin.ValC = random.Next(1, 10);
            spin.Luck = 7;

           

            // Load up the ViewBag for use by the Spinner View "Index.cshtml"
            spin.ImgDisplay = (spin.ValA == luck || spin.ValB == luck || spin.ValC == luck)?"block":"none";
            
            ViewBag.luck = luck;
            
            return View(spin);
            
        }
    }
}
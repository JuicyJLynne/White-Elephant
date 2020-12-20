using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using White_Elephant.Models;

namespace White_Elephant.Controllers
{
    public class PlayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Current Player Actions

        //First Player


        static void ChooseNoSteal()
        {
            //Player chooses gift 

        }


        public void OpenGift()
        {
            //Remove Wrapping Paper
            //Display Gift
            //Set is open to true
        }

        public void RemoveWrappingPaper(int? GiftID)
        {
            //Remove Wrap Image
        }
        public void DisplayGift(int? GiftID)
        {
            //Show gift image
            //Show gift Description
        }

        public void PutGiftOnTable(int GiftID)
        {
            //Set button image to picture of gift
        }


    }
}
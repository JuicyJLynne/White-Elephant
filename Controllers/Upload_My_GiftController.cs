namespace White_Elephant.Controllers
{
    public class Upload_My_GiftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UploadGift()
        {
            return null;
        }

        public void Submit(string description)
        {
            using (var db = ApplicationDbContext())
            {
                var gift = new Gift { GiftDescription = description };
                db.Gifts.Add(gift);
                db.SaveChanges();

            }
               
        }

    }

}
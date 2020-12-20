using White_Elephant.Services;
using Microsoft.EntityFrameworkCore;

namespace White_Elephant.Models
{
    public class Gift : IGift
    {
        public int GiftID { get; set; }

        public string GiftDescription { get; set; }

        public string GiftImageAddress { get; set; }

        public string GiftWrapImageID { get; set; }

        public bool OpenStatus { get; set; }

        public int AssignedPlayerID { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace White_Elephant.Models
{
    public class GiftDetails
    {
        public string GiftID { get; set; }

        public string GiftDescription { get; set; }

        public string GiftImageAddress { get; set; }

        public string GiftWrapImageID { get; set; }

        public bool OpenStatus { get; set; }

        public int AssignedPlayerID { get; set; }

    }
}

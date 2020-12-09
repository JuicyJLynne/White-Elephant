using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace White_Elephant.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        public string Name { get; set; }

        public int RoundAssignment { get; set; }

        public int AssignedGiftID { get; set; }
        //Starts as 0 for all

    }
}

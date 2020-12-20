﻿using Microsoft.EntityFrameworkCore;

namespace White_Elephant.Models
{
    public class Ornament
    {
        public int RoundAssignment { get; set; }

        public string OrnamentImageAddress { get; set; }

        public bool Chosen { get; set; }
        //Set to false by default
    }

}

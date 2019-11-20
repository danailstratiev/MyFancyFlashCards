using System;
using System.Collections.Generic;
using System.Text;

namespace MyFancyFlashcards.Models
{
   public class Purchase
    {
        public int Id { get; set; }

        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public decimal Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFancyFlashcards.Models
{
   public class Flashcard
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Source { get; set; }
    }
}

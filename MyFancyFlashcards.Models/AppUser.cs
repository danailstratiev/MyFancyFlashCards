using System;

namespace MyFancyFlashcards.Models
{
    public class AppUser
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public IEquatable<Flashcard> Flashcards { get; set; }     
    }
}

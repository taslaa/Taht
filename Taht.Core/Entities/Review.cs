﻿namespace Taht.Core
{
    public class Review : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public float ReviewRating { get; set; }
        public string? ReviewComment { get; set; } 
        public bool IsAnonymous { get; set; }
    }
}

﻿using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EFSample1
{
    public class User
    {
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Student Student { get; set; }
    }
}

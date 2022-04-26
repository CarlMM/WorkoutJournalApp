using System;
using System.Collections.Generic;

#nullable disable

namespace WorkoutJournal.Domain.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int RoutineId { get; set; }
        public string Hobby { get; set; }
        public string ProfileImage { get; set; }
    }
}

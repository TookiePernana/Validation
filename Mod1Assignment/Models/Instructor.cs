﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Mod1Assignment.Models
{
    public partial class Instructor
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual Course Course { get; set; }
    }
}

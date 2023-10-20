﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1.Modelss
{
    public partial class Teacher
    {
        public Teacher()
        {
            TCards = new HashSet<TCard>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int IdDep { get; set; }

        public virtual Department IdDepNavigation { get; set; } = null!;
        public virtual ICollection<TCard> TCards { get; set; }
    }
}

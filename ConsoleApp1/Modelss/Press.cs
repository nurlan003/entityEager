﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1.Modelss
{
    public partial class Press
    {
        public Press()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}

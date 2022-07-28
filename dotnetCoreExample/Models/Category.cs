﻿using System;
using System.Collections.Generic;

#nullable disable

namespace dotnetCoreExample.Models
{
    public partial class Category
    {
        public Category()
        {
            FilmCategories = new HashSet<FilmCategory>();
        }

        public byte CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FilmCategory> FilmCategories { get; set; }
    }
}

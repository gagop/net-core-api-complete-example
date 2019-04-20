﻿using System;

namespace CoreEx.Domain.Entities
{
    //Initialize collections and make set private in collections
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

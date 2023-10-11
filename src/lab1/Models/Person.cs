﻿
#nullable disable

namespace PersonRepository
{
    /// <summary>
    /// Запись о человеке
    /// </summary>
    public partial class Person
    {
        public long Id { get; set; }
        public string? Name { get; set; } 
        public string? Address { get; set; }
        public string? Work { get; set; }
        public int? Age { get; set; }
    }
}
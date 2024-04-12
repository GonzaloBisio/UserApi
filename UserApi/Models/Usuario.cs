namespace UserApi.Models
{
    using System;
    public class Usuario
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public DateOnly Birthdate { get; set; } 
        public bool Active { get; set; } 
    }
}
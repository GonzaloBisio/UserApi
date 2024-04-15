namespace UserApi.Models
{
    using System;
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public DateOnly Birthdate { get; set; } 
        public bool Active { get; set; } = true;
    }
}
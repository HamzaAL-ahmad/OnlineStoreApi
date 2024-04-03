﻿namespace OnlineStore.Domain.Entities
{
    public class User : BaseEntity 
    {
        public string FirstName { get; set; }
        public string? MeddileName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Password{ get; set; }
        public string? EmailConfirmed { get; set; }
        public string? PasswordConfirmed { get; set; }
        Location location { get; set; }
        public int UserTypeID { get; set; }
    }
}

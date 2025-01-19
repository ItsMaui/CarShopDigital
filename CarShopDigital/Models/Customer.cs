using System;

namespace CarShopDigital.Models
{
    public class Customer
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }

        public Customer(string fullName, int id, string password)
        {
            FullName = fullName;
            Id = id;
            Password = password;
        }
    }
}
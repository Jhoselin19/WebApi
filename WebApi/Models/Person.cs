﻿using System.Data;

namespace WebApi.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime dateTime { get; set; }
    }
}

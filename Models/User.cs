﻿using FreshBooks.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set;}
    }
}

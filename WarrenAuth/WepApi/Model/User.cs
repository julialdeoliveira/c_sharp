﻿namespace WepApi.Model
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
    }
}

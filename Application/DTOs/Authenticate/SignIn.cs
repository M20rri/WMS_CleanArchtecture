﻿namespace Application.DTOs.Authenticate
{
    public class SignIn
    {
        public int UserId { get; init; }
        public string? Password { get; set; }
    }
}

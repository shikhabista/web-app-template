﻿namespace App.Web.ValueObject;

public class AuthResult
{
    public List<string> Errors = new();
    public bool Success;
}
﻿namespace NoteApp.Shared.Responses;


public class AuthenticationResponse
{

    public string Jwt { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

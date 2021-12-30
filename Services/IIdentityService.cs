﻿using NickWebApi.Domain;
using System.Threading.Tasks;

namespace NickWebApi.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        Task<AuthenticationResult> LoginAsync(string email, string password);
    }
}
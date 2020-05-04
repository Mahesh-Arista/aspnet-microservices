﻿using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface IAccountProxy
    {
        Task<Account> TrySignIn(SignIn request);
        Task<HttpStatusCode> CreateAccount(Account acct);
        Task<HttpStatusCode> UpdateAccount(AccountDetails acct);
        Task<HttpStatusCode> UpdatePassword(UpdatePassword changePassword);
        Task<Account> GetAccountById(string acctId);
    }
}
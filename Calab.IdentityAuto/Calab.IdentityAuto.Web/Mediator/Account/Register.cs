﻿using Calab.IdentityAuto.Web.Infrastructure.Services;
using Calab.IdentityAuto.Web.ViewModels.AccountViewModels;
using Calabonga.AspNetCore.Controllers.Base;
using Calabonga.OperationResults;
using System.Threading;
using System.Threading.Tasks;

namespace Calab.IdentityAuto.Web.Mediator.Account
{
    /// <summary>
    /// Request: Register new account
    /// </summary>
    public class RegisterRequest : RequestBase<OperationResult<UserProfileViewModel>>
    {
        public RegisterViewModel Model { get; }

        public RegisterRequest(RegisterViewModel model)
        {
            Model = model;
        }
    }

    /// <summary>
    /// Response: Register new account
    /// </summary>
    public class RegisterRequestHandler : OperationResultRequestHandlerBase<RegisterRequest, UserProfileViewModel>
    {
        private readonly IAccountService _accountService;

        public RegisterRequestHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public override Task<OperationResult<UserProfileViewModel>> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            return _accountService.RegisterAsync(request.Model);
        }
    }
}
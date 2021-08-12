﻿using Calab.IdentityAuto.Web.ViewModels.LogViewModels;
using Calabonga.AspNetCore.Controllers.Handlers;
using Calabonga.AspNetCore.Controllers.Queries;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Calab.IdentityAuto.Web.Mediator.LogsWritable
{
    /// <summary>
    /// Request: Returns ViewModel for entity Log creation
    /// </summary>
    public class LogCreateViewModelRequest : CreateViewModelQuery<LogCreateViewModel>
    {

    }

    /// <summary>
    /// Response: Returns ViewModel for entity Log creation
    /// </summary>
    public class LogCreateViewModelRequestHandler : CreateViewModelHandlerBase<LogCreateViewModelRequest, LogCreateViewModel>
    {
        protected override ValueTask<LogCreateViewModel> GenerateCreateViewModel()
        {
            return new ValueTask<LogCreateViewModel>(new LogCreateViewModel
            {
                CreatedAt = DateTime.UtcNow,
                Level = LogLevel.Information.ToString(),
                Message = "Generated automatically",
                Logger = "LogCreateViewModelRequestHandler",
                ThreadId = "0"
            });
        }
    }
}

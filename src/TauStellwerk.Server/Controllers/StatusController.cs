﻿// <copyright file="StatusController.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

#nullable enable

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TauStellwerk.Base.Model;
using TauStellwerk.Services;
using TauStellwerk.Util;

namespace TauStellwerk.Controllers
{
    /// <summary>
    /// Controller for the status of the physical dcc output to the track.
    /// </summary>
    [ApiController]
    [Route("status")]
    public class StatusController : Controller
    {
        private readonly StatusService _statusService;

        public StatusController(StatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpGet]
        public async Task<Status> GetChange([FromQuery]bool? lastKnownStatus)
        {
            var longTask = _statusService.WaitForStatusChangeAsync();

            // Ensure that the state didn't change between requests
            var currentStatus = _statusService.CheckStatus();
            if (lastKnownStatus != currentStatus.IsRunning)
            {
                return currentStatus;
            }

            return await longTask;
        }

        [HttpPost]
        public async Task Post([FromBody] Status status)
        {
            // TODO: Take username from Session instead.
            await _statusService.HandleStatusCommand(status.IsRunning, status.LastActionUsername);
            ConsoleService.PrintMessage($"{status.LastActionUsername} has {(status.IsRunning ? "started" : "stopped")} the TauStellwerk");
        }
    }
}
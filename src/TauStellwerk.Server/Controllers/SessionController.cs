﻿// <copyright file="SessionController.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TauStellwerk.Base.Model;
using TauStellwerk.Services;

namespace TauStellwerk.Controllers
{
    /// <summary>
    /// Controller handling user stuff.
    /// </summary>
    [ApiController]
    [Route("session")]
    public class SessionController : Controller
    {
        private readonly SessionService _sessionService;

        public SessionController(SessionService sessionService)
        {
            _sessionService = sessionService;
        }

        /// <summary>
        /// Get session associated with a given sessionId.
        /// </summary>
        /// <param name="sessionId">The sessionId.</param>
        /// <returns>The session, if found, otherwise null.</returns>
        [HttpGet]
        public ActionResult<Session?> GetAssociatedSession([FromHeader(Name = "Session-Id")] string? sessionId)
        {
            if (sessionId == null)
            {
                return Ok();
            }

            return _sessionService.TryGetSession(sessionId);
        }

        /// <summary>
        /// HTTP GET.
        /// </summary>
        /// <returns>A list of active users.</returns>
        [HttpGet("list")]
        public IReadOnlyList<Session> Get()
        {
            return _sessionService.GetSessions();
        }

        [HttpPost]
        public ActionResult CreateSession([FromBody] string username)
        {
            var userAgent = Request?.Headers["User-Agent"].ToString();
            var session = _sessionService.CreateSession(username, userAgent);
            return Ok(session.SessionId);
        }

        [HttpPut]
        public void Put([FromHeader(Name = "Session-Id")] string sessionId)
        {
            _sessionService.TryUpdateSessionLastContact(sessionId);
        }

        [HttpPut("username")]
        public void Put([FromBody] string newUsername, [FromHeader(Name = "Session-Id")] string sessionId)
        {
            _sessionService.RenameSessionUser(sessionId, newUsername);
        }
    }
}
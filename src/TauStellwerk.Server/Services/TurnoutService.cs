// <copyright file="TurnoutService.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Threading.Tasks;
using FluentResults;
using TauStellwerk.Base.Model;
using TauStellwerk.Server.CommandStations;
using TauStellwerk.Server.Database.Model;

namespace TauStellwerk.Server.Services;

public class TurnoutService
{
    private readonly CommandStationBase _cs;

    public TurnoutService(CommandStationBase cs)
    {
        _cs = cs;
    }

    public async Task<Result> SetState(Turnout turnout, State state)
    {
        await _cs.HandleTurnout(turnout, state);
        return Result.Ok();
    }
}
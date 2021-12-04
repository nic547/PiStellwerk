﻿// <copyright file="ConsoleCommandSystem.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TauStellwerk.Base.Model;
using TauStellwerk.Database.Model;
using TauStellwerk.Util;

namespace TauStellwerk.Commands;

/// <summary>
/// <see cref="CommandSystemBase"/> that just writes everything to the console.
/// </summary>
public class ConsoleCommandSystem : CommandSystemBase
{
    // ReSharper disable once UnusedParameter.Local
    public ConsoleCommandSystem(IConfiguration config)
        : base(config)
    {
    }

    public override Task CheckState()
    {
        return Task.CompletedTask;
    }

    public override Task HandleEngineEStop(Engine engine, Direction priorDirection)
    {
        ConsoleService.PrintMessage($"{engine} has been emergency-stopped");
        return Task.CompletedTask;
    }

    public override Task HandleEngineFunction(Engine engine, byte functionNumber, State state)
    {
        ConsoleService.PrintMessage($"{engine} function {functionNumber} has been turned {state}");
        return Task.CompletedTask;
    }

    public override Task HandleEngineSpeed(Engine engine, short speed, Direction priorDirection, Direction newDirection)
    {
        if (priorDirection == newDirection)
        {
            ConsoleService.PrintMessage($"{engine} speed  has been set to {speed}");
        }
        else
        {
            ConsoleService.PrintMessage($"{engine} speed  has been set to {speed} and is now driving {newDirection}");
        }

        return Task.CompletedTask;
    }

    public override Task HandleSystemStatus(State state)
    {
        ConsoleService.PrintMessage($"System was {(state == State.On ? "started" : "stopped")}");
        return Task.CompletedTask;
    }
}
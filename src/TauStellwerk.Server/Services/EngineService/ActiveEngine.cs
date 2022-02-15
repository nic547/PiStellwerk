﻿// <copyright file="ActiveEngine.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using TauStellwerk.Base.Model;
using TauStellwerk.Database.Model;

namespace TauStellwerk.Services.EngineService;

public class ActiveEngine
{
    public ActiveEngine(Session session, Engine engine, EngineState state)
    {
        Session = session;
        Engine = engine;
        State = state;
    }

    public Session Session { get; set; }

    public Engine Engine { get; set; }

    public EngineState State { get; set; }
}

public class EngineState
{
    public EngineState(int numberOfEngines)
    {
        FunctionStates = Enumerable.Repeat(State.Off, numberOfEngines).ToList();
    }

    public int Throttle { get; set; }

    public Direction Direction { get; set; }

    public List<State> FunctionStates { get; set; }

    public void UpdateEngineFullDto(ref EngineFullDto dto)
    {
        if (dto.Functions.Count != FunctionStates.Count)
        {
            throw new InvalidOperationException("EngineFullDto cannot be updated because the number of functions does not match");
        }

        var orderedFunctions = dto.Functions.OrderBy(f => f.Number).ToList();

        dto.Throttle = Throttle;
        dto.Direction = Direction;

        for (var i = 0; i < dto.Functions.Count; i++)
        {
            orderedFunctions[i].State = FunctionStates[i];
        }
    }
}
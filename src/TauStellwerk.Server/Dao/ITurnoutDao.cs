// <copyright file="ITurnoutDao.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using System.Threading.Tasks;
using FluentResults;
using TauStellwerk.Base.Dto;
using TauStellwerk.Server.Database.Model;

namespace TauStellwerk.Server.Dao;

public interface ITurnoutDao
{
    public Task<Result<Turnout>> GetTurnoutById(int id);

    public Task<IList<TurnoutDto>> GetTurnouts(int page);

    public Task<Result> AddOrUpdate(TurnoutDto dto);

    public Task<Result> Delete(TurnoutDto dto);
}
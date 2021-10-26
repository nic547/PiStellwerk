// <copyright file="EngineFull.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using TauStellwerk.Base.Model;

namespace TauStellwerk.Client.Model;

public partial class EngineFull : ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private bool _isHidden;

    [ObservableProperty]
    private ushort _address;

    [ObservableProperty]
    private int _topSpeed;

    public EngineFull(EngineFullDto engine)
    {
        Id = engine.Id;
        _name = engine.Name;
        Tags = new ObservableCollection<string>(engine.Tags);
        Images = engine.Images.ToImmutableList();
        LastUsed = engine.LastUsed;
        Created = engine.Created;
        _isHidden = engine.IsHidden;
        Functions = new ObservableCollection<FunctionDto>(engine.Functions.OrderBy(x => x.Number));
        _address = engine.Address;
        _topSpeed = engine.TopSpeed;
    }

    public EngineFull()
    {
        _name = string.Empty;
        Tags = new();
        Images = new List<ImageDto>().ToImmutableList();
        Functions = new();
    }

    public int Id { get; }

    public ObservableCollection<string> Tags { get; }

    public ImmutableList<ImageDto> Images { get; }

    public DateTime LastUsed { get; }

    public DateTime Created { get; }

    public ObservableCollection<FunctionDto> Functions { get; }

    public static EngineFull? Create(EngineFullDto? engineDto)
    {
        if (engineDto == null)
        {
            return null;
        }

        return new EngineFull(engineDto);
    }

    public EngineFullDto ToDto()
    {
        return new()
        {
            Address = Address,
            Created = Created,
            Functions = Functions.ToList(),
            Id = Id,
            Images = Images.ToList(),
            IsHidden = IsHidden,
            LastUsed = LastUsed,
            Name = Name,
            Tags = Tags.ToList(),
            TopSpeed = TopSpeed,
        };
    }
}
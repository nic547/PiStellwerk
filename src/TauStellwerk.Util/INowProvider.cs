// <copyright file="INowProvider.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System;

namespace TauStellwerk.Util;

public interface INowProvider
{
    public DateTime GetUtcNow();
}

public class NowProvider : INowProvider
{
    public DateTime GetUtcNow()
    {
        return DateTime.UtcNow;
    }
}
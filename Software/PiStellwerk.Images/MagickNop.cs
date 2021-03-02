﻿// <copyright file="MagickNop.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Threading.Tasks;

namespace PiStellwerk.Images
{
    /// <summary>
    /// ImageMagick class that does nothing. Used if ImageMagick isn't installed.
    /// </summary>
    public class MagickNop : MagickBase
    {
        public override Task<int> GetImageWidth(string path)
        {
            return Task.FromResult(0);
        }

        public override Task<bool> IsAvailable()
        {
            return Task.FromResult(true);
        }
    }
}
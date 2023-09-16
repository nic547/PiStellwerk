// <copyright file="StopButtonControl.axaml.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using Avalonia;
using Avalonia.Controls;
using Splat;
using TauStellwerk.Base;
using TauStellwerk.Client.Model;
using TauStellwerk.Client.Services;
using TauStellwerk.Desktop.ViewModels;

namespace TauStellwerk.Desktop.Controls;

public partial class StopButtonControl : UserControl
{
    public StopButtonControl()
    {
        InitializeComponent();

        DataContext = new StopButtonControlViewModel();
    }
}
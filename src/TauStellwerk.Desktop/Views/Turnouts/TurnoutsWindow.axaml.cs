// <copyright file="TurnoutsWindow.axaml.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using JetBrains.Annotations;
using TauStellwerk.Desktop.ViewModels;

namespace TauStellwerk.Desktop.Views;

public class TurnoutsWindow : Window
{
    public TurnoutsWindow(TurnoutsViewModel vm)
    {
        DataContext = vm;
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    [UsedImplicitly]
    [Obsolete("Use constructor with ViewModel parameter", true)]
    public TurnoutsWindow()
    {
        // https://github.com/AvaloniaUI/Avalonia/issues/2593
    }

    protected override void OnClosed(EventArgs e)
    {
        if (DataContext is TurnoutsViewModel vm)
        {
            vm.Dispose();
        }

        base.OnClosed(e);
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
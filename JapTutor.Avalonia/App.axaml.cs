
using AutoMapper;
using AutoMapper.Execution;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using JapTutor.Avalonia.Common;
using JapTutor.Avalonia.ViewModels;
using JapTutor.Avalonia.Views;
using JapTutor.Shared.Common;
using JapTutor.Shared.DTOs;
using JapTutor.Shared.Models;

namespace JapTutor.Avalonia;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Line below is needed to remove Avalonia data validation.
            // Without this line you will get duplicate validations from both Avalonia and CT
            BindingPlugins.DataValidators.RemoveAt(0);
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }
        base.OnFrameworkInitializationCompleted();
        ConfigureAutoMapper();
    }

    private void ConfigureAutoMapper()
    {
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfiles());
        });
        DataBlock.mapper = mappingConfig.CreateMapper();
    }
}
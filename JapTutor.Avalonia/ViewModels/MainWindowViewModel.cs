using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JapTutor.Avalonia.Common;
using JapTutor.Avalonia.Views;

namespace JapTutor.Avalonia.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        
    }

    #region Commands

    [RelayCommand]
    private void HiraganaNavigation()
    {
        NavigationView = DataBlock.HiraganaView;
    }

    [RelayCommand]
    private void KatakanaNavigation()
    {
        NavigationView = DataBlock.KatakanaView;
    }

    [RelayCommand]
    private void KanjiNavigation()
    {
        NavigationView = DataBlock.KanjiView;
    }

    #endregion


    #region DataBinding

    [ObservableProperty] private UserControl _navigationView = DataBlock.HiraganaView;

    #endregion
}
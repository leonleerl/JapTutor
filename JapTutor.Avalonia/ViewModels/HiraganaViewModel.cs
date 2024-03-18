using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JapTutor.Avalonia.Common;
using JapTutor.Avalonia.Models;

namespace JapTutor.Avalonia.ViewModels;

public partial class HiraganaViewModel : ViewModelBase
{

    public HiraganaViewModel()
    {
        
    }

    #region Commands

    [RelayCommand]
    private void ShowA()
    {
        
    }

    [RelayCommand]
    private void ShowKa()
    {
        
    }

    [RelayCommand]
    private void ShowSa()
    {
        
    }

    #endregion

    #region DataBinding

    [ObservableProperty] private ObservableCollection<CardModel> _hiraganaCards = new()
    {
        new CardModel(){ ImageUrl = DataBlock.TempImageUrl, Name = "a"},
        new CardModel(){ ImageUrl = DataBlock.TempImageUrl, Name = "a"},
        new CardModel(){ ImageUrl = DataBlock.TempImageUrl, Name = "a"},
        new CardModel(){ ImageUrl = DataBlock.TempImageUrl, Name = "a"},
        new CardModel(){ ImageUrl = DataBlock.TempImageUrl, Name = "a"},
        new CardModel(){ ImageUrl = DataBlock.TempImageUrl, Name = "a"},
        new CardModel(){ ImageUrl = DataBlock.TempImageUrl, Name = "a"},
        new CardModel(){ ImageUrl = DataBlock.TempImageUrl, Name = "a"},
    };

    #endregion
}
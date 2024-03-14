using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using JapTutor.Avalonia.Common;
using JapTutor.Avalonia.Models;

namespace JapTutor.Avalonia.ViewModels;

public partial class HiraganaViewModel : ViewModelBase
{
    public HiraganaViewModel()
    {
        
    }

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
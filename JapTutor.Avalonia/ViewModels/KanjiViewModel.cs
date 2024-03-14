using CommunityToolkit.Mvvm.ComponentModel;

namespace JapTutor.Avalonia.ViewModels;

public partial class KanjiViewModel : ViewModelBase
{
    public KanjiViewModel()
    {
        
    }

    #region DataBinding

    [ObservableProperty] private string _title = "Kanji";

    #endregion
}
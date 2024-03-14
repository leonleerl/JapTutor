using CommunityToolkit.Mvvm.ComponentModel;

namespace JapTutor.Avalonia.ViewModels;

public partial class KatakanaViewModel : ViewModelBase
{
    public KatakanaViewModel()
    {
        
    }

    #region DataBinding

    [ObservableProperty] private string _title = "Katakana";

    #endregion
}
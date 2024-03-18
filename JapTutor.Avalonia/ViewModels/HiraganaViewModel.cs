using System.Collections.ObjectModel;
using System.Net.Http;
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
    private async void ShowA()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://localhost:7091/api/BasicPronunciation/GetAll");
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            
            // Persons = JsonConvert.DeserializeObject<ObservableCollection<PersonDto>>(content);
        }
    }
    
    // private async void LoadPersons()
    // {
    //     using (var httpClient = new HttpClient())
    //     {
    //         var response = await httpClient.GetAsync("https://yourwebapi.com/api/persons");
    //         if (response.IsSuccessStatusCode)
    //         {
    //             var content = await response.Content.ReadAsStringAsync();
    //             var models = JsonConvert.DeserializeObject<List<PersonModel>>(content);
    //             Persons = new ObservableCollection<PersonDto>(models.Select(MapToDto));
    //         }
    //     }
    // }
    //
    // private PersonDto MapToDto(PersonModel model)
    // {
    //     return new PersonDto
    //     {
    //         Id = model.Id,
    //         Name = model.Name
    //         // Map other properties as needed
    //     };
    // }

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
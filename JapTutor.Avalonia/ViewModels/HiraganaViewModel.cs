using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AutoMapper;
using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JapTutor.Avalonia.Common;
using JapTutor.Avalonia.Models;
using JapTutor.Shared.Common;
using JapTutor.Shared.DTOs;
using JapTutor.Shared.Enum;
using JapTutor.Shared.Models;
using Newtonsoft.Json;

namespace JapTutor.Avalonia.ViewModels;

public partial class HiraganaViewModel : ViewModelBase
{
    public HiraganaViewModel()
    {
        // HiraganaCards = new ObservableCollection<BasicInfoWithImage>()
        // {
        //     new()
        //     {
        //         Name = "a",
        //         Type = BasicInfoEnum.Hiragana,
        //         ImageUrl = Tools.BaseImgUrl + "243669/a.png",
        //         AudioUrl = ""
        //     },
        //     new()
        //     {
        //         Name = "i",
        //         Type = BasicInfoEnum.Hiragana,
        //         ImageUrl = Tools.BaseImgUrl + "243671/i.png",
        //         AudioUrl = ""
        //     },
        //     new()
        //     {
        //         Name = "u",
        //         Type = BasicInfoEnum.Hiragana,
        //         ImageUrl = Tools.BaseImgUrl + "243673/u.png",
        //         AudioUrl = ""
        //     },
        // };
    }

    #region Commands


    [RelayCommand]
    private async Task ShowA()
    {

        HiraganaCards.Clear();
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://localhost:7091/api/BasicPronunciation/GetAll");
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            IEnumerable<BasicInfo> basicInfos = JsonConvert.DeserializeObject<IEnumerable<BasicInfo>>(content);
            foreach (var basicInfo in basicInfos)
            {
                BasicInfoWithImage newBasicInfo = new BasicInfoWithImage()
                {
                    Id = basicInfo.Id,
                    Name = basicInfo.Name,
                    Type = basicInfo.Type,
                    AudioUrl = basicInfo.AudioUrl
                };
                newBasicInfo.ImageUrl = await LoadImageAsync(basicInfo.ImageUrl);
                await Dispatcher.UIThread.InvokeAsync(
                    () => { HiraganaCards.Add(newBasicInfo); }
                );
            }
        }
    }


    [RelayCommand]
    private void ShowKa()
    {
    }

    [RelayCommand]
    private void ShowSa()
    {
    }

    private async Task<Bitmap> LoadImageAsync(string imgUrl)
    {
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(imgUrl);
            if (response.IsSuccessStatusCode)
            {
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    return new Bitmap(stream);
                }
            }
        }

        return default!;
    }

    #endregion

    #region DataBinding

    [ObservableProperty] private ObservableCollection<BasicInfoWithImage> _hiraganaCards = new();
    [ObservableProperty] private Bitmap _image;

    #endregion
}
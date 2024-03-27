using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
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
    private async Task ShowA()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/a");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "ka",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            // basicInfo.ImageUrl = await LoadImageAsync(imagePath);
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowKa()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/ka");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "ka",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowN()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/n");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "n",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowSa()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/sa");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "sa",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            // basicInfo.ImageUrl = await LoadImageAsync(imagePath);
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowNa()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/na");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "na",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowWa()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/wa");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "wa",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowHa()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/ha");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "ha",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowMa()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/ma");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "ma",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowYa()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/ya");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "ya",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowTa()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/ta");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "ta",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }

    [RelayCommand]
    private async Task ShowRa()
    {
        HiraganaCards.Clear();
        string[] files = Directory.GetFiles(DataBlock.ImageBasePath + "/hiragana/ra");
        foreach (string imagePath in files)
        {
            BasicInfo basicInfo = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "ra",
                Type = BasicInfoEnum.Hiragana,
                ImageUrl = await LoadImageAsync(imagePath),
                AudioUrl = string.Empty
            };
            await Dispatcher.UIThread.InvokeAsync(
                () => { HiraganaCards.Add(basicInfo); }
            );
        }
    }


    private async Task<Bitmap> LoadImageAsync(string imagePath)
    {
        try
        {
            using (var stream = File.OpenRead(imagePath))
            {
                return new Bitmap(stream);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image: {ex.Message}");
            return null;
        }
    }

    #endregion

    #region DataBinding

    [ObservableProperty] private ObservableCollection<BasicInfo> _hiraganaCards = new();
    [ObservableProperty] private Bitmap _image;

    #endregion
}
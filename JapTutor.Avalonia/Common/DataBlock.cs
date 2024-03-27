using System;
using System.IO;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;
using JapTutor.Avalonia.Models;
using JapTutor.Avalonia.Views;

namespace JapTutor.Avalonia.Common;

public class DataBlock
{
    public static readonly DataBlock Instance = new Lazy<DataBlock>(() => new DataBlock()).Value;

    public static UserControl HiraganaView = new HiraganaView();

    public static UserControl KatakanaView = new KatakanaView();

    public static UserControl KanjiView = new KanjiView();


    public static string ImageBasePath = AppDomain.CurrentDomain.BaseDirectory + "Images";
    
    public static string AudioBasePath = AppDomain.CurrentDomain.BaseDirectory + "Audio";

    // public static string TempImageUrl = AppDomain.CurrentDomain.BaseDirectory + "Images/a.webp";

    // public static IMapper mapper = default!;



}
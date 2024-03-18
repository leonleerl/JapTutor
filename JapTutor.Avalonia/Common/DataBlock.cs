using System;
using AutoMapper;
using Avalonia;
using Avalonia.Controls;
using JapTutor.Avalonia.Views;

namespace JapTutor.Avalonia.Common;

public class DataBlock
{
    public static readonly DataBlock Instance = new Lazy<DataBlock>(() => new DataBlock()).Value;

    public static UserControl HiraganaView = new HiraganaView();

    public static UserControl KatakanaView = new KatakanaView();

    public static UserControl KanjiView = new KanjiView();

    public static string TempImageUrl = AppDomain.CurrentDomain.BaseDirectory + "Images/a.webp";

    public static IMapper mapper = default!;
    
}
﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Cheatjockey2;

public class CardItem
{
    private string url;
    private string name;
    private string type;
    private string format;
    private string duration;
    private string tracks;
    private string output;


    public string URL
    {
        get => url;
        set
        {
            url = value;
            OnPropertyChanged();
        }
    }

    public string Name
    {
        get => name;
        set
        {
            name = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(Title));
        }
    }

    public string Tracks
    {
        get => tracks;
        set
        {
            tracks = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(StatusInfo));
        }
    }
    public string Duration
    {
        get => duration;
        set
        {
            duration = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(StatusInfo));
        }
    }
    public string Format
    {
        get => format;
        set
        {
            format = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(StatusInfo));
        }
    }
    public string Output
    {
        get => output;
        set
        {
            output = value;
            OnPropertyChanged();
        }
    }

    public string Title => $"{Name}";
    public string StatusInfo => $"{Tracks} - {Duration} - {Format}";

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
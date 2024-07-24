using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace FortunaPickWPF.ViewModels;


public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {

    }

    [RelayCommand]
    private void Close()
    {
        Application.Current.Shutdown();
    }
}
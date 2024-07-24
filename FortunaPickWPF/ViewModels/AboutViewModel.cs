using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace FortunaPickWPF.ViewModels;


public partial class AboutViewModel : ObservableObject
{
    [RelayCommand]

    private void BuyMeABeer()
    {
        var proc = Process.Start(@"msedge.exe ", @"/c " + "https://paypal.me/mlewisonline");
    }
}
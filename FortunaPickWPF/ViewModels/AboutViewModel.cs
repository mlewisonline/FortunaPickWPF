using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Data.Common;
using System.Diagnostics;

namespace FortunaPickWPF.ViewModels;


public partial class AboutViewModel : ObservableObject
{
    [ObservableProperty]
    private string _aboutText = string.Empty;

    public AboutViewModel()
    {
        AboutText = """

            FortunaPick: Your Lottery Number Ally

            Are you tired of staring at your lottery ticket, wondering which numbers to choose? 
            Look no further—FortunaPick is here to lend a hand! 

            Whether you’re eyeing the UK Lotto, EuroMillions, or Thunderball, this nifty tool can help you make informed picks.
            Remember, FortunaPick doesn’t guarantee a jackpot (if it did, I’d be on a tropical island right now). 
            But it adds a sprinkle of fun and strategy to your lottery adventures. 
            So go ahead, roll those digital dice, and may the odds be ever in your favour! 🌟🎰

            Feel free to give FortunaPick a whirl—it’s like having a lucky rabbit’s foot without the fur! 
            If you need more info or want to chat about lucky socks, I’m here. 🍀😄

            """;
    }
}
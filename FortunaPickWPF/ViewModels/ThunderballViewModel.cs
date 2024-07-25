using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FortunaPickWPF.ViewModels;

public partial class ThunderballViewModel : ObservableObject
{
    [ObservableProperty]
    private int _ball1;
    [ObservableProperty]
    private int _ball2;
    [ObservableProperty]
    private int _ball3;
    [ObservableProperty]
    private int _ball4;
    [ObservableProperty]
    private int _ball5;
    [ObservableProperty]
    private int _thunderball;

    public ThunderballViewModel()
    {
        //Get Line On Initialization
        GetThunderLine();
    }

    [RelayCommand]
    private void GetThunderLine()
    {
        List<int> thunderLine = [];
        List<int> mainBalls = [];
        List<int> tunderBalls = [];

        //Seed Random
        Random random = new(Guid.NewGuid().GetHashCode());

        // Build main balls from 1 to 39.
        for (int i = 1; i < 40; i++)
        {
            mainBalls.Add(i);
        }

        // Build thunder balls from 1 to 14.
        for (int i = 1; i < 15; i++)
        {
            tunderBalls.Add(i);
        }

        // Shuffle the ball sets ordered by new GUID.
        mainBalls = [.. mainBalls.OrderBy(item => Guid.NewGuid())];
        tunderBalls = [.. tunderBalls.OrderBy(item => Guid.NewGuid())];

        // Pick 5 random main balls add to the line and remove from the picking pool.
        int mainIndex = -1;
        for (int i = 0; i < 5; i++)
        {
            mainIndex = random.Next(mainBalls.Count);
            thunderLine.Add(mainBalls[mainIndex]);
            mainBalls.RemoveAt(mainIndex);
        }


        // Pick 1 thunder ball add to the line. No need to remove from pool as only 1 is ever chosen.
        int thunderIndex = random.Next(tunderBalls.Count);
        thunderLine.Add(tunderBalls[thunderIndex]);


        // Update Interface Properties
        Ball1 = thunderLine[0];
        Ball2 = thunderLine[1];
        Ball3 = thunderLine[2];
        Ball4 = thunderLine[3];
        Ball5 = thunderLine[4];
        Thunderball = thunderLine[5];

    }

}

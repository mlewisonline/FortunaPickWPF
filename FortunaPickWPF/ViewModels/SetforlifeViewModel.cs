using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FortunaPickWPF.ViewModels;

public partial class SetforlifeViewModel : ObservableObject
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
    private int _lifeball;

    public SetforlifeViewModel()
    {
        //Get Line On Initialization
        GetSetforLifeLine();
    }

    [RelayCommand]
    private void GetSetforLifeLine()
    {
        List<int> lifeLine = [];
        List<int> mainBalls = [];
        List<int> lifeBalls = [];
        Random random = new();

        // Build main balls from 1 to 47.
        for (int i = 1; i < 48; i++)
        {
            mainBalls.Add(i);
        }

        // Build thunder balls from 1 to 10.
        for (int i = 1; i < 11; i++)
        {
            lifeBalls.Add(i);
        }

        // Shuffle the ball sets ordered by new GUID.
        mainBalls = [.. mainBalls.OrderBy(item => Guid.NewGuid())];
        lifeBalls = [.. lifeBalls.OrderBy(item => Guid.NewGuid())];

        // Pick 5 random main balls add to the line and remove from the picking pool.
        int mainIndex = -1;
        for (int i = 0; i < 5; i++)
        {
            mainIndex = random.Next(mainBalls.Count);
            lifeLine.Add(mainBalls[mainIndex]);
            mainBalls.RemoveAt(mainIndex);
        }

        // Pick 1 life ball add to the line. No need to remove from pool as only 1 is ever chosen.
        int lifeIndex = random.Next(lifeBalls.Count);
        lifeLine.Add(lifeBalls[lifeIndex]);

        // Update interface properties
        Ball1 = lifeBalls[0];
        Ball2 = lifeBalls[1];
        Ball3 = lifeBalls[2];
        Ball4 = lifeBalls[3];
        Ball5 = lifeBalls[4];
        Lifeball = lifeBalls[5];
    }
}

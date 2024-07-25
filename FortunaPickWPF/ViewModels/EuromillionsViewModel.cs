using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FortunaPickWPF.ViewModels;

public partial class EuromillionsViewModel : ObservableObject
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
    private int _star1;
    [ObservableProperty]
    private int _star2;

    public EuromillionsViewModel()
    {
        //Get Line On Initialization
        GetEuroMillionsLine();
    }

    [RelayCommand]
    private void GetEuroMillionsLine()
    {
        List<int> euroline = [];
        List<int> mainBalls = [];
        List<int> luckyStars = [];

        // Seed Random
        Random random = new(Guid.NewGuid().GetHashCode());

        // Build main balls from 1 to 50.
        for (int i = 1; i < 51; i++)
        {
            mainBalls.Add(i);
        }
        // Build lucky stars from 1 to 12.
        for (int i = 1; i < 13; i++)
        {
            luckyStars.Add(i);
        }

        // Shuffle the ball sets ordered by new GUID.
        mainBalls = [.. mainBalls.OrderBy(item => Guid.NewGuid())];
        luckyStars = [.. luckyStars.OrderBy(item => Guid.NewGuid())];

        // Pick 5 random main balls add to the line and remove from the picking pool.
        int indexEuro = -1;
        for (int i = 0; i < 5; i++)
        {
            indexEuro = random.Next(mainBalls.Count);
            euroline.Add(mainBalls[indexEuro]);
            mainBalls.RemoveAt(indexEuro);
        }

        // Pick 2 random stars add to the line and remove from the picking pool.
        int starIndex = -1;
        for (int i = 0; i < 2; i++)
        {
            starIndex = random.Next(luckyStars.Count);
            euroline.Add(luckyStars[starIndex]);
            luckyStars.RemoveAt(starIndex);
        }

        // Update interface properties
        Ball1 = euroline[0];
        Ball2 = euroline[1];
        Ball3 = euroline[2];
        Ball4 = euroline[3];
        Ball5 = euroline[4];
        Star1 = euroline[5];
        Star2 = euroline[6];    
    }
}

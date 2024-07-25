using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FortunaPickWPF.ViewModels;

public partial class LottoViewModel : ObservableObject
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
    private int _ball6;

    public LottoViewModel()
    {
        //Get Line On Initialization
        GetLottoLine();
    }

    [RelayCommand]
    private void GetLottoLine()
    {
        List<int> lottoLine = [];
        List<int> mainBalls = [];

        // Seed Random
        Random random = new(Guid.NewGuid().GetHashCode());

        // Build main balls from 1 to 59.
        for (int i = 1; i < 60; i++)
        {
            mainBalls.Add(i);
        }
        // Shuffle the ball sets ordered by new GUID.
        mainBalls = [.. mainBalls.OrderBy(item => Guid.NewGuid())];

        // Pick 6 random main balls add to the line and remove from the picking pool.
        int indexLotto = -1;
        for (int i = 0; i < 6; i++)
        {
            indexLotto = random.Next(mainBalls.Count);
            lottoLine.Add(mainBalls[indexLotto]);
            mainBalls.RemoveAt(indexLotto);
        }

        // Update interface properties
        Ball1 = lottoLine[0];
        Ball2 = lottoLine[1];   
        Ball3 = lottoLine[2]; 
        Ball4 = lottoLine[3];   
        Ball5 = lottoLine[4];
        Ball6 = lottoLine[5];
    }
}

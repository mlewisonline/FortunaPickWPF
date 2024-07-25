using CommunityToolkit.Mvvm.ComponentModel;
using FortunaPickWPF.Helpers;

namespace FortunaPickWPF.ViewModels;

public partial class DrawhistoryViewModel : ObservableObject
{
    [ObservableProperty]
    public string? _lottoDate;
    [ObservableProperty]
    public int? _lottoBall1;
    [ObservableProperty]
    public int? _lottoBall2;
    [ObservableProperty]
    public int? _lottoBall3;
    [ObservableProperty]
    public int? _lottoBall4;
    [ObservableProperty]
    public int? _lottoBall5;
    [ObservableProperty]
    public int? _lottoBall6;
    [ObservableProperty]
    public int? _lottoBonusBall;

    [ObservableProperty]
    public string? euroDate;
    [ObservableProperty]
    public int? _euroBall1;
    [ObservableProperty]
    public int? _euroBall2;
    [ObservableProperty]
    public int? _euroBall3;
    [ObservableProperty]
    public int? _euroBall4;
    [ObservableProperty]
    public int? _euroBall5;
    [ObservableProperty]
    public int? _star1;
    [ObservableProperty]
    public int? _star2;
    [ObservableProperty]
    public string? _ticket = string.Empty;

    [ObservableProperty]
    public string? _thunderDate;
    [ObservableProperty]
    public int? _thunderBall1;
    [ObservableProperty]
    public int? _thunderBall2;
    [ObservableProperty]
    public int? _thunderBall3;
    [ObservableProperty]
    public int? _thunderBall4;
    [ObservableProperty]
    public int? _thunderBall5;
    [ObservableProperty]
    public int? _thunderBall;

    [ObservableProperty]
    public string? setforDate;
    [ObservableProperty]
    public int? _lifeBall1;
    [ObservableProperty]
    public int? _lifeBall2;
    [ObservableProperty]
    public int? _lifeBall3;
    [ObservableProperty]
    public int? _lifeBall4;
    [ObservableProperty]
    public int? _lifeBall5;
    [ObservableProperty]
    public int? _lifeBall;

    public DrawhistoryViewModel( )
    {
        var LottoResults = DrawHistoryUtils.CSV2LottoResultsList(DrawResults.lottoHistoryPath);
        var ThunderBallResults = DrawHistoryUtils.CSV2ThunderBallResultsList(DrawResults.thunderballistoryPath);
        var EuroMillionsResults = DrawHistoryUtils.CSV2EuroMillionsResultsList(DrawResults.euromillionHistoryPath);
        var SetForLifeResults = DrawHistoryUtils.CSV2SetForLifeResultsList(DrawResults.setforlifeHistoryPath);

        LottoDate = LottoResults[0].Date.ToString();
        LottoBall1 = LottoResults[0].Ball1;
        LottoBall2 = LottoResults[0].Ball2;
        LottoBall3 = LottoResults[0].Ball3;
        LottoBall4 = LottoResults[0].Ball4;
        LottoBall5 = LottoResults[0].Ball5;
        LottoBall6 = LottoResults[0].Ball5;
        LottoBonusBall = LottoResults[0].BonusBall;

        euroDate = EuroMillionsResults[0].Date.ToString();
        EuroBall1 = EuroMillionsResults[0].Ball1;
        EuroBall2 = EuroMillionsResults[0].Ball1;
        EuroBall3 = EuroMillionsResults[0].Ball3;
        EuroBall4 = EuroMillionsResults[0].Ball4;
        EuroBall5 = EuroMillionsResults[0].Ball5;
        Star1 = EuroMillionsResults[0].Star1;
        Star2 = EuroMillionsResults[0].Star2;
        Ticket = EuroMillionsResults[0].Ticket;

        SetforDate = SetForLifeResults[0].Date.ToString();
        LifeBall1 = SetForLifeResults[0].Ball1;
        LifeBall2 = SetForLifeResults[0].Ball2;
        LifeBall3 = SetForLifeResults[0].Ball3;
        LifeBall4 = SetForLifeResults[0].Ball4;
        LifeBall5 = SetForLifeResults[0].Ball5;
        LifeBall = SetForLifeResults[0].LifeBall;

        ThunderDate = ThunderBallResults[0].Date.ToString();
        ThunderBall1 = ThunderBallResults[0].Ball1;
        ThunderBall2 = ThunderBallResults[0].Ball2;
        ThunderBall3 = ThunderBallResults[0].Ball3;
        ThunderBall4 = ThunderBallResults[0].Ball4;
        ThunderBall5 = ThunderBallResults[0].Ball5;
        ThunderBall = ThunderBallResults[0].ThunderBall;

    }
}

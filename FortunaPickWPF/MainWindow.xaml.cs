using FortunaPickWPF.ViewModels;
using FortunaPickWPF.Views;
using System.Windows;

namespace FortunaPickWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel mainViewModel, 
                            AboutViewModel aboutViewModel,
                            BallstatsViewModel ballstatsViewModel,
                            DrawhistoryViewModel drawhistoryViewModel,
                            EuromillionsViewModel euromillionsViewModel,
                            LottoViewModel lottoViewModel,
                            SetforlifeViewModel setforlifeViewModel,
                            ThunderballViewModel thunderballViewModel)
        {
            DataContext = mainViewModel;
            InitializeComponent();
            AboutView.DataContext = aboutViewModel;
            BallstatsView.DataContext = ballstatsViewModel;
            DrawhistoryView.DataContext = drawhistoryViewModel;
            EuromillionsView.DataContext = euromillionsViewModel;
            LottoView.DataContext = lottoViewModel;
            SetforlifeView.DataContext = setforlifeViewModel;
            ThunderballView.DataContext = thunderballViewModel;
            
        }
    }
}
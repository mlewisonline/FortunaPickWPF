using FortunaPickWPF.ViewModels;

namespace FortunaPickWPF;


public partial class MainWindow
{
    public MainWindow(MainViewModel mainViewModel)
    {
        DataContext = mainViewModel;
        InitializeComponent();
    }
}
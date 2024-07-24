using FortunaPickWPF.ViewModels;
using FortunaPickWPF.Views;
using System.Windows;

namespace FortunaPickWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel mainViewModel, AboutViewModel aboutViewModel)
        {
            DataContext = mainViewModel;
            InitializeComponent();
        }
    }
}
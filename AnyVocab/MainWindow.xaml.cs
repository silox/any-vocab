using AnyVocab.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using AnyVocab.Services;

namespace AnyVocab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        private readonly TranslationStorageService translationStorageService = new("../../../Data/");

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DefaultViewModel();
            PackSelectionComboBox.ItemsSource = translationStorageService.getPackNames();
        }

        private void Button_Click_Practice(object sender, RoutedEventArgs e)
        {
            DataContext = new PracticeViewModel();
        }

        private void Button_Click_LoadVocab(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_CreateVocab(object sender, RoutedEventArgs e)
        {
            DataContext = new CreatePackViewModel();
        }

        private void Button_Click_Quit(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_Statistics(object sender, RoutedEventArgs e)
        {

        }
    }
}

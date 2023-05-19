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
using AnyVocab.Views;
using AnyVocab.Models;

namespace AnyVocab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        private readonly TranslationStorageService translationStorageService = new("../../../Data/");
        private Statistics statistics;

        public MainWindow()
        {
            InitializeComponent();
            frame.Content = new DefaultView();
            PackSelectionComboBox.ItemsSource = translationStorageService.getPackNames();
            statistics = new Statistics();
        }

        private void Button_Click_Practice(object sender, RoutedEventArgs e)
        {
            string? packName = PackSelectionComboBox.SelectedItem?.ToString();
            if (packName == null)
            {
                MessageBox.Show("Please select a pack to practice");
                return;
            }
            try
            {
                frame.Content = new PracticeView(statistics, frame, translationStorageService, packName, PackSelectionComboBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_CreateVocab(object sender, RoutedEventArgs e)
        {
            frame.Content = new CreatePackView(frame, PackSelectionComboBox);
        }

        private void Button_Click_Quit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_Statistics(object sender, RoutedEventArgs e)
        {
            frame.Content = new StatisticsView(statistics, frame);

        }
    }
}

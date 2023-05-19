using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

using AnyVocab.Models;
using AnyVocab.Services;
using AnyVocab.ViewModels;

namespace AnyVocab.Views
{
    /// <summary>
    /// Interaction logic for PracticeView.xaml
    /// </summary>
    public partial class PracticeView : Page
    {
        private readonly Frame frame;
        private readonly VocabPack? pack;
        private readonly PracticeViewModel viewModel;
        private VocabItem currentVocab;

        public PracticeView(Frame frame, TranslationStorageService translationStorageService, string packName)
        {
            InitializeComponent();
            this.frame = frame;
            pack = translationStorageService.ReadTranslationsFromFile(packName);
            if (pack == null)
            {
                throw new Exception("Failed to load pack");
            }
            viewModel = new(pack);
            CounterLabel.Content = $"{viewModel.GetGuessedCount()}/{viewModel.GetTotalCount()}";
            currentVocab = viewModel.GetNextVocab()!;  // First item is always non-null
            WordLabel.Content = currentVocab.Word;
        }

        private void Button_Click_Skip(object sender, RoutedEventArgs e)
        {
            viewModel.returnPending(currentVocab);
            NextButton.Visibility = Visibility.Visible;
        }

        private void Button_Click_Check(object sender, RoutedEventArgs e)
        {
            if (currentVocab.CheckTranslation(UserAnswerTextBox.Text))
            {
                AssessmentLabel.Content = "Correct!";
                AssessmentLabel.Foreground = Brushes.Green;
                viewModel.AddGuessed(currentVocab);
            }
            else
            {
                AssessmentLabel.Content = $"Wrong answer. Expected '{currentVocab.Translation}'";
                AssessmentLabel.Foreground = Brushes.Red;
                viewModel.returnPending(currentVocab);
            }
            AssessmentLabel.Visibility = Visibility.Visible;
            NextButton.Visibility = Visibility.Visible;
        }

        private void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            AssessmentLabel.Visibility = Visibility.Hidden;
            NextButton.Visibility = Visibility.Hidden;
            CounterLabel.Content = $"{viewModel.GetGuessedCount()}/{viewModel.GetTotalCount()}";
            currentVocab = viewModel.GetNextVocab();
            if (currentVocab == null)
            {
                frame.Content = new DefaultView(frame);
                return;
            }
            WordLabel.Content = currentVocab.Word;
            UserAnswerTextBox.Clear();
        }
        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            frame.Content = new DefaultView(frame);
        }
    }
}

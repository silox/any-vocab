﻿using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
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
        private Statistics stats;
        private ComboBox comboBox;

        public PracticeView(Statistics statistics, Frame frame, TranslationStorageService translationStorageService, string packName, ComboBox comboBox)
        {
            InitializeComponent();
            this.frame = frame;
            this.comboBox = comboBox;
            stats = statistics;
            pack = translationStorageService.ReadTranslationsFromFile(packName);
            if (pack == null)
            {
                throw new Exception("Failed to load pack");
            }
            viewModel = new(pack, translationStorageService);
            CounterLabel.Content = $"{viewModel.GetGuessedCount()}/{viewModel.GetTotalCount()}";
            currentVocab = viewModel.GetNextVocab()!;  // First item is always non-null
            WordLabel.Content = currentVocab.Word;
        }

        private void Button_Click_Skip(object sender, RoutedEventArgs e)
        {
            viewModel.returnPending(currentVocab);
            Button_Click_Next(sender, e);
        }

        private void Button_Click_Check(object sender, RoutedEventArgs e)
        {
            if (currentVocab.CheckTranslation(UserAnswerTextBox.Text))
            {
                AssessmentLabel.Content = "Correct!";
                AssessmentLabel.Foreground = Brushes.Green;
                viewModel.AddGuessed(currentVocab);
                stats.trackCorrect();
            }
            else
            {
                AssessmentLabel.Content = $"Wrong answer. Expected '{currentVocab.Translation}'";
                AssessmentLabel.Foreground = Brushes.Red;
                viewModel.addFailed(currentVocab);
                viewModel.returnPending(currentVocab);
                stats.trackIncorrect();
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
                if (viewModel.GetIncorrectCount() == 0)
                {
                    MessageBox.Show("Congratulations! You have completed the pack!");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Do you want to save incorrectly answered translations to a new pack?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        Task.Run(() => viewModel.dumpIncorrectVocab(comboBox));
                    }
                }

                frame.Content = new DefaultView();
                return;
            }
            WordLabel.Content = currentVocab.Word;
            UserAnswerTextBox.Clear();
        }
        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            frame.Content = new DefaultView();
        }
    }
}

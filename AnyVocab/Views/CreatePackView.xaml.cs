using AnyVocab.Models;
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

namespace AnyVocab.Views
{
    /// <summary>
    /// Interaction logic for CreatePackView.xaml
    /// </summary>
    public partial class CreatePackView : Page
    {
        private readonly Frame frame;
        private readonly CreatePackViewModel viewModel;

        public CreatePackView(Frame frame)
        {
            InitializeComponent();
            viewModel = new();
            this.frame = frame;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            string word = WordTextBox.Text;
            string translation = TranslationTextBox.Text;
            if (word != "" && translation != "")
            {
                viewModel.AddVocab(word, translation);
                VocabularyGrid.Items.Add(new VocabItem(word, translation));
                VocabularyGrid.Items.Refresh();
                WordTextBox.Text = "";
                TranslationTextBox.Text = "";
            }
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            viewModel.StorePack();
        }

        private void Button_Click_Discard(object sender, RoutedEventArgs e)
        {
            frame.Content = new DefaultView(frame);
           // NavigationService navigationService = new(frame);
           // navigationService.NavigateTo<DefaultView>();
        }
    }
}


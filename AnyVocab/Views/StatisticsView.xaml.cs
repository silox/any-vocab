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

using AnyVocab.Models;

namespace AnyVocab.Views
{
    /// <summary>
    /// Interaction logic for StatisticsView.xaml
    /// </summary>
    public partial class StatisticsView : Page
    {
        private readonly Frame frame;
        private Statistics stats;

        public StatisticsView(Statistics statistics, Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
            stats = statistics;
            TranslationAccuracyLabel.Content = stats.getPercentage().ToString("P");
        }

        public void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            frame.Content = new DefaultView(frame);
        }
    }
}

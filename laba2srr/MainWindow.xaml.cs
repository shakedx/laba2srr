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

namespace laba2srr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {

            Balka mama = new Balka(double.Parse(width.Text), double.Parse(height.Text), double.Parse(length.Text), double.Parse(part.Text), double.Parse(density.Text));
            Result.Text = mama.action();
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            Balka papa = new Balka(double.Parse(width.Text), double.Parse(height.Text), double.Parse(length.Text), double.Parse(part.Text), double.Parse(density.Text));
            Result2.Text = papa.papa();
        }


    }
}

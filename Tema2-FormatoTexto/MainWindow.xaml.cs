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

namespace Tema2_FormatoTexto
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

        private void Rojo_Checked(object sender, RoutedEventArgs e)
        {
            text.Foreground= Brushes.Red;
        }

        private void Verde_Checked(object sender, RoutedEventArgs e)
        {
            text.Foreground = Brushes.Green;
        }

        private void Azul_Checked(object sender, RoutedEventArgs e)
        {
            text.Foreground = Brushes.Blue;
        }

        private void Cursiva_Checked(object sender, RoutedEventArgs e)
        {
           
                text.FontStyle = FontStyles.Italic;
            
                
            
        }

        private void Negrita_Checked(object sender, RoutedEventArgs e)
        {
            
            text.FontWeight = FontWeights.Black;
            
                
        }

        private void Cursiva_Unchecked(object sender, RoutedEventArgs e)
        {
            text.FontStyle = FontStyles.Normal;
        }

        private void Negrita_Unchecked(object sender, RoutedEventArgs e)
        {
            text.FontWeight = FontWeights.Normal;
        }
    }
}

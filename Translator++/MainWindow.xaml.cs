using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Translator__;

namespace Translator__
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///
    
    public partial class MainWindow : Window
    {
        string eng = @"`qwertyuiop[]asdfghjkl;'zxcvbnm,./~!@#$%^&*()_+|QWERTYUIOP{}ASDF" + "GHJKL:\"ZXCVBNM<>?";
        string rus = @"ёйцукенгшщзхъфывапролджэячсмитьбю.Ё!" + "\"№;%:?*()_+/ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ,";

        TRANSLATOR tr = new TRANSLATOR();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ExampleText.Text = tr.translate(rus, eng);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ExampleText.Text = tr.translate(eng,rus);
        }

        
    }
}

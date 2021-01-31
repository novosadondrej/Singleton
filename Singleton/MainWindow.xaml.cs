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

namespace Singleton
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

        private void Button_SaveClick(object sender, RoutedEventArgs e)
        {
            SingletonClass save = SingletonClass.Instance;
            save.Pridat(name.Text,surename.Text,number.Text,date.Text);

        }

        private void Button_ShowClick(object sender, RoutedEventArgs e)
        {
            SingletonClass show = SingletonClass.Instance;
            MessageBox.Show(show.Ukaz());

        }
    }
}

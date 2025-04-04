using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AllatokCsoportMunka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Allat> Allatok { get; set; } = new ObservableCollection<Allat>();
        public MainWindow()
        {
            InitializeComponent();
            string[] sorok = File.ReadAllLines("allatok.csv");
            foreach (string s in sorok.Skip(1))
            {
                Allat al = new Allat(s);
                Allatok.Add(al);
            }
            DataContext = this;
        }
    }
}
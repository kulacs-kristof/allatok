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
using static System.Reflection.Metadata.BlobBuilder;

namespace AllatokCsoportMunka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Allat> Allatok { get; set; } = new ObservableCollection<Allat>();

        public MainWindow()
        {
            InitializeComponent();
            FileReader("allatok.csv");
            DataContext = this;
        }

        public void FileReader(string FileName)
        {
            string[] dataIn = File.ReadAllLines(FileName);
            foreach (var book in dataIn.Skip(1))
            {
                string[] row = book.Split(';');
                Allat allat = new Allat(row[0], row[1], double.Parse(row[2]), row[3], row[4]);
                Allatok.Add(allat);
            }
        }
    }
}
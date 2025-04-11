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
using System.Windows.Shapes;

namespace AllatokCsoportMunka
{
    /// <summary>
    /// Interaction logic for ChangeAnimalWindow.xaml
    /// </summary>
    public partial class ChangeAnimalWindow : Window
    {
        public Allat al = new Allat();
        public string Nev { get; set; }
        public string Kontinens { get; set; }
        public double Elettartam { get; set; }
        public string Taplalek { get; set; }
        public string Osztaly { get; set; }

        public ChangeAnimalWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Allat allat = new Allat(Nev, Kontinens, Elettartam, Taplalek, Osztaly);
            al = allat;
            this.Close();
        }

        public ChangeAnimalWindow(Allat allat)
        {
            InitializeComponent();
            if (allat != null) 
            {
                Nev = allat.Név;
                Kontinens = allat.Kontinens;
                Elettartam = allat.Elettartam;
                Taplalek = allat.Táplálék;
                Osztaly = allat.Osztály;
            }
            DataContext = this;
        }
    }
}

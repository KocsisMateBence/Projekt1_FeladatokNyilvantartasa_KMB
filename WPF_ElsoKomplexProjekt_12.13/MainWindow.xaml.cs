using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF_ElsoKomplexProjekt_12._13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //listák létrehozása
        List<CheckBox> feladatok = new List<CheckBox>();
        List<CheckBox> toroltek = new List<CheckBox>();
        List<CheckBox> lista = new List<CheckBox>();
        public MainWindow()
        {
            InitializeComponent();
            //listboxok feltöltése
            feladatokListaja.ItemsSource = feladatok;
            toroltekListaja.ItemsSource = toroltek;                                

        }
        //feladat hozzáadása gomb
        private void ujElemHozzaadasa_Click(object sender, RoutedEventArgs e)
        {
            if (beSzoveg.Text != "")
            {
                CheckBox uj = new CheckBox();
                uj.Content = beSzoveg.Text;
                uj.Checked += new RoutedEventHandler(CheckBox_Checked);
                uj.Unchecked += new RoutedEventHandler(CheckBox_Unchecked);
                feladatok.Add(uj);
                feladatokListaja.Items.Refresh();
                beSzoveg.Text = "";
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox aktualis = (CheckBox)sender;
            aktualis.FontStyle = FontStyles.Normal;
            aktualis.Foreground = Brushes.Black;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox aktualis = (CheckBox)sender;
            aktualis.FontStyle = FontStyles.Italic;
            aktualis.Foreground = Brushes.Gray;
        }
        //feladat módosítása
        private void modositGomb_Click(object sender, RoutedEventArgs e)
        {
            
            CheckBox kijelolt = (CheckBox)feladatokListaja.SelectedItem;           
            kijelolt.Content = beSzoveg.Text;
            beSzoveg.Text = "";
            feladatokListaja.Items.Refresh();
        }
        //feladat törlése
        private void torlesGomb_Click(object sender, RoutedEventArgs e)
        {
            CheckBox kijelolt = (CheckBox)feladatokListaja.SelectedItem;
            toroltek.Add(kijelolt);
            feladatok.Remove(kijelolt);
            feladatokListaja.Items.Refresh();
            toroltekListaja.Items.Refresh();

        }
        //feladat visszaállítása
        private void visszaallitGomb_Click(object sender, RoutedEventArgs e)
        {
            CheckBox kijelolt = (CheckBox)toroltekListaja.SelectedItem;
            feladatok.Add(kijelolt);
            toroltek.Remove(kijelolt);        
            kijelolt.IsChecked = false;
            toroltekListaja.Items.Refresh();
            feladatokListaja.Items.Refresh();

        }
        //végleges törlés
        private void veglegesTorles_Click(object sender, RoutedEventArgs e)
        {
            CheckBox kijelolt = (CheckBox)toroltekListaja.SelectedItem;
            toroltek.Remove(kijelolt);
            toroltekListaja.Items.Refresh();
            
        }
        //állományba írás
        private void allomanybaIr_Click(object sender, RoutedEventArgs e)
        {
            List<string> checkboxok = new List<string>();
            foreach (CheckBox listaElem in feladatok)
            {
                int elemAllapota = 0;
                if (listaElem.IsChecked == true)
                {
                    elemAllapota = 1;
                }
                string cbJellemzo = listaElem.Content.ToString() + ";" + elemAllapota;
                checkboxok.Add(cbJellemzo);
            }
            File.WriteAllLines("lista.txt", checkboxok);
        }

        //Előző állás betöltése: HIBÁS!
        /*private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("lista.txt")) return;
            string[] teendok = File.ReadAllLines("lista.txt");
            List<CheckBox> lista = new List<CheckBox>();

            for (int i = 0; i < teendok.Length; i++)
            {
                string[] sor = teendok[i].Split(';');
                CheckBox uj = new CheckBox();
                uj.Content = sor[0];
                if (sor[1] == "True")
                {
                    uj.IsChecked = true;
                }
                uj.Checked += new RoutedEventHandler(CheckBox_Checked);
                uj.Unchecked += new RoutedEventHandler(CheckBox_Unchecked);

                if (uj.IsChecked == true)
                {
                    uj.FontStyle = FontStyles.Italic;
                    uj.Foreground = Brushes.Gray;
                }
                else
                {
                    uj.FontStyle = FontStyles.Normal;
                    uj.Foreground = Brushes.Black;
                }
                lista.Add(uj);
                feladatok.Add(uj);
            }
            feladatokListaja.ItemsSource = teendok;
        }
        */


        //Állományból beolvasás: HIBÁS!
        /* private void allomanybolOlvas_Click(object sender, RoutedEventArgs e)
         {
             feladatok.Clear();
             toroltek.Clear();
             List<CheckBox> lista = new List<CheckBox>();
             var beOlvasott = File.ReadAllLines("lista.txt");           
             foreach (var x in beOlvasott)
             {
                 CheckBox uj = new CheckBox();
                 uj.Content = x.Split(';')[0];
                 uj.IsChecked = x.Split(';')[1] == "1" ? true : false;
                 lista.Add(uj);
                 feladatokListaja.ItemsSource = lista;

             }
             feladatokListaja.Items.Refresh();
         } */
    }
}

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
using System.Xml;

namespace ApplicationTechniciens
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnRefrech_Click(object sender, RoutedEventArgs e)
        {

            if (DatePrise.Text == "")
            {
                LblDateEntrez.Content = "entrez une date!!!!!!!";
            }
            else
            {
                string dt = DatePrise.Text;
                LblDateEntrez.Content = dt;
                SalleEntrez.Content = ListSalle.Text;

            }
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            // Window wnd = new Window();
            //wnd.ShowDialog();

            AjouterReservation wnd = new AjouterReservation();
            wnd.Show();

            /*
            LblDateEntrez.Visibility = Visibility.Hidden;
            BtnAjouter.Visibility = Visibility.Hidden;
            BtnRefrech.Visibility = Visibility.Hidden;
            DatePrise.Visibility = Visibility.Hidden;
            LvDates.Visibility = Visibility.Hidden;
            ListSalle.Visibility = Visibility.Hidden;
            LblSalle.Visibility = Visibility.Hidden;
            LblTextDate.Visibility = Visibility.Hidden;
            LblTextSalle.Visibility = Visibility.Hidden;
            SalleEntrez.Visibility = Visibility.Hidden;
              */  
        }

        private void LvDates_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

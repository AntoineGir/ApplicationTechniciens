﻿using System;
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

namespace ApplicationTechniciens
{
    /// <summary>
    /// Logique d'interaction pour AjouterReservation.xaml
    /// </summary>
    public partial class AjouterReservation : Window
    {
        public AjouterReservation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Obstacle wnd = new Obstacle();
            wnd.Show();
        }
    }
}

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

namespace CursoLuckia18022021
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float primer, segundo,resultado;
        private string operacion;


        public MainWindow()
        {
            InitializeComponent();
            result.Text = "0";
            resultado = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            operacion = (string)(sender as Button).Content;
            primer = float.Parse(result.Text);
            result.Text = "0";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            segundo = float.Parse(result.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primer + segundo;
                    break;
                case "-":
                    resultado = primer - segundo;
                    break;
                case "X":
                    resultado = primer * segundo;
                    break;
                case "/":
                    resultado = primer / segundo;
                    break;
                case "^":
                    resultado = (float)Math.Pow(primer,segundo);
                    break;
            }
            result.Text = resultado.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
            primer = 0;
            segundo = 0;
            resultado = 0;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            segundo = (int)float.Parse(result.Text);
            resultado = 1;
            for (float i = segundo; i > 0; i--)
                resultado *= i;
            result.Text = resultado.ToString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Version v_version = new Version();
            v_version.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(!result.Text.Contains("."))
                result.Text += (sender as Button).Content;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" || resultado != 0)
            {
                result.Text = "";
                resultado = 0;
            }
            result.Text+= (sender as Button).Content;
        }

    }
}

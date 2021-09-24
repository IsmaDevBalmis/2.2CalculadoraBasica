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

namespace _2._2.CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operador;
        public MainWindow()
        {
            InitializeComponent();

        }

        

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                operador = operadorTextBox.Text;
                int operando1 = int.Parse(operando1TextBox.Text);
                int operando2 = int.Parse(operando2TextBox.Text);
                int resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = operando1 + operando2;
                        resultadoTextBox.Text = resultado.ToString();
                        break;
                    case "-":
                        resultado = operando1 - operando2;
                        resultadoTextBox.Text = resultado.ToString();
                        break;
                    case "*":
                        resultado = operando1 * operando2;
                        resultadoTextBox.Text = resultado.ToString();
                        break;
                    case "/":
                        if (operando2 != 0 && operando1 != 0)
                        {
                            resultado = operando1 / operando2;
                            resultadoTextBox.Text = resultado.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido realizar este cálculo");
                            resultadoTextBox.Text = "Math Error!";
                        }
                        
                        break;

                    default:
                        resultadoTextBox.Text = "Math Error!";
                        break;
                }

                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
           
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Clear();
            operando2TextBox.Clear();
            operadorTextBox.Clear();
            resultadoTextBox.Clear();
        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            operador = operadorTextBox.Text;
            switch (operador)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    calcularButton.IsEnabled = true;
                    break;

                default:
                    calcularButton.IsEnabled = false;
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace falmeidaSem2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notas : ContentPage
    {
        public Notas(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnNotasFinales_Clicked(object sender, EventArgs e)
        {
            double nota1P1= Convert.ToDouble(txtnota1P1.Text)*0.3;
            double nota2P1 = Convert.ToDouble(txtnota2P1.Text)*0.2;

            double resP1 = nota1P1 + nota2P1;
            txtParcial1.Text=resP1.ToString();

            double nota1P2 = Convert.ToDouble(txtnota2P1.Text) * 0.3;
            double nota2P2 = Convert.ToDouble(txtnota2P2.Text) * 0.2;

            double resP2 = nota1P2+nota2P2;
            txtParcial2.Text=resP2.ToString();

            double notaFinal = resP1 + resP2;
            txtNotaFinal.Text=notaFinal.ToString();

            if (notaFinal < 5)
            {
                txtEstado.Text = "Reprobado";
            }
            else if (notaFinal > 5 && notaFinal < 7)
            {
                txtEstado.Text = "Complementario";
            }
            else { 
                txtEstado.Text = "Aprobado";
            }
        }

        private void txtnota1P1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota1P1 = Convert.ToDouble(txtnota1P1.Text);
            string mensaje;
            try
            {
                if (nota1P1 < 0.1 || nota1P1 > 10)
                {
                    mensaje = "El valor no puede ser menor a 0.1 y superior a 10";
                    DisplayAlert("Mensaje de validación", mensaje, "Cerrar");
                    
                }
            }
            catch (Exception) {
                throw;
            }
        }

        private void txtnota2P1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota2P1 = Convert.ToDouble(txtnota2P1.Text);
            string mensaje;
            try
            {
                if (nota2P1 < 0.1 || nota2P1 > 10)
                {
                    mensaje = "El valor no puede ser menor a 0.1 y superior a 10";
                    DisplayAlert("Mensaje de validación", mensaje, "Cerrar");

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtnota1P2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota1P2 = Convert.ToDouble(txtnota1P2.Text);
            string mensaje;
            try
            {
                if (nota1P2 < 0.1 || nota1P2 > 10)
                {
                    mensaje = "El valor no puede ser menor a 0.1 y superior a 10";
                    DisplayAlert("Mensaje de validación", mensaje, "Cerrar");

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtnota2P2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota2P2 = Convert.ToDouble(txtnota2P2.Text);
            string mensaje;
            try
            {
                if (nota2P2 < 0.1 || nota2P2 > 10)
                {
                    mensaje = "El valor no puede ser menor a 0.1 y superior a 10";
                    DisplayAlert("Mensaje de validación", mensaje, "Cerrar");

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Internals.Profile;

namespace dguamanExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string datouno, string datodos)

        {
            InitializeComponent();
            lbluser2.Text = "Usuario conectado: "+ datouno; 
     
        }
        public void calcular(object sender, EventArgs e)
        {
            int dato2 = int.Parse(txtMinicial.Text);


            if (dato2 >= 1000 && dato2 <= 3000)
            {
                double pago_inicial = ((3000 - dato2) / 3) + (0.5 * (3000));
                txtPagMensual.Text = (pago_inicial).ToString();

            }
            else
            {
               // DisplayAlert("Resultado", "Errro rango permitido 1000 a 3000", "Ok");
                txtPagMensual.Text = "Rango no Permitido";
                //txtPagMensual.Text = "";
            }
            

        }
        private void btnAbrir_Clicked2(object sender, EventArgs e)


        {
            String dato1 = lbluser2.Text;

            String dato2 = txtNombre.Text;
            int dato3= int.Parse(txtMinicial.Text);
            int dato4 = int.Parse(txtPagMensual.Text);

            Navigation.PushAsync(new Registro2(dato1, dato2, dato3,dato4));


        }

        private void txtMinicial_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dguamanExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
        }
        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string dato1 = txtDato.Text;

            string dato2 = txtDatodos.Text;
            string resultado = "";
         //   Navigation.PushAsync(new Registro(dato1, dato2));
            
                        if (dato1=="estudiante2023" && dato2=="uisrael2023")
                        {
                            resultado = "Ingreso correcto iniciando...";
                            Navigation.PushAsync(new Registro(dato1, dato2));
                            DisplayAlert("Resultado", resultado, "Ok");
                        }
                        else
                        {
                            resultado = "Error usuario y/o Clave incorrectos...";
                            DisplayAlert("Resultado", resultado, "Ok");
                        }
                        
            // 
        }
    }
}
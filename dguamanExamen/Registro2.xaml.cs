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
    public partial class Registro2 : ContentPage
    {
        public Registro2(string datouno, string datodos, double minical, double pag_mensual)

        {
            InitializeComponent();
            lbluser3.Text =  datouno;
            lbluser4.Text = "Nombre: "+datodos;

            
            double total = ((minical)+(pag_mensual))*3;

            lblPagoTotal.Text = "Pago Total: "+total.ToString();
     
        }
    }
}
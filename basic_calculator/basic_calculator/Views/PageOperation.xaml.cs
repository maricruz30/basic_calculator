using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace basic_calculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageOperation : ContentPage
    {
        public PageOperation()
        {
            InitializeComponent();
        }

        double num1 = 0, num2 =0, total = 0;

        private async void Enviar(double resultado)
        {
            var result = new Models.Operation
            {
                Resultoperation = resultado.ToString()

            };

            var page = new Views.PageResult();
            page.BindingContext = result;
            await Navigation.PushAsync(page);

        }

        private void sumar(double num1, double num2)
        {
            total = num1 + num2;
            Enviar(total);
        }
        private void restar (double num1, double num2)
        {
            total = num1 - num2;
            Enviar(total);
        }

        private void multiplicar(double num1, double num2)
        {
            total = num1 * num2;
            Enviar(total);
        }

        private void dividir(double num1, double num2)
        {
            total = num1 / num2;
            Enviar(total);
        }
        private void btnSumar_Clicked(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(txtNum1.Text);
             num2 = Convert.ToDouble(txtNum2.Text);
             sumar(num1, num2);

        }

        private void btnRestar_Clicked(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            restar(num1, num2);
        }

        private void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            multiplicar(num1, num2);

        }

        private void btnDividir_Clicked(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            dividir(num1, num2);
        }
    }
}
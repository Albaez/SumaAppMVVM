using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace SumaAppMVVM.Droid
{
    using SumaAppMVVM.Droid;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    namespace SumaAppMVVM.Droid
    {
        public partial class SumaPage : ContentPage
        {
            public SumaPage()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            private void OnSumarClicked(object sender, EventArgs e)
            {


                if (string.IsNullOrEmpty(valor1.Text) || string.IsNullOrEmpty(valor2.Text))
                {
                    resultado.Text = "Por favor ingrese ambos valores.";
                }
                else
                {
                    double v1 = double.Parse(valor1.Text);
                    double v2 = double.Parse(valor2.Text);
                    resultado.Text = $"El resultado de la suma es: {v1 + v2}";
                }
            }
        }
    }
}
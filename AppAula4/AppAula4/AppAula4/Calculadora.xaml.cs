using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppAula4
{
    public partial class Calculadora : ContentPage
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        public void OnClick(object sender, EventArgs e)
        {
            var text = sender as Button;

            switch (text.Text)
            {
                case "C":
                    txtDisplay.Text = string.Empty;
                    break;
                case "=":
                    CalcularValores(txtDisplay.Text);
                    break;
                default:
                    txtDisplay.Text += text.Text;
                    break;
            }
        }

        private void CalcularValores(string text)
        {
            throw new NotImplementedException();
        }
    }
}

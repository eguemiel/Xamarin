using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppAula4
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public void OnClick(object sender, EventArgs e)
        {
            lblStatus.Text = string.Format("Curso {0} Iniciado", txtCurso.Text);
            lblStatus.TextColor = Color.Green;
        }
    }
}

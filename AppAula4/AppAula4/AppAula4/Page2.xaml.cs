using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppAula4
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        public void OnClick(object sender, EventArgs e)
        {
            string status = string.Empty;
            string nome = txtNome.Text;
            string empresa = txtEmpresa.Text;
            status = string.Format("{0} - {1} incluído", nome, empresa);
            lblStatus.Text = status;
        }
    }
}

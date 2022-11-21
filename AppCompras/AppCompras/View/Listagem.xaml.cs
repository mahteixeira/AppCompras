using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCompras.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listagem : ContentPage
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void Novo_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NovoProduto());
            }
            catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Somar_Clicked(object sender, EventArgs e)
        {

        }

        protected override void OnAppearing()
        {
            System.Threading.Tasks.Task.Run(() =>)
        }
    }
}
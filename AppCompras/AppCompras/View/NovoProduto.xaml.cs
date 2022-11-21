using AppCompras.Model;
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
    public partial class NovoProduto : ContentPage
    {
        public NovoProduto()
        {
            InitializeComponent();
        }

        private async void Tbi_Salvar(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto
                {
                    descricao = txt_descricao.Text,
                    quantidade = Convert.ToDouble(txt_quantidade.Text),
                    preco = Convert.ToDouble(txt_preco.Text),
                };

                await App.Database.insert(p);

                await DisplayAlert("Sucesso!", "Produto Cadastrado", "OK");

                Navigation.PushAsync(new Listagem());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
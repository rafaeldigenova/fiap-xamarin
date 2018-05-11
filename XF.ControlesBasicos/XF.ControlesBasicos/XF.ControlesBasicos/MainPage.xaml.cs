using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ControlesBasicos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if (ConfigPage.configuracoes != null && ConfigPage.configuracoes.AceitaReceberEmail)
            {
                DisplayAlert("Mensagem"
                , $"Email enviado para {ConfigPage.configuracoes.Email}", "OK");
            }
            else
            {
                DisplayAlert("Atenção"
                    , "E-mail não autorizado", "OK");
            }
        }

        void btnConfiguracao_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ConfigPage());
        }
    }
}

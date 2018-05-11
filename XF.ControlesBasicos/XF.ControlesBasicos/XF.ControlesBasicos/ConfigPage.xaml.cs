using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ControlesBasicos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfigPage : ContentPage
	{
        public static Configuracoes configuracoes;

		public ConfigPage ()
		{
            if (configuracoes == null)
                configuracoes = new Configuracoes();

            BindingContext = configuracoes;

			InitializeComponent ();
		}

        public void switchReceberEmail_Changed()
        {

        }
    }
}
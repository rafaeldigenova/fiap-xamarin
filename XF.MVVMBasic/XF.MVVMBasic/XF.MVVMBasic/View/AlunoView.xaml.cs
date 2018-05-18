using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVMBasic.ViewModel;

namespace XF.MVVMBasic.View
{
	[XamlCompilation(XamlCompilationOptions.Skip)]
	public partial class AlunoView : ContentPage
	{
        public AlunoView()
        {
            var alunos = AlunoViewModel.GetAlunos();
            BindingContext = alunos;
            //lstAlunos.ItemsSource = alunos;
            InitializeComponent();
        }

        private async void btnAdicionarAlunos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovoAlunoView());
        }
        
    }
}
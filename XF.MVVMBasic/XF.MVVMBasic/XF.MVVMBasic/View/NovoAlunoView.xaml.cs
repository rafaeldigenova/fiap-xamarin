using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVMBasic.Model;

namespace XF.MVVMBasic.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoAlunoView : ContentPage
    {
        public NovoAlunoView()
        {
            InitializeComponent();
        }

        private async void btnCadastrarAluno_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                await DisplayAlert("Atenção!", "Por favor, informe o nome do aluno", "Ok");
                return;
            }

            var aluno = new Aluno()
            {
                Nome = txtName.Text,
                Email = txtEmail.Text,
                RM = txtRM.Text
            };

            App.AlunoVM.Adicionar(aluno);

            await DisplayAlert("Sucesso!", "Aluno inserido", "Ok!");
            
        }
    }
}
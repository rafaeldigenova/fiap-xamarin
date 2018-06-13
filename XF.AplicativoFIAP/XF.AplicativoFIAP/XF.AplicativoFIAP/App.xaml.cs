using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XF.AplicativoFIAP.ViewModel;

namespace XF.AplicativoFIAP
{
    public partial class App : Application
	{
        public static ProfessorViewModel ProfessorVM { get; set; }
		public App ()
        {
			InitializeComponent();
            InitializeApplication();    

			MainPage = new XF.AplicativoFIAP.MainPage();
		}

        private void InitializeApplication()
        {
            if (ProfessorVM == null) ProfessorVM = new ProfessorViewModel();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XF.ControlesBasicos
{
    public class Configuracoes : INotifyPropertyChanged
    {
        private bool ativo;

        public bool Ativo
        {
            get { return ativo; }
            set {
                ativo = value;

                if (!ativo) Email = string.Empty;
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set {
                email = value;
                EventPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void EventPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRH.Models.Entidades
{
    [Table("Configuracoes")]
    public class Configuracao : INotifyPropertyChanged
    {
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _id;

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _valor;

        [NotNull]
        public string Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                this._valor = value;
                OnPropertyChanged(nameof(Valor));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileRH.Views.PaginaPrincipal
{
    public class ItemDeMenu
    {
        public string Titulo { get; set; }
        public string Icone { get; set; }
        public Func<bool> Acao { get; set; }
    }
}

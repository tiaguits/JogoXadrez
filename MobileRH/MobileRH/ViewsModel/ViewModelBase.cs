using MobileRH.Utils;
using MobileRH.ViewsModel.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileRH.ViewsModel
{
    public class ViewModelBase : ObservableBaseObject
    {
        private INavigationService _navigationService;
        private IMessageService _messageService;

        public INavigationService NavigationService { get { return _navigationService; } }
        public IMessageService MessageService { get { return _messageService; } }

        public ViewModelBase()
        {
            _navigationService = DependencyService.Get<INavigationService>();
            _messageService = DependencyService.Get<IMessageService>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace Moanda.ViewModel
{
    public class MainViewModel:ReactiveObject
    {
        private string _mainIconPath = @"\Payload\Icon\circular_menu.ico";
        public string MainIconPath
        {
            get => _mainIconPath;
            set => this.RaiseAndSetIfChanged(ref _mainIconPath, value);
        }
    }
}

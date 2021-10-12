using Shop.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class MainWindowViewModel : NotificationObject
    {
        public string selectedTitle = "Best Shop ｡ﾟ( ﾟஇ‸இﾟ)ﾟ｡";

        public string Title { 
            get => selectedTitle;
            set => selectedTitle = value;
        }
    }
}

using Shop.Model;
using Shop.Utilities;
using Shop.ViewModel;
using System;
using System.Collections.ObjectModel;

namespace Shop
{
    public class MainWindowViewModel : NotificationObject
    {
        public string selectedTitle = "Shop";

        public string Title
        {
            get => selectedTitle;
            set => selectedTitle = value;
        }
        public ItemListViewModel ItemList { get; set; }
        public MessageBoxViewModel MessageBox { get; set; }

        public MainWindowViewModel()
        {
            ItemList = new ItemListViewModel();
            MessageBox = ItemList.MessageBox;
        }
    }
}

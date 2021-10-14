using System.Collections.ObjectModel;
using System.Linq;
using Shop.Model;
using Shop.Utilities;

namespace Shop.ViewModel
{
    public class ItemListViewModel : NotificationObject
    {
        private Item selectedItem;

        private int selectedItemIndex;

        public ObservableCollection<Item> Items { get; set; }
        public ObservableCollection<Item> ItemsInCart { get; set; }

        public bool ShowAllItems { get; set; }
        public bool ShowCartItems { get; set; }

        public Item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                RaisePropertyChanged("selectedItem");
            }
        }

        public int SelectedItemIndex
        {
            get { return selectedItemIndex; }
            set
            {
                selectedItemIndex = value;
            }
        }

        public SimpleCommand AddToCartCommand { get; set; }
        public SimpleCommand GetCartCommand { get; set; }
        public SimpleCommand CloseCartCommand { get; set; }
        public SimpleCommand RemoveFromCartCommand { get; set; }

        private void PutIntoCart(object item)
        {
            ItemsInCart.Add(selectedItem);
        }
        private void RemoveFromCart(object item)
        {
            ItemsInCart.Remove(selectedItem);
        }

        private void GetCart(object obj)
        {
            ShowAllItems = false;
            ShowCartItems = true;
            RaisePropertyChanged("ShowAllItems");
            RaisePropertyChanged("ShowCartItems");
        }
        
        private void CloseCart(object obj)
        {
            ShowAllItems = true;
            ShowCartItems = false;
            RaisePropertyChanged("ShowAllItems");
            RaisePropertyChanged("ShowCartItems");
        }

        public ItemListViewModel()
        {
            // To Test enable of Button you can only put in 5 products :))
            AddToCartCommand = new SimpleCommand(PutIntoCart, obj => ItemsInCart.Count < 5);
            GetCartCommand = new SimpleCommand(GetCart);
            CloseCartCommand = new SimpleCommand(CloseCart);
            RemoveFromCartCommand = new SimpleCommand(RemoveFromCart);

            ShowAllItems = true;
           // Put example Products
           Items = new ObservableCollection<Item>()
            {
                new Item(){Name="Product 1", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"},
                new Item(){Name="Product 2", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"},
                new Item(){Name="Product 3", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"},
                new Item(){Name="Product 4", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"},
                new Item(){Name="Product 5", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"},
                new Item(){Name="Product 6", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"},
                new Item(){Name="Product 7", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"},
                new Item(){Name="Product 8", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"},
                new Item(){Name="Product 9", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"},
                new Item(){Name="Product 10", Price=10, Description="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut"}
            };
            ItemsInCart = new ObservableCollection<Item>();
        }
    }
}

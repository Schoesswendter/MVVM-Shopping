using System.Collections.ObjectModel;
using Shop.Utilities;

namespace Shop.ViewModel
{
    class ItemListViewModel : NotificationObject
    {
        private Item selectedPhone;

        private int selectedPhoneIndex;

        public ObservableCollection<Item> Phones { get; set; }

        public Item SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                RaisePropertyChanged("SelectedPhone");
            }
        }

        public int SelectedPhoneIndex
        {
            get { return selectedPhoneIndex; }
            set
            {
                selectedPhoneIndex = value;
            }
        }
    }
}

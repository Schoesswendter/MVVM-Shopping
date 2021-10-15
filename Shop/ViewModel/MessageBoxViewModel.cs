using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;
using Shop.Utilities;

namespace Shop.ViewModel
{
    public class MessageBoxViewModel : NotificationObject
    {
        private string _date = DateTime.Now.ToString("HH:mm");
        private string _information = "Welcome to our little Shop :-)";

        public string Date
        {
            get => _date; set
            {
                _date = value;
                RaisePropertyChanged(nameof(Date));
            }
        }
        public string Information
        {
            get => _information; set
            {
                _information = value;
                RaisePropertyChanged(nameof(Information));
            }
        }
        public void CreateMessage(string type, string itemName)
        {
            DateTime currentDate = DateTime.Now;
            Date = currentDate.ToString("HH:mm");

            switch (type)
            {
                case "add":                   
                    Information = $"{itemName} was added to your Shopping Cart!";
                    break;

                case "remove":
                    Information = $"{itemName} was removed from your Shopping Cart!";
                    break;

                default:
                    break;
            }
        }

        public MessageBoxViewModel()
        {
        }
    }
}

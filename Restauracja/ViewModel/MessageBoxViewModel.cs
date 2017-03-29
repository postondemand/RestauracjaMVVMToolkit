using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Restauracja.Enums;
using Restauracja.Messages;
using Restauracja.Model;

namespace Restauracja.ViewModel
{
    public class MessageBoxViewModel : ViewModelBase
    {
        public ObservableCollection<DishModel> Positions { get; set; } = new ObservableCollection<DishModel>();

        private double _cost;
        private const string CostPropertyName = "Cost";
        public double Cost
        {
            get { return _cost; }
            set
            {
                Set(CostPropertyName, ref _cost, value);
            }
        }

        public MessageBoxViewModel()
        {
            Messenger.Default.Register<OrderDetailsMessage>(this, MessageType.OrderDetailsContent, ProcessMessage);
        }

        private void ProcessMessage(OrderDetailsMessage message)
        {
            Positions.Clear();
            message.Positions.ForEach((item) =>
            {
                Positions.Add(item);
            });
            Cost = message.Cost;
        }
    }
}

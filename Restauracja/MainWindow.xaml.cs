using System.Windows;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;
using Restauracja.Enums;
using Restauracja.Messages;
using Restauracja.ViewModel;

namespace Restauracja
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Messenger.Default.Register<OrderDetailsMessage>(this, MessageType.OrderDetailsCreateWindow, ShowDetailsWindow);
        }

        private void ShowDetailsWindow(OrderDetailsMessage content)
        {
            var view = new MessageBox();
            Messenger.Default.Send(content, MessageType.OrderDetailsContent);
            view.ShowDialog();
        }
    }
}

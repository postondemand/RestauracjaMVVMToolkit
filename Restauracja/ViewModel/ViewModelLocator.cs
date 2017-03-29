using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Restauracja.Messages;

namespace Restauracja.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MessageBoxViewModel>();

        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public MessageBoxViewModel MessageBox
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MessageBoxViewModel>();
            }
        }

        public static void Cleanup()
        {
           
        }
    }
}


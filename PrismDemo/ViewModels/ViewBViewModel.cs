using Prism.Events;
using Prism.Mvvm;
using PrismDemo.Events;

namespace PrismDemo.ViewModels
{
    class ViewBViewModel: BindableBase
    {
        private string _message = "ViewB";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        
        public ViewBViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<UpdateEvent>().Subscribe(Updated);
        }

        private void Updated(string obj)
        {
            Message = obj;
        }
    }
}

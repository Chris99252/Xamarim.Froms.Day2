using Prism.Commands;
using Prism.Navigation;
using System.ComponentModel;
using Xamarin.Forms;

namespace XFCommand.ViewModels
{
    // xfFody1INotifyPropertyChanged
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        // xfFody1INotifyPropertyChangedImp
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        // xfDataBindingCommandWithParameter(泛型)

        public DelegateCommand<string> BtnCommand { get; set; }

        public DelegateCommand<Button> Btn3Command { get; set; }

        public MainPageViewModel()
        {
            // x => CommandParameter
            BtnCommand = new DelegateCommand<string>((x) =>
            {
                Title = x;
            });

            Btn3Command = new DelegateCommand<Button>(x =>
            {
                Title = $"這是綁定 Button 參數 : {x.Text}";
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
using JokesApp.ViewModels;

namespace JokesApp.Views
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage(MainPageViewModel vm)
        {
            BindingContext=vm;
            InitializeComponent();
        }
        

       
    }

}

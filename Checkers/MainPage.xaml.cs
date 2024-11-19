using Checkers.ViewModel;

namespace Checkers
{
    public partial class MainPage : ContentPage
    {

        public MainPage(BoardViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }

}

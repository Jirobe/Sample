using PastQuestionPapers_CSharp.ViewModels;
using Xamarin.Forms;

namespace PastQuestionPapers_CSharp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<MainPageItem>(this, "Page_001",
                async (_) =>
                {
                    await Navigation.PushModalAsync(new Page_001(), true);
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            //イベントの破棄
            MessagingCenter.Unsubscribe<MainPageItem>(this, "Page_001");
        }
    }
}

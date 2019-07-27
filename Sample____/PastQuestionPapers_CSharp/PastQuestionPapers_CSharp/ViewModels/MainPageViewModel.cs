using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace PastQuestionPapers_CSharp.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        private string list1_Title;
        private ObservableCollection<MainPageItem> items;

        public ObservableCollection<MainPageItem> Items
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        public string List1_Title
        {
            get { return list1_Title; }
            set { SetProperty(ref list1_Title, value); }
        }

        public MainPageViewModel()
        {
            List1_Title = "";
            Items = new ObservableCollection<MainPageItem>()
            {
                new MainPageItem(){ Number="画面遷移", Title="ほげ" , NextPageMessage="Page_001"},
            };
        }
    }
}

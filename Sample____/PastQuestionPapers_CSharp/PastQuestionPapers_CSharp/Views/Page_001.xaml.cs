using PastQuestionPapers_CSharp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PastQuestionPapers_CSharp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page_001 : ContentPage
	{
		public Page_001 ()
		{
			InitializeComponent ();

            BindingContext = new Page_001ViewModel();

        }
	}
}
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace PastQuestionPapers_CSharp.ViewModels
{
    class Page_001ViewModel : BaseViewModel
    {

        private string question;
        private string text;
        private string answer;
        private string execute;
        private string result;

        public string Question
        {
            get { return question; }
            set { SetProperty(ref question, value); }
        }
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }
        public string Answer
        {
            get { return answer; }
            set { SetProperty(ref answer, value); }
        }
        public string Execute
        {
            get { return execute; }
            set { SetProperty(ref execute, value); }
        }
        public string Result
        {
            get { return result; }
            set { SetProperty(ref result, value); }
        }

        public ICommand ExecuteCommand => new Command(async () =>
        {
            Text = @"
var x = 1;
var y = 2;
x + y
";

            try
            {
                int a =await CSharpScript.EvaluateAsync<int>(Text);

                Result = a.ToString();
            }
            catch (Exception e)
            {
                Result = e.ToString();
            }

        });

        public Page_001ViewModel()
        {
            Text = "";
            Execute ="実行";

        }
    }
}

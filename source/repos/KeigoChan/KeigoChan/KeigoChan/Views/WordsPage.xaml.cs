using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KeigoChan.ViewModels;

namespace KeigoChan.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WordsPage : ContentPage
	{
		public WordsPage ()
		{
            BindingContext = new WordsViewModel();
            InitializeComponent ();
		}

        //private void InputWord_Completed(object sender, EventArgs e)
        //{
        //    var input = InputWord.Text;

        //}
    }
}
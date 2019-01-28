using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KeigoChan.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WordsPage : ContentPage
	{
		public WordsPage ()
		{
			InitializeComponent ();
		}

        private void InputWord_Completed(object sender, EventArgs e)
        {
            var input = InputWord.Text;

        }
    }
}
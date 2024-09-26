using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public const string BUTTON_TEXT = "Register";

		public RegisterPage ()
		{
			InitializeComponent ();
		}

        private void registerButton_Click(object sender, EventArgs e)
        {
			errorMessage.Text = "Not supported";
        }
    }
}
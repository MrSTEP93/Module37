using Practice.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ToValuesPages(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ValuesPage());
        }
    }
}

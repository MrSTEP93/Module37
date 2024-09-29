using Practice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practice.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValuesPage : ContentPage
    {
        ITemperatureRepository temperatureRepository;
        IPressureRepository pressureRepository;

        public ValuesPage()
        {
            InitializeComponent();

            temperatureRepository = new TemperatureRepositoryRandom();
            pressureRepository = new PressureRepositoryRandom();

            GetTemperature();
            GetPressure();
        }

        private void GetTemperature()
        {
            TemperIn.Text = $"{temperatureRepository.GetInT()} ℃";
            TemperOut.Text = $"{temperatureRepository.GetOutT()} ℃";
        }

        private void GetPressure()
        {
            Pressure.Text = $"{pressureRepository.GetPressure()} mm Hg";
        }
    }
}
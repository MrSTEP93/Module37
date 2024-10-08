﻿using Android.Graphics;
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
	public partial class DevicesPage : ContentPage
	{
        public DevicesPage()
        {
            InitializeComponent();
            ClimateButton.Clicked += ToClimatePage;
            GetDevices();
        }

        /// <summary>
        /// Метод для выгрузки устройств
        /// </summary>
        public void GetDevices()
        {
            // Создадим некий список устройств.
            // В реальном приложении они могут доставаться из базы или веб-сервиса.
            var homeDevices = new List<string>()
           {
               "Коньдиционер",
               "Чайник",
               "Стиральная машина",
               "Посудомоечная машина",
               "Мультиварка",
               "Водонагреватель",
               "Плита",
               "Микроволновая печь",
               "Духовой шкаф",
               "Холодильник",
               "Увлажнитель воздуха",
               "Телевизор",
               "Пылесос",
               "Музыкальный центр",
               "Компьютер",
               "Игровая консоль"
           };

            // Создадим новый стек
            var innerStack = new StackLayout();

            // Сохраним в стек имеющиеся данные, используя свойство Children
            foreach (string deviceName in homeDevices)
            {
                var deviceLabel = new Label() { Text = $"   {deviceName}", FontSize = 17, };
                //innerStack.Children.Add(new Label());
                innerStack.Children.Add(deviceLabel);
            }

            // Сохраним стек внутрь уже имеющегося в xaml-файле блока прокручиваемой разметки
            scrollView.Content = innerStack;

        }

        private void ClimateButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void ToClimatePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClimatePage());
        }
    }
}
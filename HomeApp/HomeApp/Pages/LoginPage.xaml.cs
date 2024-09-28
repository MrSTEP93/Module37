using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        // Константа для текста кнопки
        public const string BUTTON_TEXT = "Войти";
        // Переменная счетчика
        public static int loginCouner = 0;

        public LoginPage()
        {
            InitializeComponent();
            loginButton.Clicked += ToDevicesPage;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (loginCouner == 0)
            {
                // Если первая попытка - просто меняем сообщения
                loginButton.Text = $"⌛ Выполняется вход..";
                
            }
            else if (loginCouner > 5) // Слишком много попыток - показываем ошибку
            {
                // Деактивируем кнопку
                loginButton.IsEnabled = false;
                // Показываем текстовое сообщение об ошибке
                //errorMessage.Text = "Слишком много попыток! Попробуйте позже.";
                // Получаем последний дочерний элемент, используя свойство Children, затем выполняем распаковку
                var infoMessage = (Label)stackLayout.Children.Last();
                // Задаем текст элемента
                infoMessage.Text = "Слишком много попыток! Попробуйте позже";
                /* Добавляем элемент через свойство Children
                stackLayout.Children.Add(new Label
                {
                    Text = "Слишком много попыток! Попробуйте позже.",
                    TextColor = Color.Red,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    Padding = new Thickness()
                    {
                        Bottom = 30,
                        Left = 10,
                        Right = 10,
                        Top = 30
                    }
                });
                */

            }/*
            else
            {
                // Изменяем текст кнопки и показываем количество попыток входа
                loginButton.Text = $"⌛ Выполняется вход..   ";
                Thread.Sleep(3000);
            }
            */
            loginButton.Text = BUTTON_TEXT;
            // Увеличиваем счетчик
            loginCouner += 1;
            counter.Text = $"Попыток входа: {loginCouner}";
        }

        private async void ToDevicesPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DevicesPage());
        }

        private async void ToMergeGridPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MergeGridPage());
        }
    }
}
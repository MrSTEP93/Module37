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
                errorMessage.Text = "Слишком много попыток! Попробуйте позже.";
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
    }
}
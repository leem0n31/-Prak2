﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace WpfApp1
{
    public partial class Zadanie4 : Window
    {
        private const string CorrectPassword = "pididi";
        public Zadanie4()
        {
            InitializeComponent();
        }
        private void CheckPassword(object sender, RoutedEventArgs e)
        {
            if (PasswordInput.Text == CorrectPassword)
            {
                PasswordResult.Text = "Доступ разрешен. Секретное сообщение: 'Вы прошли проверку!'";
            }
            else
            {
                PasswordResult.Text = "Неверный пароль. Попробуйте еще раз."; PasswordInput.Clear();
                PasswordInput.Focus();
            }
        }
    }
}
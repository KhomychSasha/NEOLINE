﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.ServiceReference1;

namespace UI
{
    public partial class LoginUser : UserControl
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void ClickBTNSignUp(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();

            //MW.canvasDen.Children.Add(new RegistrationUser());
            
        }
        public static BitmapImage ConvertByteArrayToBitmapImage(byte[] bytes)
        {
            var stream = new MemoryStream(bytes);
            stream.Seek(0, SeekOrigin.Begin);
            var image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();
            return image;
        }
        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }

        private string HashPass(string pass)
        {
            byte[] EncodePass = Encoding.Unicode.GetBytes(pass);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] HashBytesFromPass = md5.ComputeHash(EncodePass);

            string HashPass = null;

            foreach (var v in HashBytesFromPass)
            {
                HashPass += string.Format("{0:x2}", v);
            }

            return HashPass;
        }

        private void ClickBTNSignIn(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client();

            if (client.VerificationOnExistUser(TBLogin.Text,HashPass(PBPass.Password)) == true)
            {
                
            }
            else
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace LemonGit
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TryButton_Click(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 0; i < 10; i++)
            {

            }
        }
    }
    public class tryDataBinding
    {
        public string name { get; set; }
        public string composition { get; set; }
        public DateTime realeaseDateTIme { get; set; }
        public void Recording()
        {
            this.name = "Charlie";
            this.composition = "An exanple composition";
            this.realeaseDateTIme = new DateTime(2006, 2, 17);
        }
        public string onlineSumary
        {
            get 
        }

    }
}

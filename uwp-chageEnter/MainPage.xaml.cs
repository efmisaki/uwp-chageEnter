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

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace uwp_chageEnter
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

 

        private void textBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
        
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
               
                System.Diagnostics.Debug.WriteLine("OK");
                switch (((TextBox)sender).Name)
                {
                    case "textBox":
                        textBox_Copy.Focus(FocusState.Pointer);
                        System.Diagnostics.Debug.WriteLine("textBoxでEnterが押下されました。");
                        break;
                    case "textBox_Copy":
                        textBox.Focus(FocusState.Pointer);
                        System.Diagnostics.Debug.WriteLine("textBox_CopyでEnterが押下されました。");
                        break;
                }

            }
        }

    }
}

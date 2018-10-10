using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace App9
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    /// 
    
    
    public sealed partial class MainPage : Page
    {
        public static int Dic;
        public MainPage()
        {
            this.InitializeComponent();
            
            for(int i = 1; i <= App.contacts.GetLength(); i++)
            {
                listbox.Items.Add(App.contacts.GetElem(i).name);
            }
          
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
           // MainPage1 mainPage = new MainPage1();
            Type sourcePageType = typeof(addpage);
            Frame.Navigate(sourcePageType);
            
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dic = App.contacts.Locate(listbox.SelectedItem.ToString());
            Frame.Navigate(typeof(SelectedPage));
        }

        private void Textbox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            bool flag= false;
                if (e.Key==Windows.System.VirtualKey.Enter)
                {
                    foreach (var item in listbox.Items)
                    {
                    string v = (textbox.Text.Trim());
                    
                    if (v.Equals(item.ToString()))
                        {
                            Dic = App.contacts.Locate(item.ToString());
                            Frame.Navigate(typeof(SelectedPage));
                            flag = true;
                        }
                    
                    }
                if (flag == false)
                {
                    var dialog = new MessageDialog("联系人不存在");
                    dialog.Commands.Add(new UICommand("好的", cmd => { }, commandId: 0));
                    dialog.ShowAsync();

                }
            }
          

        }
        
    }
}

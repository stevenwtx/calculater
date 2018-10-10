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

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace App9
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class SelectedPage : Page
    {
        public SelectedPage()
        {
            this.InitializeComponent();
            Node person = new Node(App.contacts.GetElem(MainPage.Dic).name,App.contacts.GetElem(MainPage.Dic).phone, App.contacts.GetElem(MainPage.Dic).QQ, App.contacts.GetElem(MainPage.Dic).Wechat);
            name.Text = person.name;
            name.IsReadOnly=true;
            phone.Text = person.phone;
            phone.IsReadOnly = true;
            QQ.Text = person.QQ;
            QQ.IsReadOnly = true;
            wechat.Text = person.Wechat;
            wechat.IsReadOnly = true;
            save.IsEnabled = false;
            
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // MainPage1 mainPage = new MainPage1();
            Edit.IsEnabled = false;
            save.IsEnabled = true;
            name.IsReadOnly = false;
            phone.IsReadOnly = false;
            QQ.IsReadOnly = false;
            wechat.IsReadOnly = false;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
         

             Node person = App.contacts.GetElem(MainPage.Dic);
            String tn = person.name;
            person.name = name.Text;
             person.phone = phone.Text;
             person.QQ = QQ.Text;
            person.Wechat = wechat.Text;
            App.conn.Execute("Update Contact set Name=?,Phone=?,QQ=?,Wechat=? where Name=?", name.Text, phone.Text, QQ.Text, wechat.Text, tn);
            Frame.Navigate(typeof(MainPage));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            App.contacts.Delete(MainPage.Dic);
            App.conn.Execute("delete from Contact where name=?",name.Text);
            Frame.Navigate(typeof(MainPage));
        }
    }
}

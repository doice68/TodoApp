using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using AvaloniaApplication27.ViewModels;
using System;

namespace AvaloniaApplication27.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void PageChanged(object sender, SelectionChangedEventArgs args) 
        {

        }
        public void ToPage1(object sender, GotFocusEventArgs args) 
        {
            ((MainWindowViewModel)DataContext).ToPage1();
        }
        public void ToPage2(object sender, GotFocusEventArgs args)
        {
            ((MainWindowViewModel)DataContext).ToPage2();
        }
    }
}

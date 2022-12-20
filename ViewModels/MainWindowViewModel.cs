using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Avalonia.Controls;
using AvaloniaApplication27.Models;
using AvaloniaApplication27.Views;
using ReactiveUI;

namespace AvaloniaApplication27.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        double opacity = 0.5;
        double Opacity
        {
            get => opacity;
            set => this.RaiseAndSetIfChanged(ref opacity, value);
        }
        TodoItemsListView todoItemsListPage;
        SettingsView settingsView;

        int selectedPageIndex;
        int SelectedPageIndex 
        {
            get => selectedPageIndex;
            set => this.RaiseAndSetIfChanged(ref selectedPageIndex, value);
        }
        UserControl currentPage;
        UserControl CurrentPage 
        {
            get => currentPage;
            set => this.RaiseAndSetIfChanged(ref currentPage, value);
        }
        ObservableCollection<TodoItemViewModel> todoItems = new ObservableCollection<TodoItemViewModel>();
        public ObservableCollection<TodoItemViewModel> TodoItems 
        {
            get => todoItems;
            set => this.RaiseAndSetIfChanged(ref todoItems, value);
        }
        string itemText = "";
        string ItemText 
        {
            get => itemText;
            set => this.RaiseAndSetIfChanged(ref itemText, value);
        }
        public MainWindowViewModel() 
        {
            todoItemsListPage = new TodoItemsListView();
            settingsView = new SettingsView();
            CurrentPage = todoItemsListPage;

            TodoItems.Add(new TodoItemViewModel(this, "test1"));
            TodoItems.Add(new TodoItemViewModel(this, "test2"));
            TodoItems.Add(new TodoItemViewModel(this, "test3"));
        }
        public void Add() 
        {
            TodoItems.Add(new TodoItemViewModel(this, ItemText));
            ItemText = "";
        }

        public void ToPage1() 
        {
            CurrentPage = todoItemsListPage;
        }
        public void ToPage2() 
        {
            CurrentPage = settingsView;
        }
    }
}

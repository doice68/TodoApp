using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using AvaloniaApplication27.ViewModels;
using ReactiveUI;

namespace AvaloniaApplication27.Models
{
    public class TodoItemViewModel : ReactiveObject
    {
        MainWindowViewModel windowViewModel;
        string itemName = "";
        string ItemName 
        {
            get => itemName;
            set => this.RaiseAndSetIfChanged(ref itemName, value);
        }
        public TodoItemViewModel(MainWindowViewModel windowViewModel, string name)
        {
            this.windowViewModel = windowViewModel;
            this.ItemName = name;
        }
        public void Delete() 
        {
            windowViewModel.TodoItems.Remove(this);
        }
    }
}

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace VisualAvalon.Views
{
    public class TodoListView : UserControl
    {
        public TodoListView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

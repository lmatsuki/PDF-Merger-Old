using PDFMerger.Wpf.SharedKernel;
using System.Windows;
using System.Windows.Controls;

namespace PDFMerger.Wpf.Modules
{
    /// <summary>
    /// Interaction logic for ListBox.xaml
    /// </summary>
    public partial class ListBox : UserControl
    {
        public ListBox()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SelectedFileProperty =
            DependencyProperty.Register("SelectedFile", typeof(string), typeof(ListBox));

        public Mediator Mediator { get; set; }

        public string SelectedFile
        {
            get { return (string)GetValue(SelectedFileProperty); }
            set { SetValue(SelectedFileProperty, value); }
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedFile = filesToMerge.SelectedItem as string;
            Send(SelectedFile);
        }

        public void Send(object message)
        {
            Mediator.Send(message);
        }

        public void Notify(object message)
        {

        }
    }
}

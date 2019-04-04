using PDFMerger.Wpf.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
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

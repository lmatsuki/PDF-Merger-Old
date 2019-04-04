using PDFMerger.Wpf.SharedKernel;
using PDFMerger.Wpf.ViewModels;
using System.Windows;

namespace PDFMerger.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MergeFilesViewModel();
            InitializeComponent();

            Mediator = new Mediator(toolBar, listBox);
            toolBar.Mediator = Mediator;
            listBox.Mediator = Mediator;
        }

        public Mediator Mediator { get; set; }
    }
}

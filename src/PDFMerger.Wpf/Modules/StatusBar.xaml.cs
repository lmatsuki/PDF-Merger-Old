using System.Windows;
using System.Windows.Controls;

namespace PDFMerger.Wpf.Modules
{
    /// <summary>
    /// Interaction logic for StatusBar.xaml
    /// </summary>
    public partial class StatusBar : UserControl
    {
        public StatusBar()
        {
            InitializeComponent();
        }

        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            statusBar.Text = "Drop PDF-documents in the box above, or choose \"Add file...\" from the toolbar";
        }
    }
}

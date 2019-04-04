using System.Collections.ObjectModel;

namespace PDFMerger.Wpf.ViewModels
{
    public class MergeFilesViewModel
    {
        public ObservableCollection<string> MergeFiles { get; set; } = new ObservableCollection<string>();
    }
}

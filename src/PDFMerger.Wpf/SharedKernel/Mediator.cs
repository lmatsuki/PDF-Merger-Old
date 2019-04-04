using PDFMerger.Wpf.Modules;

namespace PDFMerger.Wpf.SharedKernel
{
    public class Mediator
    {
        private ToolBar toolBar;
        private ListBox listBox;
        public Mediator(ToolBar toolBar, ListBox listBox)
        {
            this.toolBar = toolBar;
            this.listBox = listBox;
        }

        public void Send(object message)
        {
            toolBar.Notify(message);
            listBox.Notify(message);
        }
    }
}

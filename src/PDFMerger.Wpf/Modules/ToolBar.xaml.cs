using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PDFMerger.Wpf.Modules
{
    /// <summary>
    /// Interaction logic for ToolBar.xaml
    /// </summary>
    public partial class ToolBar : UserControl
    {
        public ToolBar()
        {
            InitializeComponent();
        }

        #region AddFile Command

        private void AddFileCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AddFileCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF documents (*.pdf)|*.pdf*"
            };

            if (openFileDialog.ShowDialog().Value)
            {
                MessageBox.Show("Opened: " + openFileDialog.FileName);
            }
        }

        #endregion

        #region RemoveFile Command

        private void RemoveFileCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void RemoveFileCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Remove file!");
        }

        #endregion
    }

    #region Custom Commands

    public static class CustomCommands
    {
        public static readonly RoutedUICommand RemoveFile = new RoutedUICommand
        (
            "RemoveFile",
            "RemoveFile",
            typeof(CustomCommands)
        );

        public static readonly RoutedUICommand MoveUp = new RoutedUICommand
        (
            "MoveUp",
            "MoveUp",
            typeof(CustomCommands)
        );

        public static readonly RoutedUICommand MoveDown = new RoutedUICommand
        (
            "MoveDown",
            "MoveDown",
            typeof(CustomCommands)
        );

        public static readonly RoutedUICommand BindFile = new RoutedUICommand
        (
            "BindFile",
            "BindFile",
            typeof(CustomCommands)
        );
    }

    #endregion
}

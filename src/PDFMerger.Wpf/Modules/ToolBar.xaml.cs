using Microsoft.Win32;
using PDFMerger.Wpf.SharedKernel;
using PDFMerger.Wpf.ViewModels;
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

        public Mediator Mediator { get; set; }

        public void Notify(object message)
        {
            string student = message as string;

            if (student != null)
            {
                DataContext = student;
            }
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
                MergeFilesViewModel viewModel = DataContext as MergeFilesViewModel;

                if (viewModel != null)
                {
                    viewModel.MergeFiles.Add(openFileDialog.FileName);
                }
            }
        }

        #endregion

        #region RemoveFile Command

        private void RemoveFileCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            MergeFilesViewModel viewModel = DataContext as MergeFilesViewModel;

            if (viewModel != null)
            {
                var toolbarPanel = sender as FrameworkElement;
                var dockPanel = toolbarPanel.Parent as Panel;
                var gridPanel = dockPanel.Parent as Panel;
                var mainWindow = gridPanel.Parent as FrameworkElement;

                var child = mainWindow;

                var test = false;
                //viewModel.MergeFiles.Add(openFileDialog.FileName);
            }
            e.CanExecute = false;
        }

        private void RemoveFileCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Remove file!");
        }

        #endregion

        #region MoveUp Command

        private void MoveUpCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void MoveUpCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Move up file!");
        }

        #endregion

        #region MoveDown Command

        private void MoveDownCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void MoveDownCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Move down file!");
        }

        #endregion

        #region BindFile Command

        private void BindFileCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            MergeFilesViewModel viewModel = DataContext as MergeFilesViewModel;

            e.CanExecute = (viewModel != null && viewModel.MergeFiles.Count > 1);
        }

        private void BindFileCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF documents (*.pdf)|*.pdf*"
            };

            if (saveFileDialog.ShowDialog().Value)
            {
                // Bind and Save file!

            }
        }

        #endregion
    }

    #region Custom Commands

    public static class CustomCommands
    {
        public static readonly RoutedUICommand AddFile = new RoutedUICommand
        (
            "AddFile",
            "AddFile",
            typeof(CustomCommands)
        );

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

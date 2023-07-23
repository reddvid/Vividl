using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;
using AdonisUI.Controls;
using Vividl.ViewModels;

namespace Vividl.Views
{
    partial class PlaylistDataWindow : AdonisWindow
    {
        public PlaylistDataWindow(VideoViewModel video)
        {
            InitializeComponent();
            this.DataContext = video;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);
            e.Handled = true;
        }
    }
}

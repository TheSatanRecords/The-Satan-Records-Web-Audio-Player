using System.Windows;
using Microsoft.Web.WebView2.Wpf;

namespace The_Satan_Records_Web_Audio_Player
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gr.Children.Add(web);
            web.Source = new System.Uri("https://thesatanrecords.github.io/audio_player.html");
        }
        public WebView2 web = new WebView2();
    }
}

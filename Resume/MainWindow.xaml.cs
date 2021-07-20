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

namespace Resume
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            if ( tg_Btn.IsChecked == true )
            {
                tt_Home.Visibility = Visibility.Collapsed;
                tt_History.Visibility = Visibility.Collapsed;
                tt_Task.Visibility = Visibility.Collapsed;
                tt_Tool.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_Home.Visibility = Visibility.Visible;
                tt_History.Visibility = Visibility.Visible;
                tt_Task.Visibility = Visibility.Visible;
                tt_Tool.Visibility = Visibility.Visible;
            }
        }

        private void tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.4;
        }

        private void bg_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tg_Btn.IsChecked = false;
        }

        private void btn_AppOff_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ( e.ChangedButton == MouseButton.Left )
            {
                this.DragMove();
            }
        }
    }
}

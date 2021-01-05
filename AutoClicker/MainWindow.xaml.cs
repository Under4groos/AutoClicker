using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace AutoClicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<bool> ActivePanel = new List<bool>()
        {
            false, // Click
            false
        };
        public MainWindow()
        {
            InitializeComponent();
            ClickerPanel.KeyEventAdd(KeyEvent);
        }
        void KeyEvent(object o, KeyEventArgs e)
        {
            
            
            ClickerPanel.SetKey(e.Key);
        }
        /// <summary>
        /// Перемещение она.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
        /// <summary>
        /// Кнопка закрытия окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {         
            Process.GetCurrentProcess().Kill();
        }
        /// <summary>
        /// Сворачивание она.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Border_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            switch (this.WindowState)
            {
                case WindowState.Normal:
                    this.WindowState = WindowState.Maximized;
                    break;
                case WindowState.Minimized:
                    break;
                case WindowState.Maximized:
                    this.WindowState = WindowState.Normal;
                    break;
                default:
                    break;
            }
        }


        private void MouseClickClicker(object sender, MouseButtonEventArgs e)
        {
            ActivePanel[0] = !ActivePanel[0];
            ScriptPanel.Visibility = Visibility.Hidden;
            switch (ClickerPanel.Visibility)
            {
                case Visibility.Visible:
                    ClickerPanel.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    ClickerPanel.Visibility = Visibility.Visible;
                    break;
                case Visibility.Collapsed:
                    break;
                default:
                    break;
            }
        }

        private void Border_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            ClickerPanel.Visibility = Visibility.Hidden;
            switch (ScriptPanel.Visibility)
            {
                case Visibility.Visible:
                    ScriptPanel.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    ScriptPanel.Visibility = Visibility.Visible;
                    break;
                case Visibility.Collapsed:
                    break;
                default:
                    break;
            }
           
        }
    }
}

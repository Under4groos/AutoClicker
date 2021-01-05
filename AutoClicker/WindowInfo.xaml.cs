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
using System.Windows.Shapes;

namespace AutoClicker
{
    /// <summary>
    /// Логика взаимодействия для WindowInfo.xaml
    /// </summary>
    public partial class WindowInfo : Window
    {

        public WindowInfo()
        {
            InitializeComponent();
        }
        public void SetInfo(string Act, string key, string time)
        {
            Active.Content = $"Active: {Act}";
            Key.Content = $"Key: {key}"; 
            Time.Content = $"Time: {time}";
            this.Topmost = true;
        }
      
    }
}

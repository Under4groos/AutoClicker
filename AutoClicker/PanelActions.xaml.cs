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

namespace AutoClicker
{
    /// <summary>
    /// Логика взаимодействия для PanelActions.xaml
    /// </summary>
    public partial class PanelActions : UserControl
    {
        public PanelActions()
        {
            InitializeComponent();
            
        }
        public void SetName(string str )
        {
            NameActivonPanel.Content = str;
        }

        public string Namelabel
        {
            get; set;
        } = "";

        public bool[] MouseClick
        {
            get; set;
        } = { false, false, false };

        public Point MouseSetPos
        {
            get;set;
        }

        public int TimeSleep
        {
            get; set;
        } = 1;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SetName(Namelabel);
        }
    }
}

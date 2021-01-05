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
    /// Логика взаимодействия для ScriptPanel.xaml
    /// </summary>
    public partial class ScriptPanel : UserControl
    {
        int? Index = null;
        bool[] KeyStateMosue = {
            false,
            false,
            false
        };




        public ScriptPanel()
        {
            InitializeComponent();
        }
        public void AddNewPanel(string Name, int sleep, bool[] MouseCl , Point MousePos)
        {
            PanelActions B = new PanelActions()
            {
                Namelabel = Name,
                TimeSleep = sleep,
                MouseClick = MouseCl,
                MouseSetPos = MousePos,
                Height = 35,
                Background = Brushes.White,
                Margin = new Thickness(0,5,0,0),
                
            };
            B.MouseDown += B_MouseDown;
            StackPanel_ScrollViewer.Children.Add(B);
        }
        public void RemooveID(int id)
        {
            //if (StackPanel_ScrollViewer.Children.Count < 1)
            //    return;        
            try
            {
                StackPanel_ScrollViewer.Children.RemoveAt(id);
                ERROR.Visibility = Visibility.Hidden;
                
            }
            catch (Exception)
            {
                ERROR.Visibility = Visibility.Visible;
            }
            
        }

        private void B_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Index = StackPanel_ScrollViewer.Children.IndexOf(sender as UIElement);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //AddNewPanel();

            AddNewPanel(NameTextBox.Text, 1, new bool[] { true, true, true }, new Point());
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Index == null)
                return;
            RemooveID((int)Index);
        }


        private void CCBoxKeyMouse_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

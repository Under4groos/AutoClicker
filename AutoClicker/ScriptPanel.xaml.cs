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
            if (StackPanel_ScrollViewer.Children.Count < 1)
                return;        
            StackPanel_ScrollViewer.Children.RemoveAt(id);
        }



        public void SetBackgroundMouse()
        {
            Border[] Borders = { B1, B2, B3 };

            for (int i = 0; i < Borders.Length; i++)
            {
                if (KeyStateMosue[i])
                {
                    Borders[i].Background = Brushes.Green;
                }
                else
                {
                    Borders[i].Background = Brushes.Red;
                }
            }
        }

        private void B_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Index = StackPanel_ScrollViewer.Children.IndexOf(sender as UIElement);
            



        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //AddNewPanel();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Index == null)
                return;
            RemooveID((int)Index);
        }



        #region MouseDown_m123
        private void MouseDown_m1(object sender, MouseButtonEventArgs e)
        {
            KeyStateMosue[0] = !KeyStateMosue[0];
            SetBackgroundMouse();
        }

        private void MouseDown_m2(object sender, MouseButtonEventArgs e)
        {
            KeyStateMosue[1] = !KeyStateMosue[1];
            SetBackgroundMouse();
        }

        private void MouseDown_m3(object sender, MouseButtonEventArgs e)
        {

            KeyStateMosue[2] = !KeyStateMosue[2];
            SetBackgroundMouse();
        }
        #endregion
   


    }
}

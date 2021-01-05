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

namespace AutoClicker.Controls
{
    /// <summary>
    /// Логика взаимодействия для CCBoxKeyBind.xaml
    /// </summary>
    public partial class CCBoxKeyMouse : UserControl
    {
        public bool[] KeyStateMosue = {
            false,
            false,
            false
        };


        public CCBoxKeyMouse()
        {
            InitializeComponent();
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

    }
}

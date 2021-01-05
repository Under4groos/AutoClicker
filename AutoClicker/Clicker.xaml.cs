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
using KeyboardHook;
using MainWindow;

namespace AutoClicker
{



    /// <summary>
    /// Логика взаимодействия для Clicker.xaml
    /// </summary>
    public partial class Clicker : UserControl
    {
        KeyHook KeyH;
        WindowInfo WI = new WindowInfo();
        TimerTick timerTick = new TimerTick();
 

        bool[] KeyStateActive = {
            false,
            false
        };
        bool[] KeyStateMosue = {
            false,
            false,
            false            
        };

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

        public int KeyID
        {
            get; set;
        }
        int CountClick = 0;

        public string KeyName
        {
            get; set;
        }
        public bool ActiveKey
        {
            get;set;
        }
        public Clicker()
        {
            InitializeComponent();
            timerTick.Tick += TimerTick_Tick;
            SetBackgroundMouse();
            timerTick.Start();
            TimeBox.Text = timerTick.Time.ToString();
        }

        private void TimerTick_Tick(object sender, EventArgs e)
        {
            if (!ActiveKey)
                return;
            UpdateInfo();


            if (KeyStateMosue[0])
            {
                MouseDll.Mouse.LeftClick();
            }
            else if (KeyStateMosue[1])
            {
                MouseDll.Mouse.MiddleClick();
            }
            else if (KeyStateMosue[2])
            {
                MouseDll.Mouse.RightClick();
            }


        }

        public void KeyEventAdd(KeyEventHandler eventHandler)
        {
            TextBoxBindKey.KeyDown += eventHandler;
        }



        public void SetKey(Key key)
        {

            int kid = KeyInterop.VirtualKeyFromKey(key);
            //if (!char.IsLetter((char)kid))
            //    return;
            KeyID = kid;
            KeyName = key.ToString();

            TextBoxBindKey.Text = $"Key: {KeyName} ID: {KeyID}";

            if (KeyH != null)
                KeyH.Dispose();
            KeyH = new KeyHook(KeyID);
            KeyH.KeyPressed += (sender , e) => 
            {
                ActiveKey = !ActiveKey;
                UpdateInfo();
            };
            KeyH.SetHook();
            Focus.Focus();
            UpdateInfo();
        }
        public void UpdateInfo()
        {
            if (WI.IsVisible)
            {
                WI.SetInfo(ActiveKey.ToString(), TextBoxBindKey.Text, timerTick.Time.ToString());

            }
        }
        private void MouseClick_clearKey(object sender, MouseButtonEventArgs e)
        {
            if (KeyH != null)
                KeyH.Dispose();
            KeyID = 0;
            KeyName = "";
            ActiveKey = false;
            TextBoxBindKey.Text = "";
            Focus.Focus();
            UpdateInfo();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KeyStateActive[0] = !KeyStateActive[0];
            
            switch (KeyStateActive[0])
            {
                case true:
                    StatusInfoPanel.Background = Brushes.Green;

                    if (WI.IsVisible == false)
                    {
                        WI = new WindowInfo();
                        WI.Show();
                        UpdateInfo();

                    }

                   
                    break;
                case false:
                    StatusInfoPanel.Background = Brushes.Red;
                    if (WI == null)
                        return;
                    WI.Hide();
                    break;
                default:
                    break;
            }
            //
        }

        private void TimeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            

            int t = 1;
            if (int.TryParse(TimeBox.Text, out t))
            {
                timerTick.Time = t < 1 ? 1 : t;
                
                UpdateInfo();
                
            }
            else
            {
            
            }
            
        }

        private void TimeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Space)
                       
                Focus.Focus();
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            CCclick.Background = Brushes.Red;
            CountC.Content = CountClick++;
        }

        private void Border_MouseUp(object sender, MouseButtonEventArgs e)
        {
            CCclick.Background = Brushes.Green;
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

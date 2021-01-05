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
        public ScriptPanel()
        {
            InitializeComponent();
        }
        public void AddNewPanel()
        {
            Border B = new Border()
            {
                Height = new Random().Next(10, 125),
                Background = Brushes.Red,
                Margin = new Thickness(0,5,0,0),
                
            };
            B.MouseDown += B_MouseDown;
            StackPanel_ScrollViewer.Children.Add(B);
        }
        public void RemooveID(int id)
        {
            
            if (StackPanel_ScrollViewer.Children.Count >= 1)
                StackPanel_ScrollViewer.Children.RemoveAt(id);
        }
        
        
        

        private void B_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Index = StackPanel_ScrollViewer.Children.IndexOf(sender as UIElement);
            //MessageBox.Show($"{Index}");
        }

        
            

        

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddNewPanel();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Index == null)
                return;
            RemooveID((int)Index);
        }

        //MessageBox.Show("You've touched n°" + StackPanel_ScrollViewer.Children.IndexOf(sender as UIElement));



    }
}

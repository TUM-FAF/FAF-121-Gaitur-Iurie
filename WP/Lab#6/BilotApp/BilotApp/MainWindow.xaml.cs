using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace BilotApp
{
    
    public partial class MainWindow : Window
    {
        public StackPanel myContainer;

        private static MainWindow instance;

        private MainWindow()
        {
            InitializeComponent();
            this.myContainer = container;
            this.myContainer.Margin = new Thickness(7,0,0,0);
            this.myContainer.Children.Add(new MainControl());
        }

        public static MainWindow Instance
        {
            get 
            {
                if (instance == null)
                {
                instance = new MainWindow();
                }
                return instance;
            }
        }

        private void MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

    }
}

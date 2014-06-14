using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BilotApp
{
    /// <summary>
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        private GameType typeChoosen;

        public MainControl()
        {
            InitializeComponent();
        }

        private void MakeScore_Two_Click(object sender, RoutedEventArgs e)
        {
            GameChoosedSound(GameType.Two);
            PlayGame(GameType.Two);
        }

        private void MakeScore_Three_Click(object sender, RoutedEventArgs e)
        {
            GameChoosedSound(GameType.Three);
            PlayGame(GameType.Three);
        }

        private void MakeScore_Four_Click(object sender, RoutedEventArgs e)
        {
            GameChoosedSound(GameType.SimpleFour);
            PlayGame(GameType.SimpleFour);
        }

        private void MakeScore_Separate_Click(object sender, RoutedEventArgs e)
        {
            GameChoosedSound(GameType.CombinFour);
            PlayGame(GameType.CombinFour);
        }


        void PlayGame(GameType type)
        {
            BilotApp.MainWindow.Instance.myContainer.Children.Clear();
            BilotApp.MainWindow.Instance.myContainer.Children.Add(new GameControl(type));

        }

        void GameChoosedSound(GameType type)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = 1;     // -10...10

            if (type == GameType.Two)
            {
                synthesizer.Speak("Let the best player win!");
            }
            else if (type == GameType.Three)
            {
                synthesizer.Speak("Let the best player win!");
            }
            else if (type == GameType.SimpleFour)
            {
                synthesizer.Speak("It will be a long game!");
            }
            else if (type == GameType.CombinFour)
            {
                synthesizer.Speak("Let the best command win!");
            }
        }
    }
}

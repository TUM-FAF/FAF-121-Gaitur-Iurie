using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for GameControl.xaml
    /// </summary>
    public partial class GameControl : UserControl
    {
        private GameType game;
        private FlowDocument document;
        private Table myTable;
        private ItemGrid itemScore;
        private int top_margin_textbox = 0;
        private int nr_players;
        private bool pair = false;
        

        public GameControl(GameType game)
        {
            this.game = game;
            InitializeComponent();
            InitializeTable(game);

            
            
        }

        private void Btn_back_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.container.Children.Clear();
            MainWindow.Instance.container.Children.Add(new MainControl());
        }

        private void Btn_exit_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.Close();
        }

        private void Btn_new_game_OnClick(object sender, RoutedEventArgs e)
        {
            ResetGame();
        }

        void InitializeTable(GameType game)
        {
            int nr_players = 2;
            
            
            document = new FlowDocument();
            myTable = new Table();
            document.Blocks.Add(myTable);


            switch (game)
            {
                    case GameType.Two:
                    nr_players = 2;
                    

                    CreateTable(nr_players);
                    break;
                    case GameType.Three:
                    nr_players = 3;

                    CreateTable(nr_players);
                    break;
                    case GameType.SimpleFour:
                    nr_players = 4;

                    CreateTable(nr_players);
                    break;
                    case GameType.CombinFour:
                    pair = true;
                    nr_players = 4;

                    CreateTable(nr_players);
                    break;

                    default:
                    break;
            }
        }


        void CreateTable(int nr_players)
        {
            this.nr_players = nr_players;
            AddNames(nr_players);
            //CreateColumns(nr_players);
            itemScore = new ItemGrid(nr_players);
            AddGridText(nr_players);
        }



      /*  void CreateTable(int nr_players)
        {
            int width_colon = (int)(350 - 15) / nr_players;

            for (int x = 0; x < nr_players; x++)
            {

                myTable.Columns.Add(new TableColumn());

                myTable.Columns[x].Width = new GridLength(width_colon);

            }
            // Create and add an empty TableRowGroup Rows.

            myTable.RowGroups.Add(new TableRowGroup());

            // Add the table head row.

            myTable.RowGroups[0].Rows.Add(new TableRow());

            //Configure the table head row

            TableRow currentRow = myTable.RowGroups[0].Rows[0];

            currentRow.Background = Brushes.Navy;

            currentRow.Foreground = Brushes.White;



            // Add the header row with content,

            for (int x = 0; x < nr_players; x++)
            {

                currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Player "+ x+1))));

            }

        }*/

        void AddNames(int nr_players)
        {
            Label[] labels = new Label[nr_players];

            if (nr_players == 4 && pair)
            {
                for (int i = 0; i < 2; i++)
                {
                    Label label = new Label();
                    label.Width = Names.Width / 2;
                    Names.Children.Add(label);
                }
                labels[0].Content = "We";
                labels[0].Content = "You";
            }
            else
            {
                for (int i = 0; i < nr_players; i++)
                {
                    Label label = new Label();
                    label.Width = Names.Width / nr_players;
                    label.Content = "Player " + (i+1);
                    Names.Children.Add(label);
                }
            }
        }
       

       
        void AddGridText(int nr_player)
        {
            TextBox[] texts = new TextBox[nr_player];
            
            for (int i = 0; i < nr_player; i++)
            {   texts[i] = new TextBox();
                texts[i].Width = TextBoxes.Width/nr_player - 10;
                texts[i].Height = 20;
                texts[i].HorizontalAlignment = HorizontalAlignment.Left;
                texts[i].VerticalAlignment = VerticalAlignment.Top;
                texts[i].Margin = new Thickness(i*texts[i].Width+5, top_margin_textbox, 0, 0);
                
                this.TextBoxes.Children.Add(texts[i]); 
            }

            top_margin_textbox += (int)texts[0].Height+3;

        }


        void ResetGame()
        {
            pair = false;
            this.TextBoxes.Children.Clear();
            AddGridText(nr_players);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AddGridText(nr_players);
        }
        
    }
}

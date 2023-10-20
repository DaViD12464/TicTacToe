﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace TicTacToe
{
    
    public partial class MainWindow : Window
    {
        public bool isplayer1turn { get; set; }
        public bool isplayer2turn { get; set; }
        public int counter {  get; set; }
        public MainWindow()
        {   
            InitializeComponent();
            StartGame();
            ButtonReset();
        }

        private void StartGame()
        {
            counter = 0;
            RandomPlayer();
        }

       private void RandomPlayer()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 3);
            if (randomNumber == 1)
            {
                ResultTextBox.Text = "Player 1 Turn!";
                ResultTextBox.Background = new SolidColorBrush(Colors.Cyan);
                isplayer2turn = false;
                isplayer1turn = true;
            }
            else if (randomNumber == 2)
            {
                ResultTextBox.Text = "Player 2 Turn!";
                ResultTextBox.Background = new SolidColorBrush(Colors.LightCoral);
                isplayer2turn = true;
                isplayer1turn = false;
            }
        }

        private void GameEnd(object sender, RoutedEventArgs e )
        {
           string winner = ResultTextBox.Text;
            if (winner == "Player 1 Won!!!")
            {
                ResultTextBox.Text = "Player 2 Turn!";
                ResultTextBox.Background = new SolidColorBrush(Colors.LightCoral);
                isplayer2turn = true;
                isplayer1turn = false;
            }
            else
                if (winner == "Player 2 Won!!!")
            {
                ResultTextBox.Text = "Player 1 Turn!";
                ResultTextBox.Background = new SolidColorBrush(Colors.Cyan);
                isplayer2turn = false;
                isplayer1turn = true;
            }
            else if (winner == "DRAW")
            {
                RandomPlayer();
            }
            counter = 0;
            ButtonReset();
            NewGame.Visibility = Visibility.Hidden;

        }

        private void ButtonReset()
        {
            Button11.Content = string.Empty;
            Button12.Content = string.Empty;
            Button13.Content = string.Empty;
                               
            Button21.Content = string.Empty;
            Button22.Content = string.Empty;
            Button23.Content = string.Empty;
                               
            Button31.Content = string.Empty;
            Button32.Content = string.Empty;
            Button33.Content = string.Empty;

            Button11.Background = Brushes.WhiteSmoke;
            Button12.Background = Brushes.WhiteSmoke;
            Button13.Background = Brushes.WhiteSmoke;

            Button21.Background = Brushes.WhiteSmoke;
            Button22.Background = Brushes.WhiteSmoke;
            Button23.Background = Brushes.WhiteSmoke;

            Button31.Background = Brushes.WhiteSmoke;
            Button32.Background = Brushes.WhiteSmoke;
            Button33.Background = Brushes.WhiteSmoke;

            Button11.IsEnabled = true;
            Button12.IsEnabled = true;
            Button13.IsEnabled = true;
                                 
            Button21.IsEnabled = true;
            Button22.IsEnabled = true;
            Button23.IsEnabled = true;
                                 
            Button31.IsEnabled = true;
            Button32.IsEnabled = true;
            Button33.IsEnabled = true;

        }
        

        private bool CheckIfPLayerWon()
        {
            //rzedy
            if (Button11.Content.ToString() != string.Empty && Button11.Content == Button12.Content && Button12.Content == Button13.Content) 
            {
                Button11.Background = Brushes.LightGreen; 
                Button12.Background = Brushes.LightGreen;
                Button13.Background = Brushes.LightGreen;
                if (Button11.Content.ToString() == "X")
                {
                    ResultTextBox.Text = "Player 1 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.DodgerBlue);
                }
                else
                if (Button11.Content.ToString() == "O")
                {
                    ResultTextBox.Text = "Player 2 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.OrangeRed);
                }
                return true;
            }
            if (Button21.Content.ToString() != string.Empty && Button21.Content == Button22.Content && Button22.Content == Button23.Content) 
            {
                Button21.Background = Brushes.LightGreen;
                Button22.Background = Brushes.LightGreen;
                Button23.Background = Brushes.LightGreen;
                if (Button21.Content.ToString() == "X")
                {
                    ResultTextBox.Text = "Player 1 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.DodgerBlue);
                }
                else
                if (Button21.Content.ToString() == "O")
                {
                    ResultTextBox.Text = "Player 2 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.OrangeRed);
                }
                return true;
            }

            if (Button31.Content.ToString() != string.Empty && Button31.Content == Button32.Content && Button32.Content == Button33.Content) 
            {
                Button31.Background = Brushes.LightGreen;
                Button32.Background = Brushes.LightGreen;
                Button33.Background = Brushes.LightGreen;
                if (Button31.Content.ToString() == "X")
                {
                    ResultTextBox.Text = "Player 1 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.DodgerBlue);
                }
                else
                if (Button31.Content.ToString() == "O")
                {
                    ResultTextBox.Text = "Player 2 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.OrangeRed);
                }
                return true;
            }
            //kolumny
            if ((string)Button11.Content != string.Empty && Button11.Content == Button21.Content && Button21.Content == Button31.Content) 
            {
                Button11.Background = Brushes.LightGreen;
                Button21.Background = Brushes.LightGreen;
                Button31.Background = Brushes.LightGreen;
                if (Button11.Content.ToString() == "X")
                {
                    ResultTextBox.Text = "Player 1 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.DodgerBlue);
                }
                else
                if (Button11.Content.ToString() == "O")
                {
                    ResultTextBox.Text = "Player 2 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.OrangeRed);
                }
                return true;
            }
            if ((string)Button12.Content != string.Empty && Button12.Content == Button22.Content && Button22.Content == Button32.Content) 
            {
                Button12.Background = Brushes.LightGreen;
                Button22.Background = Brushes.LightGreen;
                Button32.Background = Brushes.LightGreen;
                if(Button12.Content.ToString() == "X")
                {
                    ResultTextBox.Text = "Player 1 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.DodgerBlue);
                }
                else
                if (Button12.Content.ToString() == "O")
                {
                    ResultTextBox.Text = "Player 2 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.OrangeRed);
                }
                return true;
            }
            if ((string)Button13.Content != string.Empty && Button13.Content == Button23.Content && Button23.Content == Button33.Content) 
            {
                Button13.Background = Brushes.LightGreen;
                Button23.Background = Brushes.LightGreen;
                Button33.Background = Brushes.LightGreen;
                if (Button13.Content.ToString() == "X")
                {
                    ResultTextBox.Text = "Player 1 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.DodgerBlue);
                }
                else
                if (Button13.Content.ToString() == "O")
                {
                    ResultTextBox.Text = "Player 2 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.OrangeRed);
                }
                return true;
            }
            //przekątne
            if ((string)Button11.Content != string.Empty && Button11.Content == Button22.Content && Button22.Content == Button33.Content)
            {
                Button11.Background = Brushes.LightGreen;
                Button22.Background = Brushes.LightGreen;
                Button33.Background = Brushes.LightGreen;
                if (Button11.Content.ToString() == "X")
                {
                    ResultTextBox.Text = "Player 1 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.DodgerBlue);
                }
                else
                if (Button11.Content.ToString() == "O")
                {
                    ResultTextBox.Text = "Player 2 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.OrangeRed);
                }
                return true;
            }
            if ((string)Button13.Content != string.Empty && Button13.Content == Button22.Content && Button22.Content == Button31.Content)
            {
                Button13.Background = Brushes.LightGreen;
                Button22.Background = Brushes.LightGreen;
                Button31.Background = Brushes.LightGreen;
                if (Button13.Content.ToString() == "X")
                {
                    ResultTextBox.Text = "Player 1 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.DodgerBlue);
                }
                else
                if (Button13.Content.ToString() == "O")
                {
                    ResultTextBox.Text = "Player 2 Won!!!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.OrangeRed);
                }
                return true;
            }
            else return false;
        }

        private bool ButtonWithoutContent(string button)
        {
            if (button == Button11.Name && Button11.Content.ToString() != String.Empty)
            {
                return false;
            }
            if (button == Button12.Name && Button12.Content.ToString() != String.Empty)
            {
                return false;
            }
            if (button == Button13.Name && Button13.Content.ToString() != String.Empty)
            {
                return false;
            }
            if (button == Button21.Name && Button21.Content.ToString() != String.Empty)
            {
                return false;
            }
            if (button == Button22.Name && Button22.Content.ToString() != String.Empty)
            {
                return false;
            }
            if (button == Button23.Name && Button23.Content.ToString() != String.Empty)
            {
                return false;
            }
            if (button == Button31.Name && Button31.Content.ToString() != String.Empty)
            {
                return false;
            }
            if (button == Button32.Name && Button32.Content.ToString() != String.Empty)
            {
                return false;
            }
            if (button == Button33.Name && Button33.Content.ToString() != String.Empty)
            {
                return false;
            }        
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (isplayer1turn == true)
            {
                if(ButtonWithoutContent(button!.Name)== true)
                {
                    button!.Content = "X";
                    isplayer1turn = false;
                    isplayer2turn = true;
                    ResultTextBox.Text = "Player 2 Turn!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.LightCoral);
                    counter++;
                }
            }
            else
            if (isplayer2turn == true)
            {
                if (ButtonWithoutContent(button!.Name) == true)
                {
                    button!.Content = "O";
                    isplayer1turn = true;
                    isplayer2turn = false;

                    ResultTextBox.Text = "Player 1 Turn!";
                    ResultTextBox.Background = new SolidColorBrush(Colors.Cyan);
                    counter++;
                }
            }
            
            if (counter >=5)
            {
                if (CheckIfPLayerWon() == true)
                { NewGame.Visibility = Visibility.Visible;
                    
                    if (ButtonWithoutContent("Button11") == true)
                    {
                        Button11.IsEnabled = false;
                    }
                    if (ButtonWithoutContent("Button12") == true)
                    {
                        Button12.IsEnabled = false;
                    }
                    if (ButtonWithoutContent("Button13") == true)
                    {
                        Button13.IsEnabled = false;
                    }

                    if (ButtonWithoutContent("Button21") == true)
                    {
                        Button21.IsEnabled = false;
                    }
                    if (ButtonWithoutContent("Button22") == true)
                    {
                        Button22.IsEnabled = false;
                    }
                    if (ButtonWithoutContent("Button23") == true)
                    {
                        Button23.IsEnabled = false;
                    }

                    if (ButtonWithoutContent("Button31") == true)
                    {
                        Button31.IsEnabled = false;
                    }
                    if (ButtonWithoutContent("Button32") == true)
                    {
                        Button32.IsEnabled = false;
                    }
                    if (ButtonWithoutContent("Button33") == true)
                    {
                        Button33.IsEnabled = false;
                    }
                    

                }
            }
            if (counter == 9) 
            {
                if (CheckIfPLayerWon() == true)
                { NewGame.Visibility = Visibility.Visible; }
                else
                {
                    ResultTextBox.Text = "DRAW";
                    ResultTextBox.Background = new SolidColorBrush(Colors.LightGray);
                    NewGame.Visibility = Visibility.Visible;
                }
                
            }

        }
    }
}

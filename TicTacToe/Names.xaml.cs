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
using System.Windows.Shapes;

namespace TicTacToe
{
    public partial class Names : Window
    {
        public NameTransfer NamesToTransfer { get; set; } = new NameTransfer();
       
        public Names()
        {
            InitializeComponent();
        }

        public void SendData()
        {
            NamesToTransfer.player1 = Player1Name.Text;
            NamesToTransfer.player2 = Player2Name.Text;
        }
        private void DataInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && Player1Name.Text != string.Empty && Player2Name.Text != string.Empty)
            {
                SendData();
                Close();
            }
        }



    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Games.BattleShip;

namespace Games
{
    public partial class Form1 : Form
    {
        Form form = null;
        Game game = null;
        BattleShipGame battleship = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MyEventHandler(object sender, EventArgs e)
        {

            if (sender == bt1)
            {
                game = BattleShipGame.getInstance();
                if (game != battleship)
                {
                    battleship = (BattleShipGame)game;
                    form = new Form_Battleship();
                }
            }
            
            //
            if (!form.IsDisposed && form != null)
            {
                form.Show();
            }
            else
            {
                battleship.setToNull();
            }
        }
    }
}

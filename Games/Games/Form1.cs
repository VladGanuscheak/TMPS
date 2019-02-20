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
using Games.Kangaroo;
using Games.Matches;

namespace Games
{
    public partial class Form1 : Form
    {
        Form form = null;
        Game game = null;
        BattleShipGame battleship = null;
        KangarooGame kangaroo = null;
        MatchesGame matches = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void ShowForm(ref Form form, Game game)
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
            else if (sender == bt2)
            {
                game = KangarooGame.getInstance();
                if (game != kangaroo)
                {
                    kangaroo = (KangarooGame)game;
                    form = new Form_Kangaroo();
                }
            }
            else if (sender == bt3)
            {
                game = MatchesGame.getInstance();
                if (game != matches)
                {
                    matches = (MatchesGame)game;
                    form = new Form_Matches();
                }
            }

            //
            if (!form.IsDisposed && form != null)
            {
                form.Show();
            }
            else
            {
                if (battleship != null) battleship.setToNull();
                if (kangaroo != null) kangaroo.setToNull();
                if (matches != null) matches.setToNull();
            }

        }
    }
}

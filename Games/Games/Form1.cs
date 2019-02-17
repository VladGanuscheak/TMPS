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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MyEventHandler(object sender, EventArgs e)
        {
            Form form = null;
            Game game = null;

            if (sender == bt1)
            {
                form = new Form_Battleship();
            }
            
            //
            if (form != null)
            {
                form.Show();
            }
        }
    }
}

using System;
using System.Windows.Forms;
//

//using WMPLib;
using System.Media;
using System.IO;
using System.Drawing;

namespace Games
{
    public partial class Form_Battleship : Form
    {
        //private Size oldSize;
        SoundPlayer player;
        public Form_Battleship()
        {
            InitializeComponent();



            lb1.Visible = false;
            lb2.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            
            Stream str = Properties.Resources.oceanwave;
            player = new SoundPlayer(str);
        }

        private void Form_Battleship_Load(object sender, EventArgs e)
        {
            //oldSize = base.Size;
            player.PlayLooping();
        }
        
        
        /*protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            foreach (Control cnt in this.Controls)
            {
                ResizeAll(cnt, base.Size);
            }
            oldSize = base.Size;
        }
        private void ResizeAll(Control cnt, Size newSize)
        {
            int iWidth = newSize.Width - oldSize.Width;
            cnt.Left += (cnt.Left * iWidth) / oldSize.Width;
            cnt.Width += (cnt.Width * iWidth) / oldSize.Width;

            int iHeight = newSize.Height - oldSize.Height;
            cnt.Top += (cnt.Top * iHeight) / oldSize.Height;
            cnt.Height += (cnt.Height * iHeight) / oldSize.Height;
        }*/

        private void OnClickHandler(object sender, EventArgs e)
        {
            Button[] bt = { bt1, bt2, bt3 };
            Label[] lbl = { lbl1, lbl2, lbl3, lbl4 };
            ListBox[] lb = { lb1, lb2 };
            if (sender == bt1)
            {
                foreach(var item in bt)
                {
                    item.Visible = false;
                }
                foreach(var item in lbl)
                {
                    item.Visible = false;
                }
                foreach(var item in lb)
                {
                    item.Visible = false;
                }
            }
            else if (sender == bt2)
            {
                lbl2.Visible = true;
                lbl3.Visible = true;
                lb1.Visible = true;
            }
            else if (sender == bt3)
            {
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lb1.Visible = true;
                lb2.Visible = true;
            }
            else if (sender == lb1)
            {

            }
            else if (sender == lb2)
            {

            }
        }

        private void Form_Battleship_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();
            player.Dispose();
        }
        
    }
}

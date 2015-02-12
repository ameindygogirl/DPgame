using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPgame
{
    public partial class PickHeros : Form
    {
        public int[] heros = new int[3];
        //public int[] Heros { return heros; heros = value; }
        public PickHeros()
        {
            InitializeComponent();
        }

        private void pbChip_Click(object sender, EventArgs e)
        {
            if(pbFirst.Image == null)
            {
                pbFirst.Image = DPgame.Properties.Resources.chipmunk;
                heros[0] = 1;
            }
            else if(pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.chipmunk;
                heros[1] = 1;
            }
            else if(pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.chipmunk;
                heros[2] = 1;
            }
            else
            {
                //Nothing occurs, all spots filled
            }
        }

        private void pbKitten_Click(object sender, EventArgs e)
        {
            if (pbFirst.Image == null)
            {
                pbFirst.Image = DPgame.Properties.Resources.kitten;
                heros[0] = 2;
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.kitten;
                heros[1] = 2;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.kitten;
                heros[2] = 2;
            }
            else
            {
                //Nothing occurs, all spots filled
            }
        }

        private void pbDuck_Click(object sender, EventArgs e)
        {
            if (pbFirst.Image == null)
            {
                pbFirst.Image = DPgame.Properties.Resources.duck;
                heros[0] = 3;
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.duck;
                heros[1] = 3;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.duck;
                heros[2] = 3;
            }
            else
            {
                //Nothing occurs, all spots filled
            }
        }

        private void pbPuppy_Click(object sender, EventArgs e)
        {
            if (pbFirst.Image == null)
            {
                pbFirst.Image = DPgame.Properties.Resources.puppy;
                heros[0] = 4;
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.puppy;
                heros[1] = 4;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.puppy;
                heros[2] = 4;
            }
            else
            {
                //Nothing occurs, all spots filled
            }
        }

        private void pbTurtle_Click(object sender, EventArgs e)
        {
            if (pbFirst.Image == null)
            {
                pbFirst.Image = DPgame.Properties.Resources.tinyTurtle;
                heros[0] = 5;
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.tinyTurtle;
                heros[1] = 5;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.tinyTurtle;
                heros[2] = 5;
            }
            else
            {
                //Nothing occurs, all spots filled
            }
        }

        private void pbOwl_Click(object sender, EventArgs e)
        {
            if (pbFirst.Image == null)
            {
                pbFirst.Image = DPgame.Properties.Resources.owl;
                heros[0] = 6;
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.owl;
                heros[1] = 6;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.owl;
                heros[2] = 6;
            }
            else
            {
                //Nothing occurs, all spots filled
            }
        }
    }
}

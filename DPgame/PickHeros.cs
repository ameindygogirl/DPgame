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
       
        private void btnDone_Click(object sender, EventArgs e)
        {
            heros[0] = 0;
            heros[1] = 1;
            heros[2] = 2;
        }

        private void pbChip_Click(object sender, EventArgs e)
        {
            if(pbFirst.Image == null)
            {
                pbFirst.Image = DPgame.Properties.Resources.chipmunk;
            }
            else if(pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.chipmunk;
            }
            else if(pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.chipmunk;
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
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.kitten;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.kitten;
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
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.duck;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.duck;
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
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.puppy;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.puppy;
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
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.tinyTurtle;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.tinyTurtle;
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
            }
            else if (pbSecond.Image == null)
            {
                pbSecond.Image = DPgame.Properties.Resources.owl;
            }
            else if (pbThird.Image == null)
            {
                pbThird.Image = DPgame.Properties.Resources.owl;
            }
            else
            {
                //Nothing occurs, all spots filled
            }
        }
    }
}

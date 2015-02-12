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
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
            GameCharacterFactory hf = new HeroFactory();
            //GameCharacter hero = hf.createCharacter();
            ////label1.Text = hero.Name;

            GameCharacterFactory mf = new MonsterFactory();
            //GameCharacter monster = mf.createCharacter();
            //Action attack = new AttackAction();
            //attack.Primary = hero;
            //attack.Target = monster;
            //label1.Text = attack.ToString();
        }

        private void btnHeros_Click(object sender, EventArgs e)
        {
            PickHeros heroPicker = new PickHeros();
            heroPicker.ShowDialog();
            int first = heroPicker.heros[0];
            //int[] heroAra = heroPicker.Heros;
        }
    }
}

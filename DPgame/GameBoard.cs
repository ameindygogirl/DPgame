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
        GameCharacterFactory hf;
        GameCharacter hero;
        GameCharacterFactory mf;
        GameCharacter monster;
        public GameBoard()
        {
            InitializeComponent();
            hf = new HeroFactory();

            mf = new MonsterFactory();

            monster = mf.createCharacter(new Random().Next(6) + 1);         
        }

        private void btnHeros_Click(object sender, EventArgs e)
        {
            PickHeros heroPicker = new PickHeros();
            heroPicker.ShowDialog();

            hero = hf.createCharacter(heroPicker.heros[0]);
            battle();
        }

        private void battle()
        {
            Action attack = new AttackAction();
            attack.Primary = hero;
            attack.Target = monster;
            label1.Text = attack.ToString();
        }
    }
}

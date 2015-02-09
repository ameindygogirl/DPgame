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
            GameCharacterFactory hf = new Hero();
            GameCharacter hero = hf.chooseCharacter("Fuzzy Puppy");
            //label1.Text = hero.Name;

            GameCharacterFactory mf = new Monster();
            GameCharacter monster = mf.chooseCharacter("Crooked Vulture");
            label1.Text = monster.attack(hero).ToString();
        }

        private void btnHeros_Click(object sender, EventArgs e)
        {
            PickHeros heroPicker = new PickHeros();
            heroPicker.Show();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameCharacterFactory hf = new Hero();
            GameCharacter hero = hf.chooseCharacter("Fuzzy Puppy");
            //label1.Text = hero.Name;

            GameCharacterFactory mf = new Monster();
            GameCharacter monster = mf.chooseCharacter("Crooked Vulture");
            label1.Text = monster.attack(hero).ToString();
        }
    }
}

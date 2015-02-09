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
        public PickHeros()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

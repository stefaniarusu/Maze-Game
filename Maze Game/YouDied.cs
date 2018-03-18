using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class YouDied : Form
    {
        public YouDied()
        {
            InitializeComponent();
        }

        private void again_Click(object sender, EventArgs e)
        {
            Level1 open_form = new Level1();
            open_form.Visible = true;
            this.Hide();
        }
    }
}

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
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void play_Click(object sender, EventArgs e)
        {
            Level1 open_form = new Level1();
            open_form.Visible = true;
            this.Hide();
        }
    }
}

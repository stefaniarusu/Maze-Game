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
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void again_Click(object sender, EventArgs e)
        {
            Interface open_form = new Interface();
            open_form.Visible = true;
            this.Hide();
        }
    }
}

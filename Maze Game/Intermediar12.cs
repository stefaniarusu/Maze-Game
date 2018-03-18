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
    public partial class Intermediar12 : Form
    {
        public Intermediar12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level2 open_form = new Level2();
            open_form.Visible = true;
            this.Close();
        }

    }
}

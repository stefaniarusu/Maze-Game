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
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();
        }

        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                player.Top -= 5;
            }
            if (e.KeyCode == Keys.S)
            {
                player.Top += 5;
            }
            if (e.KeyCode == Keys.A)
            {
                player.Left -= 5;
            }
            if (e.KeyCode == Keys.D)
            {
                player.Left += 5;
            }

            Next();

            Collision();

        }

        public void Next()
        {
            if (player.Bounds.IntersectsWith(finish_01.Bounds))
            {
                Intermediar12 open_form = new Intermediar12();
                open_form.Visible = true;
                this.Hide();
            }
        }

        public void Collision()
        {
            if ((player.Bounds.IntersectsWith(wall_01.Bounds)) || (player.Bounds.IntersectsWith(wall_02.Bounds)) || (player.Bounds.IntersectsWith(wall_03.Bounds)) || (player.Bounds.IntersectsWith(wall_04.Bounds)) || (player.Bounds.IntersectsWith(wall_05.Bounds)) || (player.Bounds.IntersectsWith(wall_06.Bounds)) || (player.Bounds.IntersectsWith(wall_07.Bounds)) || (player.Bounds.IntersectsWith(wall_08.Bounds)) || (player.Bounds.IntersectsWith(wall_09.Bounds)) || (player.Bounds.IntersectsWith(wall_10.Bounds)) || (player.Bounds.IntersectsWith(wall_11.Bounds)) || (player.Bounds.IntersectsWith(wall_12.Bounds)) || (player.Bounds.IntersectsWith(wall_13.Bounds)) || (player.Bounds.IntersectsWith(wall_14.Bounds)) || (player.Bounds.IntersectsWith(wall_15.Bounds)) || (player.Bounds.IntersectsWith(wall_16.Bounds)) || (player.Bounds.IntersectsWith(wall_17.Bounds)) || (player.Bounds.IntersectsWith(wall_18.Bounds)) || (player.Bounds.IntersectsWith(wall_19.Bounds)) || (player.Bounds.IntersectsWith(wall_20.Bounds)) || (player.Bounds.IntersectsWith(wall_21.Bounds)) || (player.Bounds.IntersectsWith(wall_22.Bounds)) || (player.Bounds.IntersectsWith(wall_23.Bounds)) || (player.Bounds.IntersectsWith(wall_24.Bounds)) || (player.Bounds.IntersectsWith(wall_25.Bounds)) || (player.Bounds.IntersectsWith(wall_26.Bounds)) || (player.Bounds.IntersectsWith(wall_27.Bounds)) || (player.Bounds.IntersectsWith(wall_28.Bounds)) || (player.Bounds.IntersectsWith(wall_29.Bounds)) || (player.Bounds.IntersectsWith(wall_30.Bounds)) || (player.Bounds.IntersectsWith(wall_31.Bounds)) || (player.Bounds.IntersectsWith(wall_32.Bounds)) || (player.Bounds.IntersectsWith(wall_33.Bounds)) || (player.Bounds.IntersectsWith(wall_34.Bounds)) || (player.Bounds.IntersectsWith(wall_35.Bounds)) || (player.Bounds.IntersectsWith(wall_36.Bounds)) || (player.Bounds.IntersectsWith(wall_37.Bounds)) || (player.Bounds.IntersectsWith(wall_38.Bounds)) || (player.Bounds.IntersectsWith(wall_39.Bounds)) || (player.Bounds.IntersectsWith(wall_40.Bounds)) || (player.Bounds.IntersectsWith(wall_41.Bounds)) || (player.Bounds.IntersectsWith(wall_42.Bounds)) || (player.Bounds.IntersectsWith(wall_43.Bounds)) || (player.Bounds.IntersectsWith(wall_44.Bounds)) || (player.Bounds.IntersectsWith(wall_45.Bounds)) || (player.Bounds.IntersectsWith(wall_46.Bounds)) || (player.Bounds.IntersectsWith(wall_47.Bounds)) || (player.Bounds.IntersectsWith(wall_48.Bounds)) || (player.Bounds.IntersectsWith(wall_49.Bounds)) || (player.Bounds.IntersectsWith(wall_50.Bounds)) || (player.Bounds.IntersectsWith(wall_51.Bounds)) || (player.Bounds.IntersectsWith(wall_52.Bounds)) || (player.Bounds.IntersectsWith(wall_53.Bounds)) || (player.Bounds.IntersectsWith(wall_54.Bounds)) || (player.Bounds.IntersectsWith(wall_55.Bounds)) || (player.Bounds.IntersectsWith(wall_56.Bounds)) || (player.Bounds.IntersectsWith(wall_57.Bounds)) || (player.Bounds.IntersectsWith(wall_58.Bounds)) || (player.Bounds.IntersectsWith(wall_59.Bounds)) || (player.Bounds.IntersectsWith(wall_60.Bounds)) || (player.Bounds.IntersectsWith(wall_61.Bounds)) || (player.Bounds.IntersectsWith(wall_62.Bounds)) || (player.Bounds.IntersectsWith(wall_63.Bounds)) || (player.Bounds.IntersectsWith(wall_64.Bounds)) || (player.Bounds.IntersectsWith(wall_65.Bounds)) || (player.Bounds.IntersectsWith(wall_66.Bounds)) || (player.Bounds.IntersectsWith(wall_67.Bounds)) || (player.Bounds.IntersectsWith(wall_68.Bounds)) || (player.Bounds.IntersectsWith(wall_69.Bounds)) || (player.Bounds.IntersectsWith(wall_70.Bounds)) || (player.Bounds.IntersectsWith(wall_71.Bounds)) || (player.Bounds.IntersectsWith(wall_72.Bounds)) || (player.Bounds.IntersectsWith(wall_73.Bounds)) || (player.Bounds.IntersectsWith(wall_74.Bounds)) || (player.Bounds.IntersectsWith(wall_75.Bounds)) || (player.Bounds.IntersectsWith(wall_76.Bounds)) || (player.Bounds.IntersectsWith(wall_77.Bounds)) || (player.Bounds.IntersectsWith(wall_78.Bounds)) || (player.Bounds.IntersectsWith(wall_79.Bounds)) || (player.Bounds.IntersectsWith(wall_80.Bounds)) || (player.Bounds.IntersectsWith(wall_81.Bounds)) || (player.Bounds.IntersectsWith(wall_82.Bounds)) || (player.Bounds.IntersectsWith(wall_83.Bounds)) || (player.Bounds.IntersectsWith(wall_84.Bounds)) || (player.Bounds.IntersectsWith(wall_85.Bounds)) || (player.Bounds.IntersectsWith(wall_86.Bounds)) || (player.Bounds.IntersectsWith(wall_87.Bounds)) || (player.Bounds.IntersectsWith(wall_88.Bounds)) || (player.Bounds.IntersectsWith(wall_89.Bounds)) || (player.Bounds.IntersectsWith(wall_90.Bounds)) || (player.Bounds.IntersectsWith(wall_91.Bounds)) || (player.Bounds.IntersectsWith(wall_92.Bounds)) || (player.Bounds.IntersectsWith(wall_93.Bounds)) || (player.Bounds.IntersectsWith(wall_94.Bounds)) || (player.Bounds.IntersectsWith(wall_96.Bounds)) || (player.Bounds.IntersectsWith(wall_97.Bounds)) || (player.Bounds.IntersectsWith(wall_98.Bounds)) || (player.Bounds.IntersectsWith(wall_99.Bounds)) || (player.Bounds.IntersectsWith(wall_100.Bounds)) || (player.Bounds.IntersectsWith(wall_101.Bounds)) || (player.Bounds.IntersectsWith(wall_102.Bounds)) || (player.Bounds.IntersectsWith(wall_103.Bounds)))
            {
                if (life.Value <= 100)
                {
                    if (life.Value >= 20)
                    {
                        MessageBox.Show("You hit a wall!");
                        player.Location = new Point(7, 7);
                        life.Value -= 10;
                    }
                    else
                    {
                        if (life.Value == 10)
                        {
                            YouDied open_form = new YouDied();
                            open_form.Visible = true;
                            this.Hide();
                        }
                    }
                }
            }
            if (life.Value == 10)
            {
                YouDied open_form = new YouDied();
                open_form.Visible = true;
                this.Hide();
            }
        }

        private void goback1_Click(object sender, EventArgs e)
        {
            Interface open_form = new Interface();
            open_form.Visible = true;
            this.Hide();
        }
    }
}

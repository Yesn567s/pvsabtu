using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int game_speed = 1;

        List<int> map = new List<int>();
        bool desa = false;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            while (map.Count < 100)
            {
                int a = r.Next(0, 5);
                if (a == 0)
                {
                    if (!desa)
                    {
                        desa = true;
                        map.Add(a);
                    }
                }
                else
                {
                    map.Add(a);
                }
            }

            timerGameUpdate.Start();
            timerProduction.Start();
        }

        private void huntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(map);
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpgrade_Click(object sender, EventArgs e)
        {

        }

        private void Updatelabel()
        {
            float fps = 1000f / timerGameUpdate.Interval;
            labelClayAmt.Text = GameData.res_clay.ToString();
            labelIronAmt.Text = GameData.res_iron.ToString();
            labelWoodAmt.Text = GameData.res_wood.ToString();
            labelCropAmt.Text = GameData.res_crop.ToString();

            labelClayProduction.Text = GameData.produce_clay_sum.ToString();
            labelIronProduction.Text = GameData.produce_iron_sum.ToString();
            labelWoodProduction.Text = GameData.produce_wood_sum.ToString();
            labelCropProduction.Text = GameData.produce_crop_sum.ToString();

            labelFPS.Text = fps.ToString();
            labelSpeed.Text = game_speed.ToString() + "x";
        }

        private void timerGameUpdate_Tick(object sender, EventArgs e) // update game visual setiap 1000/60 = 16.67 frame (60 tick biar ga ngeleg)
        {
            Updatelabel();
            GameData.updateProduction();
        }

        private void timerProduction_Tick(object sender, EventArgs e)
        {
            GameData.res_clay += GameData.produce_clay_sum;
            GameData.res_iron += GameData.produce_iron_sum;
            GameData.res_wood += GameData.produce_wood_sum;
            GameData.res_crop += GameData.produce_crop_sum;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == '1')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 1;
                game_speed = 1;
            }

            if (e.KeyChar == '2')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 2;
                game_speed = 2;
            }

            if (e.KeyChar == '3')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 3;
                game_speed = 3;
            }

            if (e.KeyChar == '4')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 4;
                game_speed = 4;
            }

            if (e.KeyChar == '5')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 5;
                game_speed = 5;
            }

            if (e.KeyChar == '6')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 6;
                game_speed = 6;
            }

            if (e.KeyChar == '7')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 7;
                game_speed = 7;
            }

            if (e.KeyChar == '8')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 8;
                game_speed = 8;
            }

            if (e.KeyChar == '9')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 9;
                game_speed = 9;
            }

            if (e.KeyChar == '0')
            {
                timerProduction.Interval = 1000;
                timerProduction.Interval = timerProduction.Interval / 10;
                game_speed = 10;
            }

            // Debug Only: Change Game Update Speed
            if (e.KeyChar == '-')
            {
                timerGameUpdate.Interval = 60; // switch to 17.76 fps
            }

            if (e.KeyChar == '=')
            {
                timerGameUpdate.Interval = 40; // switch to 25 fps
            }
        }
    }
}

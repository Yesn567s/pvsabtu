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

        DataSet1 upg = new DataSet1();


        public Form1()
        {
            InitializeComponent();
            upgset();
            while(map.Count<100)
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

        private void upgset() // knee grow
        {
            upg.crop.AddcropRow(1, 40, 100, 50, 60, 260, 7, 0);
            upg.crop.AddcropRow(2, 65, 165, 85, 100, 620, 13, 6);
            upg.crop.AddcropRow(3, 110, 280, 140, 165, 1190, 21, 8);
            upg.crop.AddcropRow(4, 185, 465, 235, 280, 2100, 31, 10);
            upg.crop.AddcropRow(5, 310, 780, 390, 465, 3560, 46, 15);
            upg.crop.AddcropRow(6, 520, 1300, 650, 780, 5890, 70, 24);
            upg.crop.AddcropRow(7, 870, 2170, 1085, 1300, 9620, 98, 28);
            upg.crop.AddcropRow(8, 1450, 3625, 1810, 2175, 15590, 140, 42);
            upg.crop.AddcropRow(9, 2420, 6050, 3025, 3630, 25150, 203, 63);
            upg.crop.AddcropRow(10, 4040, 10105, 5050, 6060, 40440, 280, 77);
            upg.crop.AddcropRow(11, 6750, 16870, 8435, 10125, 64900, 392, 112);
            upg.crop.AddcropRow(12, 11270, 28175, 14090, 16905, 104050, 525, 133);
            upg.crop.AddcropRow(13, 18820, 47055, 23525, 28230, 166680, 693, 168);
            upg.crop.AddcropRow(14, 31430, 78580, 39290, 47150, 266880, 889, 196);
            upg.crop.AddcropRow(15, 52490, 131230, 65615, 78740, 427210, 1120, 231);
            upg.crop.AddcropRow(16, 87660, 219155, 109575, 131490, 683730, 1400, 280);
            upg.crop.AddcropRow(17, 146395, 365985, 182995, 219590, 1094170, 1820, 420);
            upg.crop.AddcropRow(18, 244480, 611195, 305600, 366715, 1750880, 2240, 420);
            upg.crop.AddcropRow(19, 408280, 1020695, 510350, 612420, 2801600, 2800, 560);
            upg.crop.AddcropRow(20, 681825, 1704565, 852280, 1022740, 4482770, 3430, 630);

            upg.clay.AddclayRow(1, 80, 40, 80, 50, 220, 7, 0);
            upg.clay.AddclayRow(2, 135, 65, 135, 85, 550, 13, 6);
            upg.clay.AddclayRow(3, 225, 110, 225, 140, 1080, 21, 8);
            upg.clay.AddclayRow(4, 375, 185, 375, 235, 1930, 31, 10);
            upg.clay.AddclayRow(5, 620, 310, 620, 390, 3290, 46, 15);
            upg.clay.AddclayRow(6, 1040, 520, 1040, 650, 5470, 70, 24);
            upg.clay.AddclayRow(7, 1735, 870, 1735, 1085, 8950, 98, 28);
            upg.clay.AddclayRow(8, 2900, 1450, 2900, 1810, 14520, 140, 42);
            upg.clay.AddclayRow(9, 4840, 2420, 4840, 3025, 23430, 203, 63);
            upg.clay.AddclayRow(10, 8080, 4040, 8080, 5050, 37690, 280, 77);
            upg.clay.AddclayRow(11, 13500, 6750, 13500, 8435, 60510, 392, 112);
            upg.clay.AddclayRow(12, 22540, 11270, 22540, 14090, 97010, 525, 133);
            upg.clay.AddclayRow(13, 37645, 18820, 37645, 23525, 155420, 693, 168);
            upg.clay.AddclayRow(14, 62865, 31430, 62865, 39290, 248870, 889, 196);
            upg.clay.AddclayRow(15, 104985, 52490, 104985, 65615, 398390, 1120, 231);
            upg.clay.AddclayRow(16, 175320, 87660, 175320, 109575, 637620, 1400, 280);
            upg.clay.AddclayRow(17, 292790, 146395, 292790, 182995, 1020390, 1820, 420);
            upg.clay.AddclayRow(18, 488955, 244480, 488955, 305600, 1632820, 2240, 420);
            upg.clay.AddclayRow(19, 816555, 408280, 816555, 510350, 2612710, 2800, 560);
            upg.clay.AddclayRow(20, 1363650, 681825, 1363650, 852280, 4180540, 3430, 630);

            upg.iron.AddironRow(1, 100, 80, 30, 60, 450, 7, 0);
            upg.iron.AddironRow(2, 165, 135, 50, 100, 920, 13, 6);
            upg.iron.AddironRow(3, 280, 225, 85, 165, 1670, 21, 8);
            upg.iron.AddironRow(4, 465, 375, 140, 280, 2880, 31, 10);
            upg.iron.AddironRow(5, 780, 620, 235, 465, 4800, 46, 15);
            upg.iron.AddironRow(6, 1300, 1040, 390, 780, 7880, 70, 24);
            upg.iron.AddironRow(7, 2170, 1735, 650, 1300, 12810, 98, 28);
            upg.iron.AddironRow(8, 3625, 2900, 1085, 2175, 20690, 140, 42);
            upg.iron.AddironRow(9, 6050, 4840, 1815, 3630, 33310, 203, 63);
            upg.iron.AddironRow(10, 10105, 8080, 3030, 6060, 53500, 280, 77);
            upg.iron.AddironRow(11, 16870, 13500, 5060, 10125, 85800, 392, 112);
            upg.iron.AddironRow(12, 28175, 22540, 8455, 16905, 137470, 525, 133);
            upg.iron.AddironRow(13, 47055, 37645, 14115, 28230, 220160, 693, 168);
            upg.iron.AddironRow(14, 78580, 62865, 23575, 47150, 352450, 889, 196);
            upg.iron.AddironRow(15, 131230, 104985, 39370, 78740, 564120, 1120, 231);
            upg.iron.AddironRow(16, 219155, 175320, 65745, 131490, 902790, 1400, 280);
            upg.iron.AddironRow(17, 365985, 292790, 109795, 219590, 1444660, 1820, 420);
            upg.iron.AddironRow(18, 611195, 488955, 183360, 366715, 2311660, 2240, 420);
            upg.iron.AddironRow(19, 1020695, 816555, 306210, 612420, 3698850, 2800, 560);
            upg.iron.AddironRow(20, 1704565, 1363650, 511370, 1022740, 5918370, 3430, 630);

            upg.wood.AddwoodRow(1, 40, 100, 50, 60, 260, 7, 0);
            upg.wood.AddwoodRow(2, 65, 165, 85, 100, 620, 13, 6);
            upg.wood.AddwoodRow(3, 110, 280, 140, 165, 1190, 21, 8);
            upg.wood.AddwoodRow(4, 185, 465, 235, 280, 2100, 31, 10);
            upg.wood.AddwoodRow(5, 310, 780, 390, 465, 3560, 46, 15);
            upg.wood.AddwoodRow(6, 520, 1300, 650, 780, 5890, 70, 24);
            upg.wood.AddwoodRow(7, 870, 2170, 1085, 1300, 9620, 98, 28);
            upg.wood.AddwoodRow(8, 1450, 3625, 1810, 2175, 15590, 140, 42);
            upg.wood.AddwoodRow(9, 2420, 6050, 3025, 3630, 25150, 203, 63);
            upg.wood.AddwoodRow(10, 4040, 10105, 5050, 6060, 40440, 280, 77);
            upg.wood.AddwoodRow(11, 6750, 16870, 8435, 10125, 64900, 392, 112);
            upg.wood.AddwoodRow(12, 11270, 28175, 14090, 16905, 104050, 525, 133);
            upg.wood.AddwoodRow(13, 18820, 47055, 23525, 28230, 166680, 693, 168);
            upg.wood.AddwoodRow(14, 31430, 78580, 39290, 47150, 266880, 889, 196);
            upg.wood.AddwoodRow(15, 52490, 131230, 65615, 78740, 427210, 1120, 231);
            upg.wood.AddwoodRow(16, 87660, 219155, 109575, 131490, 683730, 1400, 280);
            upg.wood.AddwoodRow(17, 146395, 365985, 182995, 219590, 1094170, 1820, 420);
            upg.wood.AddwoodRow(18, 244480, 611195, 305600, 366715, 1750880, 2240, 420);
            upg.wood.AddwoodRow(19, 408280, 1020695, 510350, 612420, 2801600, 2800, 560);
            upg.wood.AddwoodRow(20, 681825, 1704565, 852280, 1022740, 4482770, 3430, 630);
        }
    }
}

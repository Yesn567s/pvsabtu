using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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
            //Hide Posisi Button Asli (nanti hapus sama buttonnya)
            foreach(Control b in this.Controls) if(b is Button)b.Visible = false;
            genset();
            while (map.Count<100)
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
            uptimer();
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
            upg.crop.AddcropRow(1, 70, 90, 70, 20, 150, 7, 0);
            upg.crop.AddcropRow(2, 115, 150, 115, 35, 440, 13, 6);
            upg.crop.AddcropRow(3, 195, 250, 195, 55, 900, 21, 8);
            upg.crop.AddcropRow(4, 325, 420, 325, 95, 1650, 31, 10);
            upg.crop.AddcropRow(5, 545, 700, 545, 155, 2830, 46, 15);
            upg.crop.AddcropRow(6, 910, 1170, 910, 260, 4730, 70, 24);
            upg.crop.AddcropRow(7, 1520, 1950, 1520, 435, 7780, 98, 28);
            upg.crop.AddcropRow(8, 2535, 3260, 2535, 725, 12640, 140, 42);
            upg.crop.AddcropRow(9, 4235, 5445, 4235, 1210, 20430, 203, 63);
            upg.crop.AddcropRow(10, 7070, 9095, 7070, 2020, 32880, 280, 77);
            upg.crop.AddcropRow(11, 11810, 15185, 11810, 3375, 52810, 392, 112);
            upg.crop.AddcropRow(12, 19725, 25360, 19725, 5635, 84700, 525, 133);
            upg.crop.AddcropRow(13, 32940, 42350, 32940, 9410, 135710, 693, 168);
            upg.crop.AddcropRow(14, 55005, 70720, 55005, 15715, 217340, 889, 196);
            upg.crop.AddcropRow(15, 91860, 118105, 91860, 26245, 347950, 1120, 231);
            upg.crop.AddcropRow(16, 153405, 197240, 153405, 43830, 556910, 1400, 280);
            upg.crop.AddcropRow(17, 256190, 329385, 256190, 73195, 891260, 1820, 420);
            upg.crop.AddcropRow(18, 427835, 550075, 427835, 122240, 1426210, 2240, 420);
            upg.crop.AddcropRow(19, 714485, 918625, 714485, 204140, 2282140, 2800, 560);
            upg.crop.AddcropRow(20, 1193195, 1534105, 1193195, 340915, 3651630, 3430, 630);

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

        private void genset()
        {
            GameData.clay1.Location = new Point(239, 349);
            GameData.clay1.Size = new Size(15, 24);
            this.Controls.Add(GameData.clay1);
            GameData.clay1.BringToFront();

            GameData.clay2.Location = new Point(304, 150);
            GameData.clay2.Size = new Size(24, 27);
            this.Controls.Add(GameData.clay2);
            GameData.clay2.BringToFront();

            GameData.clay3.Location = new Point(370, 150);
            GameData.clay3.Size = new Size(21, 29);
            this.Controls.Add(GameData.clay3);
            GameData.clay3.BringToFront();

            GameData.clay4.Location = new Point(442, 331);
            GameData.clay4.Size = new Size(21, 24);
            this.Controls.Add(GameData.clay4);
            GameData.clay4.BringToFront();

            GameData.iron1.Location = new Point(175, 132);
            GameData.iron1.Size = new Size(22, 25);
            this.Controls.Add(GameData.iron1);
            GameData.iron1.BringToFront();

            GameData.iron2.Location = new Point(418, 189);
            GameData.iron2.Size = new Size(18, 23);
            this.Controls.Add(GameData.iron2);
            GameData.iron2.BringToFront();

            GameData.iron3.Location = new Point(465, 150);
            GameData.iron3.Size = new Size(28, 29);
            this.Controls.Add(GameData.iron3);
            GameData.iron3.BringToFront();

            GameData.iron4.Location = new Point(517, 187);
            GameData.iron4.Size = new Size(19, 27);
            this.Controls.Add(GameData.iron4);
            GameData.iron4.BringToFront();

            GameData.wood1.Location = new Point(239, 89);
            GameData.wood1.Size = new Size(22, 24);
            this.Controls.Add(GameData.wood1);
            GameData.wood1.BringToFront();

            GameData.wood2.Location = new Point(343, 358);
            GameData.wood2.Size = new Size(18, 24);
            this.Controls.Add(GameData.wood2);
            GameData.wood2.BringToFront();

            GameData.wood3.Location = new Point(352, 285);
            GameData.wood3.Size = new Size(25, 28);
            this.Controls.Add(GameData.wood3);
            GameData.wood3.BringToFront();

            GameData.wood4.Location = new Point(418, 102);
            GameData.wood4.Size = new Size(24, 29);
            this.Controls.Add(GameData.wood4);
            GameData.wood4.BringToFront();

            GameData.crop1.Location = new Point(111, 189);
            GameData.crop1.Size = new Size(24, 23);
            this.Controls.Add(GameData.crop1);
            GameData.crop1.BringToFront();

            GameData.crop2.Location = new Point(117, 262);
            GameData.crop2.Size = new Size(18, 26);
            this.Controls.Add(GameData.crop2);
            GameData.crop2.BringToFront();

            GameData.crop3.Location = new Point(201, 191);
            GameData.crop3.Size = new Size(26, 23);
            this.Controls.Add(GameData.crop3);
            GameData.crop3.BringToFront();

            GameData.crop4.Location = new Point(201, 245);
            GameData.crop4.Size = new Size(26, 26);
            this.Controls.Add(GameData.crop4);
            GameData.crop4.BringToFront();

            GameData.crop5.Location = new Point(494, 252);
            GameData.crop5.Size = new Size(21, 24);
            this.Controls.Add(GameData.crop5);
            GameData.crop5.BringToFront();

            GameData.crop6.Location = new Point(343, 83);
            GameData.crop6.Size = new Size(22, 30);
            this.Controls.Add(GameData.crop6);
            GameData.crop6.BringToFront();


            foreach(Control t in this.Controls)
            {
                if(t is Generator) t.Click += click;
            }
        }
        Generator point = null;
        private void click(object sender, EventArgs e)
        {
            foreach (Generator gen in this.Controls)
            {

                if(gen == sender)
                {
                    if (gen.level == 20)
                    {
                        MessageBox.Show("Maximum level reached.");
                        point = null;
                        break;
                    }
                    if (point != null)
                    {
                        if(gen.nama == point.nama)
                        {
                            point = null;
                            detail();
                            break;
                        }
                    }
                    
                    point = gen;
                    detail();
                    break;
                }
            }
            buttonUpgrade.Enabled = point != null;
        }
        int[] req = {0,0,0,0,0};
        private void detail()
        {
            labelDetails.Visible = point != null;
            if (point != null) 
            {
                int i;
                int lvl = point.level;
                if(point.resource_ref == 1)
                {
                    req[0] = (int)upg.clay.Rows[lvl]["clay"];
                    req[1] = (int)upg.clay.Rows[lvl]["iron"];
                    req[2] = (int)upg.clay.Rows[lvl]["wood"];
                    req[3] = (int)upg.clay.Rows[lvl]["crop"];
                    req[4] = (int)upg.clay.Rows[lvl]["waktu"];
                }
                else if(point.resource_ref == 2)
                {
                    req[0] = (int)upg.iron.Rows[lvl]["clay"];
                    req[1] = (int)upg.iron.Rows[lvl]["iron"];
                    req[2] = (int)upg.iron.Rows[lvl]["wood"];
                    req[3] = (int)upg.iron.Rows[lvl]["crop"];
                    req[4] = (int)upg.iron.Rows[lvl]["waktu"];
                }
                else if( point.resource_ref == 3)
                {
                    req[0] = (int)upg.wood.Rows[lvl]["clay"];
                    req[1] = (int)upg.wood.Rows[lvl]["iron"];
                    req[2] = (int)upg.wood.Rows[lvl]["wood"];
                    req[3] = (int)upg.wood.Rows[lvl]["crop"];
                    req[4] = (int)upg.wood.Rows[lvl]["waktu"];
                }
                else
                {
                    req[0] = (int)upg.crop.Rows[lvl]["clay"];
                    req[1] = (int)upg.crop.Rows[lvl]["iron"];
                    req[2] = (int)upg.crop.Rows[lvl]["wood"];
                    req[3] = (int)upg.crop.Rows[lvl]["crop"];
                    req[4] = (int)upg.crop.Rows[lvl]["waktu"];
                }
                string waktu = req[4] / 3600 + " Jam:" + req[4] / 60 % 60 + " Menit:" + req[4] % 60 + " Detik";
                    labelDetails.Text = "Level " + point.level + " | " + point.nama + "\n" +
                                        "Need " + req[0] + " Clay\n" +
                                        "Need " + req[1] + " Iron\n" +
                                        "Need " + req[2] + " Wood\n" +
                                        "Need " + req[3] + " Crop\n" +
                                        "Waktu: " + waktu;
            }
        }

        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            if(point != null)
            {
                if (point.active)
                {
                    MessageBox.Show("Currently being upgraded.");
                }
                else
                {
                    if(GameData.res_clay >= req[0] && 
                       GameData.res_iron >= req[1] && 
                       GameData.res_wood >= req[2] &&
                       GameData.res_crop >= req[3])
                    {
                        GameData.res_clay -= req[0];
                        GameData.res_iron -= req[1];
                        GameData.res_wood -= req[2];
                        GameData.res_crop -= req[3];
                        point.uptime = req[4]; 
                        point.active = true;
                        point = null;
                        detail();
                    }
                    else
                    {
                        MessageBox.Show("Not enough resource.");
                    }
                }
            }
        }

        private void uptimer()
        {
            labelTimer.Text = "";
            int i = 0;
            foreach (Generator gen in this.Controls.OfType<Generator>())
            {
                if (gen.active)
                {
                    i++;
                    gen.uptime -= 1;
                    int t = gen.uptime;
                    string waktu = t / 3600 + ":" + t / 60 % 60 + ":" + t % 60; 
                    labelTimer.Text += labelTimer.Text + gen.nama + " Lvl " + gen.level + " | " + waktu + "\n";
                    if (gen.uptime == 0)
                    {
                        gen.active = false;
                        gen.level+=1;
                        gen.Text = gen.level.ToString();
                        int lvl = gen.level - 1;
                        gen.production_rate = (int)upg.clay.Rows[lvl]["produksi"];
                    }
                }
            }
            
            labelTimer.Visible = i > 0;
        }

    }
}

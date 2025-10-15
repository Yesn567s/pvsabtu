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
        List<int>map=new List<int>();
        bool desa = false;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            while(map.Count<100)
            {
                int a = r.Next(0, 5);
                if (a==0)
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
            labelClayAmt.Text = GameData.res_clay.ToString();
            labelIronAmt.Text = GameData.res_iron.ToString();
            labelWoodAmt.Text = GameData.res_wood.ToString();
            labelCropAmt.Text = GameData.res_crop.ToString();

            labelClayProduction.Text = GameData.produce_clay_sum.ToString();
            labelIronProduction.Text = GameData.produce_iron_sum.ToString();
            labelWoodProduction.Text = GameData.produce_wood_sum.ToString();
            labelCropProduction.Text = GameData.produce_crop_sum.ToString();
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
    }
}

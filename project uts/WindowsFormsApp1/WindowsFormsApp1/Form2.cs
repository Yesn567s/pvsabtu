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
    public partial class Form2 : Form
    {
        List<int> mapa = new List<int>();
        List<Button> buttons = new List<Button>();
        Button getoverhere, scorpion;
        bool moving = false;
        private int cropConsumptionCounter = 0; // ms accumulator for crop consumption
        public Form2()
        {
            InitializeComponent();
        }
        private void B_Click(object sender, EventArgs e)
        {
            if (moving) return; // Prevent pulling another while moving
            getoverhere = (Button)sender;
            if (getoverhere.BackColor == Color.Black)
            {
                // Do nothing
            }
            else
            {
                foreach (Button b in buttons)
                {
                    if (b.BackColor == Color.Black)
                    {
                        scorpion = b;
                        break;
                    }
                }
                moving = true;
                getoverhere.BringToFront();
                // Set timer interval based on current animation speed multiplier
                int mult = Math.Max(1, GameData.animationSpeedMultiplier);
                timer1.Interval = mult == 10 ? 100 : 1000 / mult;
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // --- Crop consumption logic ---
            cropConsumptionCounter += timer1.Interval;
            if (cropConsumptionCounter >= 1000) // 1 second passed
            {
                if (GameData.res_crop >= 500)
                {
                    GameData.res_crop -= 500;
                    cropConsumptionCounter -= 1000;
                }
                else
                {
                    // Not enough crop, stop animation
                    moving = false;
                    timer1.Stop();
                    return;
                }
            }

            int newX = getoverhere.Location.X;
            int newY = getoverhere.Location.Y;

            if (newX < scorpion.Location.X)
                newX += 10;
            else if (newX > scorpion.Location.X)
                newX -= 10;

            if (newY < scorpion.Location.Y)
                newY += 10;
            else if (newY > scorpion.Location.Y)
                newY -= 10;

            getoverhere.Location = new Point(newX, newY);

            if (getoverhere.Location == scorpion.Location)
            {
                moving = false;
                this.Controls.Remove(getoverhere);
                // Change to white to indicate 'empty' (or remove if you prefer)
                getoverhere.BackColor = Color.White;
                // Optionally: this.Controls.Remove(getoverhere);
                GlobalData.upg.Hunt.Rows[buttons.IndexOf(getoverhere)].Delete();
                buttons.RemoveAt(buttons.IndexOf(getoverhere));
                timer1.Stop();
                // --- Bonus produksi: +25% permanent, akumulatif ---
                // Apply multiplier based on color
                if (scorpion.BackColor == Color.Gray)
                    GameData.ironProductionMultiplier *= 1.25;
                else if (scorpion.BackColor == Color.Green)
                    GameData.woodProductionMultiplier *= 1.25;
                else if (scorpion.BackColor == Color.Yellow)
                    GameData.cropProductionMultiplier *= 1.25;
                else if (scorpion.BackColor == Color.Red)
                    GameData.clayProductionMultiplier *= 1.25;
            }
            this.Invalidate(); // Redraw the form
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (moving && getoverhere != null && scorpion != null)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.BlueViolet, 2);
                Point p1 = new Point(getoverhere.Left + getoverhere.Width / 2,
                                        getoverhere.Top + getoverhere.Height / 2);
                Point p2 = new Point(scorpion.Left + scorpion.Width / 2,
                                        scorpion.Top + scorpion.Height / 2);
                g.DrawLine(pen, p1, p2);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button b = new Button();
                    b.Size = new Size(50, 50);
                    int x = Convert.ToInt32(GlobalData.upg.Hunt.Rows[i * 10 + j].ItemArray[0]);
                    int y = Convert.ToInt32(GlobalData.upg.Hunt.Rows[i * 10 + j].ItemArray[1]);
                    b.Location = new Point(x * 50, y * 50);
                    string val = GlobalData.upg.Hunt.Rows[i * 10 + j].ItemArray[2].ToString();
                    if (val == "0")
                    {
                        b.BackColor = Color.Black;
                    }
                    else if (val == "1")
                    {
                        b.BackColor = Color.Green;
                    }
                    else if (val == "2")
                    {
                        b.BackColor = Color.Yellow;
                    }
                    else if (val == "3")
                    {
                        b.BackColor = Color.Gray;
                    }
                    else if (val == "4")
                    {
                        b.BackColor = Color.Red;
                    }
                    b.Click += B_Click;
                    buttons.Add(b);
                    this.Controls.Add(b);
                }
            }
        }
    }
}

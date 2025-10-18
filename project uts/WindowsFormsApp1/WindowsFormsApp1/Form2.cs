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
        List<Button> pullingButtons = new List<Button>();
        Button scorpion;
        bool moving = false;
        private int cropConsumptionCounter = 0; // ms accumulator for crop consumption
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
            GameData.AnimationSpeedChanged += OnAnimationSpeedChanged;
        }

        private void OnAnimationSpeedChanged()
        {
            if (moving)
            {
                int mult = Math.Max(1, GameData.animationSpeedMultiplier);
                timer1.Interval = mult == 10 ? 100 : 1000 / mult;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (clicked.BackColor == Color.Black)
            {
                // clicking the scorpion does nothing
                return;
            }

            // If the button is already disabled or white, ignore
            if (!clicked.Enabled || clicked.BackColor == Color.White)
                return;

            // If this button is already scheduled to be pulled, ignore
            if (pullingButtons.Contains(clicked))
                return;

            // Find scorpion if not known
            if (scorpion == null)
            {
                foreach (Button b in buttons)
                {
                    if (b.BackColor == Color.Black)
                    {
                        scorpion = b;
                        break;
                    }
                }
            }

            // Add to list of buttons to pull
            pullingButtons.Add(clicked);
            // Bring it to front so it's visible
            clicked.BringToFront();

            // If not moving, start the timer now
            if (!moving)
            {
                // Original startup crop check preserved but commented out for teacher reference
                // int requiredStart = 500 * Math.Max(1, pullingButtons.Count);
                // if (GameData.res_crop < requiredStart)
                // {
                //     MessageBox.Show($"Not enough crop to pull! (Need at least {requiredStart})", "Insufficient Crop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //     pullingButtons.Clear();
                //     return;
                // }

                // Start pulling even if current crop is insufficient; if crop runs out later, timer tick will stop and save positions.
                moving = true;
                // Set timer interval based on current animation speed multiplier
                int mult = Math.Max(1, GameData.animationSpeedMultiplier);
                timer1.Interval = Math.Max(100, 1000 / mult); // Always 1000ms at 1x, faster as multiplier increases, min 100ms
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pullingButtons.Count == 0 || scorpion == null)
            {
                moving = false;
                timer1.Stop();
                return;
            }

            // --- Crop consumption logic ---
            cropConsumptionCounter += timer1.Interval;
            if (cropConsumptionCounter >= 1000) // 1 second passed
            {
                int costPerButton = 500;
                int required = costPerButton * pullingButtons.Count;
                if (GameData.res_crop >= required)
                {
                    GameData.res_crop -= required;
                }
                else
                {
                    // Not enough crop, stop pulling and write current positions back to dataset
                    moving = false;
                    timer1.Stop();
                    UpdateDatasetPositionsForAllPulling();
                    MessageBox.Show("Not enough crop to continue pulling! Positions saved.", "Insufficient Crop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cropConsumptionCounter -= 1000;
            }

            // Move each pulling button towards the scorpion
            // Use a copy of list because we may remove items while iterating
            var toProcess = pullingButtons.ToList();
            foreach (var btn in toProcess)
            {
                int newX = btn.Location.X;
                int newY = btn.Location.Y;

                if (newX < scorpion.Location.X)
                    newX += 10;
                else if (newX > scorpion.Location.X)
                    newX -= 10;

                if (newY < scorpion.Location.Y)
                    newY += 10;
                else if (newY > scorpion.Location.Y)
                    newY -= 10;

                btn.Location = new Point(newX, newY);

                if (btn.Location == scorpion.Location)
                {
                    // Reached destination
                    // Apply multiplier based on color BEFORE setting to white
                    if (btn.BackColor == Color.Gray)
                        GameData.ironProductionMultiplier += 0.25;
                    else if (btn.BackColor == Color.Green)
                        GameData.woodProductionMultiplier += 0.25;
                    else if (btn.BackColor == Color.Yellow)
                        GameData.cropProductionMultiplier += 0.25;
                    else if (btn.BackColor == Color.Red)
                        GameData.clayProductionMultiplier += 0.25;
                    GameData.updateProduction(); // Ensure production values are updated after multiplier change

                    // Remove button visual and mark disabled
                    this.Controls.Remove(btn);
                    // Mark as empty in dataset and set coordinates to scorpion pixel location
                    int idx = buttons.IndexOf(btn);
                    if (idx >= 0 && idx < GlobalData.upg.Hunt.Rows.Count)
                    {
                        int scX = scorpion.Location.X;
                        int scY = scorpion.Location.Y;
                        GlobalData.upg.Hunt.Rows[idx][0] = scX.ToString();
                        GlobalData.upg.Hunt.Rows[idx][1] = scY.ToString();
                        GlobalData.upg.Hunt.Rows[idx][2] = "5"; // disabled
                    }
                    btn.BackColor = Color.White;
                    btn.Enabled = false;
                    pullingButtons.Remove(btn);
                }
            }

            // If no more pulling buttons left, stop
            if (pullingButtons.Count == 0)
            {
                moving = false;
                timer1.Stop();
            }

            this.Invalidate(); // Redraw the form
        }

        private void UpdateDatasetPositionsForAllPulling()
        {
            // Update dataset with current positions (store pixel coordinates)
            foreach (var btn in pullingButtons)
            {
                int idx = buttons.IndexOf(btn);
                if (idx >= 0 && idx < GlobalData.upg.Hunt.Rows.Count)
                {
                    int px = btn.Location.X;
                    int py = btn.Location.Y;
                    GlobalData.upg.Hunt.Rows[idx][0] = px.ToString();
                    GlobalData.upg.Hunt.Rows[idx][1] = py.ToString();
                    // preserve type value in [2]
                }
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (moving && scorpion != null && pullingButtons != null && pullingButtons.Count > 0)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.BlueViolet, 2);
                Point p2 = new Point(scorpion.Left + scorpion.Width / 2,
                                        scorpion.Top + scorpion.Height / 2);
                foreach (var getoverhere in pullingButtons)
                {
                    Point p1 = new Point(getoverhere.Left + getoverhere.Width / 2,
                                            getoverhere.Top + getoverhere.Height / 2);
                    g.DrawLine(pen, p1, p2);
                }
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
                    // Support dataset that may already store scaled coordinates
                    if (x >= 0 && x <= 9 && y >= 0 && y <= 9)
                        b.Location = new Point(x * 50, y * 50);
                    else
                        b.Location = new Point(x, y);
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
                    else if(val == "5")
                    {
                        b.Enabled = false;
                        b.BackColor = Color.White;
                    }
                    b.Click += B_Click;
                    buttons.Add(b);
                    this.Controls.Add(b);
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save current positions of any buttons still being pulled
            if (pullingButtons != null && pullingButtons.Count > 0)
            {
                UpdateDatasetPositionsForAllPulling();
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                int mult = e.KeyChar - '0';
                GameData.SetAnimationSpeedMultiplier(mult);
            }
            else if (e.KeyChar == '0')
            {
                GameData.SetAnimationSpeedMultiplier(10);
            }
        }  
    }
}

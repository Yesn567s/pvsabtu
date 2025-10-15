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
        public Form2(List<int> map)
        {
            InitializeComponent();
            mapa = map;
        }
        private void B_Click(object sender, EventArgs e)
        {
            //Button b = (Button)sender;
            //int index = (int)b.Tag;
            //if (mapa.Contains(index))
            //{
            //    b.BackColor = Color.Red;
            //    MessageBox.Show("Hit!");
            //}
            //else
            //{
            //    b.BackColor = Color.Blue;
            //    MessageBox.Show("Miss!");
            //}
            //b.Enabled = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) { 
                for(int j=0;j<10;j++)
                {
                    Button b = new Button();
                    b.Size = new Size(50, 50);
                    b.Location = new Point(i * 50, j * 50);
                    if (mapa[i*10+j]==0)
                    {
                        b.BackColor= Color.Black;
                    }
                    else if (mapa[i * 10 + j] ==1)
                    {
                        b.BackColor=Color.Green;
                    }
                    else if (mapa[i * 10 + j] == 2)
                    {
                        b.BackColor=Color.Yellow;
                    }
                    else if (mapa[i * 10 + j] == 3)
                    {
                        b.BackColor=Color.Gray;
                    }
                    else if(mapa[i * 10 + j] == 4)
                    {
                        b.BackColor=Color.Red;
                    }
                    b.Click += B_Click;
                    buttons.Add(b);
                    this.Controls.Add(b);
                }
            }
        }
    }
}

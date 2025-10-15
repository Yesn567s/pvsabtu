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
        }

        private void huntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(map);
            f2.ShowDialog();
        }
    }
}

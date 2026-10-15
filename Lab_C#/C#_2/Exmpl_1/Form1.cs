using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exmpl_1
    {
    public partial class Form1 : Form
    {
        int x, y;
        Graphics Graph;
        Random Rand;

        public Form1()
        {
            InitializeComponent();

            Text = "Лабараторная 2.1: пунктирные отрезки";

            Graph = CreateGraphics();
            Rand = new Random();
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Color color = Color.FromArgb(
                Rand.Next(256),
                Rand.Next(256),
                Rand.Next(256)
            );

            float width = Rand.Next(1, 11);

            Pen MyPen = new Pen(color, width);

            float dash = Rand.Next(2, 11);
            float gap = Rand.Next(2, 11);
            MyPen.DashPattern = new float[] { dash, gap };

            Graph.DrawLine(MyPen, x, y, e.X, e.Y);

            MyPen.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Graph.Dispose();
        }
    }
}
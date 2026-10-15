using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exmpl_2
{
    public partial class Form1 : Form
    {
        Graphics Graph;

        public Form1()
        {
            InitializeComponent();

            Text = "Лаба 2.2: Снежинки";
            this.BackColor = Color.Blue;

            Graph = CreateGraphics();

            this.MouseClick += Form1_MouseClick;
            this.FormClosing += Form1_FormClosing;
        }

        private void DrawSnowflake(int cx, int cy, int radius)
        {
            Pen whitePen = new Pen(Color.White, 2);

            // 8 лучей под углом 45 градусов
            for (int i = 0; i < 8; i++)
            {
                double angle = i * Math.PI / 4; // 0, 45, 90, ... 315 градусов

                int endX = cx + (int)(radius * Math.Cos(angle));
                int endY = cy + (int)(radius * Math.Sin(angle));

                // Главный луч
                Graph.DrawLine(whitePen, cx, cy, endX, endY);

                // Маленькие ответвления у конца луча (две веточки)
                int branchLen = radius / 3;
                int bx = cx + (int)(radius * 0.6 * Math.Cos(angle));
                int by = cy + (int)(radius * 0.6 * Math.Sin(angle));

                // Веточка влево от луча
                double leftAngle = angle + Math.PI / 4;
                int leftX = bx + (int)(branchLen * Math.Cos(leftAngle));
                int leftY = by + (int)(branchLen * Math.Sin(leftAngle));
                Graph.DrawLine(whitePen, bx, by, leftX, leftY);

                // Веточка вправо от луча
                double rightAngle = angle - Math.PI / 4;
                int rightX = bx + (int)(branchLen * Math.Cos(rightAngle));
                int rightY = by + (int)(branchLen * Math.Sin(rightAngle));
                Graph.DrawLine(whitePen, bx, by, rightX, rightY);
            }

            whitePen.Dispose();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawSnowflake(e.X, e.Y, 30);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Graph.Dispose();
        }
    }
}

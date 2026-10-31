using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exmpl_4
{
    public partial class Form1 : Form
    {
        private List<(Point Start, Point End, float Widht)> drawnLines = new List<(Point, Point, float)>();

        private List<Point> currentPoints = new List<Point>();

        private float currentThickness;

        private Random rnd = new Random();

        public Form1()  {
            InitializeComponent();
            Text = "Лаба 2.4. Треугольники";
            DoubleBuffered = true;

            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)   {
            if (e.Button != MouseButtons.Left) return;

            currentPoints.Add(e.Location);

            if (currentPoints.Count == 2)
            {
                currentThickness = rnd.Next(1, 8);
                drawnLines.Add((currentPoints[0], currentPoints[1], currentThickness));
            }
            else if (currentPoints.Count == 3) {
                drawnLines.Add((currentPoints[1], currentPoints[2], currentThickness));
                drawnLines.Add((currentPoints[2], currentPoints[0], currentThickness));
            
                currentPoints.Clear();
            }

            Invalidate();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)   {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (var line in drawnLines) 
            {
                using (Pen pen = new Pen(Color.Black, line.Widht))
                {
                    e.Graphics.DrawLine(pen, line.Start, line.End);
                }
            }     
        }
    }
}

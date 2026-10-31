using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Exmpl_5
{
    public partial class Form1 : Form
    {
        private class Polyline
        {
            public List<Point> Points = new List<Point>();
            public Color LineColor;
        }

        private List<Polyline> finishedPolylines = new List<Polyline>();

        private Polyline currentPolyline = null;

        private bool isDrawing = false;

        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            Text = "Лаба 2.5. Замкнутые ломаные";
            DoubleBuffered = true;

            this.Paint += Form1_Paint;
            this.MouseClick += Form1_MouseClick;
            this.MouseDoubleClick += Form1_MouseDoubleClick;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            if (!isDrawing)
            {
                isDrawing = true;
                currentPolyline = new Polyline();
                currentPolyline.LineColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                currentPolyline.Points.Add(e.Location);
            }
            else
            {
                isDrawing = false;

                finishedPolylines.Add(currentPolyline);
                currentPolyline = null;
            }

            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            if (isDrawing)
            {
                currentPolyline.Points.Add(e.Location);
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (var polyline in finishedPolylines)
            {
                DrawPolyline(e.Graphics, polyline, true);
            }

            if (isDrawing && currentPolyline != null && currentPolyline.Points.Count > 0)
            {
                DrawPolyline(e.Graphics, currentPolyline, false);
            }
        }

        private void DrawPolyline(Graphics g, Polyline polyline, bool isClosed)
        {
            if (polyline.Points.Count < 2) return;

            using (Pen pen = new Pen(polyline.LineColor, 2f))
            {
                Point[] points = polyline.Points.ToArray();

                g.DrawLines(pen, points);

                if (isClosed)
                {
                    g.DrawLine(pen, polyline.Points[polyline.Points.Count - 1], polyline.Points[0]);
                }
            }
        }
    }
}
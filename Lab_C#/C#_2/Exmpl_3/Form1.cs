using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Exmpl_3
{
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            Text = "Лаба 2.3. Эллипсы";
            DoubleBuffered = true;
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color[] colors = {
                Color.Brown,
                Color.OrangeRed,
                Color.Gold,
                Color.ForestGreen,
                Color.RoyalBlue
            };
            float[] thicknesses = { 2f, 4f, 6f, 8f, 10f };

            int cx = ClientSize.Width / 2; 
            int cy = ClientSize.Height / 2;
            int baseRadius = Math.Min(ClientSize.Width, ClientSize.Height) / 2 - 40;

            if (baseRadius <= 0) return;

            for (int i = 0; i < colors.Length; i++) {
                int r = baseRadius - i * 22;
                if (r < 10) break;

                Rectangle rect = new Rectangle(cx - r, cy - r, r * 2, r * 2);

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(90, colors[i])))
                    using (Pen pen = new Pen(colors[i], thicknesses[i]))    {

                        e.Graphics.FillEllipse(brush, rect);
                        e.Graphics.DrawEllipse(pen, rect);
                    }

            }
        }
    }
}
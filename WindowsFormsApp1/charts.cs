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
    public partial class charts : Form
    {
        public charts()
        {
            InitializeComponent();
        }

       
            private void panelChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            string[] labels = { "Patients", "Appointments", "Bills", "Doctors" };
            int[] values = { 40, 25, 18, 10 };
            Brush[] colors = { Brushes.SteelBlue, Brushes.SeaGreen, Brushes.Orange, Brushes.IndianRed };

            int left = 50, bottom = panelChart.Height - 40, top = 40;
            int chartHeight = bottom - top;
            int barWidth = 60, gap = 65;
            int maxValue = 50;

            using (Font titleFont = new Font("Century Gothic", 12, FontStyle.Bold))
            using (Font textFont = new Font("Century Gothic", 9))
            using (Pen axisPen = new Pen(Color.Black, 2))
            {
                g.DrawString("Clinic Statistics", titleFont, Brushes.Black, 150, 8);

                g.DrawLine(axisPen, left, top, left, bottom);
                g.DrawLine(axisPen, left, bottom, panelChart.Width - 20, bottom);

                for (int i = 0; i < values.Length; i++)
                {
                    int barHeight = values[i] * chartHeight / maxValue;
                    int x = left + gap + i * (barWidth + gap);
                    int y = bottom - barHeight;

                    g.FillRectangle(colors[i], x, y, barWidth, barHeight);
                    g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);

                    g.DrawString(values[i].ToString(), textFont, Brushes.Black, x + 18, y - 18);
                    g.DrawString(labels[i], textFont, Brushes.Black, x - 5, bottom + 6);
                }
            }        
    }
    }
}

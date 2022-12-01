using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polar
{
    public partial class Form1 : Form
    {
        private double r, fi, x;
        
        public Form1()
        {
            InitializeComponent();
        }

       private void pictureBoxGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen penGray = new Pen(Color.LightGray, 2);
            Pen penBlack = new Pen(Color.Black, 2);
            SolidBrush brushGray = new SolidBrush(Color.LightGray);
            g.FillEllipse(brushGray, (int)(pictureBoxGraph.Width / 2 - 4 / 2), (int)(pictureBoxGraph.Height / 2 - 4 / 2), 4, 4);
            g.DrawEllipse(penGray, (int)(pictureBoxGraph.Width / 3 - (int)(pictureBoxGraph.Width / 3 / 2)), (int)(pictureBoxGraph.Height / 3 - (int)(pictureBoxGraph.Width / 3 / 2)),
                (int)(pictureBoxGraph.Width * 2 / 3), (int)(pictureBoxGraph.Width * 2 / 3));
            g.DrawEllipse(penGray, (int)(pictureBoxGraph.Width * 2 / 3 - (int)(pictureBoxGraph.Width * 2 / 3 / 2)), (int)(pictureBoxGraph.Height * 2 / 3 - (int)(pictureBoxGraph.Width * 2 / 3 / 2)),
                (int)(pictureBoxGraph.Width  / 3), (int)(pictureBoxGraph.Width / 3));
            g.DrawEllipse(penGray, 0, 0, pictureBoxGraph.Width, pictureBoxGraph.Height);
            for (fi = 0; fi <= 32 * Math.PI; fi += 0.001)
            {
                x = fi;
                r = 3*Math.Cos(30*fi+5);
                g.DrawEllipse(penBlack, (int)((pictureBoxGraph.Width / 2) + (r * Math.Cos(fi) * 100)), (int)((pictureBoxGraph.Height / 2) + (r * Math.Sin(fi) * 100)), 1, 1);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

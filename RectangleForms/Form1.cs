using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RectangleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                {
                    Application.Exit();
                }
                int posX = e.X;
                int posY = e.Y;
                if (posX > 10 && posY > 10 && posX < this.Width - 10 && posY < this.Height - 10)
                {
                    MessageBox.Show($"Курсор в прямоугольнике");
                }
                else if (posX < 10 || posY < 10 || posX > this.Width - 10 || posY > this.Height - 10)
                {
                    MessageBox.Show("Курсор вне прямоугольника");
                }
                else
                {
                    MessageBox.Show("Курсор на границе прямоугольника");
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = $"Ширина = {this.Width} Высота = {this.Height}";
                Thread.Sleep(1000);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X {e.X} - Y {e.Y}";
        }
    }
}

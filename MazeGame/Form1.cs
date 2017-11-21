using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();

#if !DEBUG
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
#endif
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You won !","Wow");
            Close();
        }
        private void MoveToStart()
        {
            Point startPoint = panel1.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
        int flag = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                label97.Enabled = true;
                label97.Visible = true;
                flag = 1;
            }
            else
            {
                label97.Enabled = false;
                label97.Visible = false;
                flag = 0;
            }
        }
    }
}

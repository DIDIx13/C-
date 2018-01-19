using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Musitheque m = new Musitheque(@"M:\226A\Musitheque"); // Where's your music ?
                m.Scan();
                listBox1.DataSource = m.getFichier();
            }
            catch
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spotrebic s = new Spotrebic("K7f9e", 159, new DateTime(2025, 9, 6), new DateTime(2025, 9, 15));

            Pracka p = new Pracka("156sad", 267, new DateTime(2025, 9, 6), new DateTime(2025, 9, 15), true);

            MessageBox.Show(s.ToString() + "\n" + p.ToString());
        }
    }
}

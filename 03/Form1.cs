using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pracovnik p = new Pracovnik("kok", 45000, 2000, new DateTime(2010, 3,3));
            StalyZamestnanec S = new StalyZamestnanec("kok", 25000, 3000, new DateTime(2010, 5, 14), 1000);
            MessageBox.Show(p.ToString() + "\n" + S.ToString());
        }
    }
}

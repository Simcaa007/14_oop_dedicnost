using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jmeno = textBox1.Text;
            int plat = int.Parse(textBox2.Text);
            DateTime narozeni = dateTimePicker1.Value;

            Zamestnanec z = new Zamestnanec(jmeno, narozeni, plat);
            ZamestnanecZK zk = new ZamestnanecZK("kok", new DateTime(2005, 6, 18), 32000, true);

            MessageBox.Show(z.ToString() + "\n" + zk.ToString());
        }
    }
}

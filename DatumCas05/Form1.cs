using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumCas05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int sleva = 0;
            if (Class1.MinTrvanlivostDny(dateTimePicker1.Value, x, y, out sleva))
            {
                MessageBox.Show("Ano, je prodejne" + "cena je " + sleva);
            }
            else
            {
                MessageBox.Show("Zbozi neni prodejne");
            }
        }
    }
}

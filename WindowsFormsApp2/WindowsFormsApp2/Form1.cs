using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("FIAT");
            comboBox1.Items.Add("RENAULT");
            comboBox1.Items.Add("AUDI");
            comboBox1.Items.Add("TOGG");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("LINEA");
                comboBox2.Items.Add("EGEA");
                comboBox2.Items.Add("CROSS");
            }
            else if (comboBox1.Text == "RENAULT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("MEGANE");
                comboBox2.Items.Add("TAILANT");
                comboBox2.Items.Add("CLIO");
            }
            else if (comboBox1.Text == "AUDI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A3");
                comboBox2.Items.Add("A4");
                comboBox2.Items.Add("A5");
            }
            else if (comboBox1.Text == "TOGG")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("SUV");
                comboBox2.Items.Add("SEDAN");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "LINEA")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("LINEA-1.2");
                comboBox3.Items.Add("LINEA-1.3");
            }
            else if (comboBox2.Text == "EGEA")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("EGEA-1.2");
                comboBox3.Items.Add("EGEA-1.3");
            }
            else if (comboBox2.Text == "CROSS")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("CROSS-1.2");
                comboBox3.Items.Add("CROSS-1.3");
            }

            else if (comboBox2.Text == "MEGANE")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("MEGANE-1.2");
                comboBox3.Items.Add("MEGANE-1.3");
            }
            else if (comboBox2.Text == "TAILANT")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("TAILANT-1.2");
                comboBox3.Items.Add("TAILANT-1.3");
            }
            else if (comboBox2.Text == "SUV")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("SEDAN");
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("MARKA: "+comboBox1.Text+ " MODEL: "+comboBox2.Text
            +" VERSİYON: "+comboBox3.Text);
        }
    }
}

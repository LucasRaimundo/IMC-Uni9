using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float kg = float.Parse(this.textBox1.Text);
            float met = float.Parse(this.textBox2.Text);
            float imc =  kg / (met * met);

            string imcText = imc.ToString();

            label4.Text = "Seu IMC é de " + imcText;
            label4.Visible = true;

            if (imc < 18.5)
            {
                label5.Text = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                label5.Text = "Peso normal";
            }
            else if (imc < 30)
            {
                label5.Text = "Sobrepeso";
            }
            else
            {
                label5.Text = "Obeso";
            }

            label5.Visible = true;
        }
    }
}

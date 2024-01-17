using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumdedosnumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = tb1.Text;
            string s2 = tb2.Text;
            int valor1 = int.Parse(s1);
            int valor2 = int.Parse(s2);
            int suma = valor1 + valor2;
            string s3 = suma.ToString();
            resultado.Text = "El resultado es: " + s3;
        }
    }
}

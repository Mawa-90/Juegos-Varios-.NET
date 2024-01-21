using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2LUG
{
    public partial class Nombre : UserControl
    {
        public Nombre()
        {
            InitializeComponent();
        }

        public bool checkSoloLetras()
        {

            return Regex.IsMatch(textBox1.Text, @"^[a-z A-Z]+$");

        }

        public override string Text { get => textBox1.Text.ToLower(); set => textBox1.Text = value; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

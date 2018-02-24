using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ResultText.Text = Logic.GetBinarySystem(int.Parse(EnterText.Text));

        }

        private void ResultText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

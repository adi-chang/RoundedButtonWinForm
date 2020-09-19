using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundedButtonWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, You Click On Me ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, You Click On Me ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, You Click On Me ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Programs_With_C_sharp
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application consist of small programs for helping in everyday life.\nAuthor: Remizov Pavel", "About");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblCount.Text = (++count).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblCount.Text = (--count).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = rnd.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value+1);
            lblRandom.Text = number.ToString(); 
        }
    }
}

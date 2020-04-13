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
            if (cbGeneratorNoRepetition.Checked)
            {
                if (tbRandom.Text.IndexOf(number.ToString()) == -1)
                    tbRandom.AppendText(number.ToString() + Environment.NewLine);
            }
            else tbRandom.AppendText(number.ToString() + Environment.NewLine);
        }

        private void btnGeneratorClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnGeneratorCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void tsmiDate_Click(object sender, EventArgs e)
        {
            rtbNote.AppendText(DateTime.Now.ToShortDateString());
        }

        private void tsmiTime_Click(object sender, EventArgs e)
        {
            rtbNote.AppendText(DateTime.Now.ToShortTimeString());
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNote.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Error while saving file", "Error");
            }
        }
        void LoadNotepad()
        {
            try
            {
                rtbNote.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Error while loading file", "Error");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }
    }
}

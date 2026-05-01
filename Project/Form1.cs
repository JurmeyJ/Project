using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowScreen(new Inventory());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowScreen(UserControl newScreen)
        {
            foreach(Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }
            pnlContent.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newScreen);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockAndAnchorStyles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DockTopBtn_Click(object sender, EventArgs e)
        {
            textBox1.Dock = DockStyle.Top;
        }

        private void DockBottomBtn_Click(object sender, EventArgs e)
        {
            textBox1.Dock = DockStyle.Bottom;
        }

        private void DockRightBtn_Click(object sender, EventArgs e)
        {
            textBox1.Dock = DockStyle.Right;
        }

        private void DockLeftBtn_Click(object sender, EventArgs e)
        {
            textBox1.Dock = DockStyle.Left;
        }

        private void AnchorTopRightBtn_Click(object sender, EventArgs e)
        {
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        private void AnchorTopLeftBtn_Click(object sender, EventArgs e)
        {
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }

        private void AnchorBottomRightBtn_Click(object sender, EventArgs e)
        {
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void AnchorBottomLeftBtn_Click(object sender, EventArgs e)
        {
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void DockFillBtn_Click(object sender, EventArgs e)
        {
            textBox1.Dock = DockStyle.Fill;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox1.Multiline = true;
            string multiLineText = "Редактор Текста\nСоздан в Visual Studio\nИспользовалась технология WinForm";
            textBox1.Text = multiLineText;

        }


            private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }
    }
}

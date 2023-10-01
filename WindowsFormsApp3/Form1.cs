using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;


                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".txt")
                {

                    string fileContent = File.ReadAllText(filePath);
                    richTextBox1.Text = fileContent;
                }
                else
                {
                    MessageBox.Show("Выберите файл формата TXT.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы формата .txt|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    File.WriteAllText(filePath, string.Empty);
                }
                catch { }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    string fileContent = richTextBox1.Text;

                    File.WriteAllText(filePath, fileContent);

                    MessageBox.Show("Файл успешно сохранен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void панельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            панельИнструментовToolStripMenuItem.Checked = toolStrip1.Visible;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.Font = richTextBox1.SelectionFont;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font newFont = new Font(
                    fontDialog.Font.FontFamily,
                    fontDialog.Font.Size,
                    fontDialog.Font.Style);
                richTextBox1.SelectionFont = newFont;
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.Color = richTextBox1.SelectionColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы формата .txt|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    File.WriteAllText(filePath, string.Empty);
                }
                catch { }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;


                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".txt")
                {

                    string fileContent = File.ReadAllText(filePath);
                    richTextBox1.Text = fileContent;
                }
                else
                {
                    MessageBox.Show("Выберите файл формата TXT.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    string fileContent = richTextBox1.Text;

                    File.WriteAllText(filePath, fileContent);

                    MessageBox.Show("Файл успешно сохранен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Vladislav");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }
        private bool colorChanging = false;
        private Color originalBackgroundColor;

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (!colorChanging)
            {
                originalBackgroundColor = this.BackColor;
                colorChanging = true;

                Timer colorChangeTimer = new Timer();
                colorChangeTimer.Interval = 500;

                colorChangeTimer.Tick += (timerSender, timerArgs) =>
                {
                    if (!colorChanging)
                    {
                        this.BackColor = Color.WhiteSmoke;
                        colorChangeTimer.Stop();
                        return;
                    }
                    Random random = new Random();
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    this.BackColor = randomColor;
                };
                colorChangeTimer.Start();
            }
            else
            {
                this.BackColor = originalBackgroundColor;
                colorChanging = false;
            }
        }
    }
}

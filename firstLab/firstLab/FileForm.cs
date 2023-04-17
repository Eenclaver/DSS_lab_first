using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstLab
{
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        private void bt_upload_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            double filedata;
            // получаем выбранный файл
            string filename = openFile.FileName;
            // читаем файл в строку
            string[] fileText = System.IO.File.ReadAllLines(filename);
            try
            {
                if (fileText.Length > 8) { double bonk = Convert.ToDouble("Bonk!"); }
                for (int i = 0; i < fileText.Length; i++)
                {
                    filedata = Convert.ToDouble(fileText[i]);
                }
                Dot.dotX = Convert.ToDouble(fileText[0]);
                Dot.dotY = Convert.ToDouble(fileText[1]);
                Triangle.firstX = Convert.ToDouble(fileText[2]);
                Triangle.firstY = Convert.ToDouble(fileText[3]);
                Triangle.secondX = Convert.ToDouble(fileText[4]);
                Triangle.secondY = Convert.ToDouble(fileText[5]);
                Triangle.thirdX = Convert.ToDouble(fileText[6]);
                Triangle.thirdY = Convert.ToDouble(fileText[7]);
                FileForm.ActiveForm.Hide();
                StartForm MyForm2 = new StartForm();
                MyForm2.ShowDialog();
                Close();

                MessageBox.Show("Файл открыт");
            }
            catch
            {
                MessageBox.Show("Пожалуйста, введите верные данные", "Ахтунг!Ошибка", MessageBoxButtons.OK);
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            string[] filedata = new string[8];
            filedata[0] = Convert.ToString(Dot.dotX);
            filedata[1] = Convert.ToString(Dot.dotY);
            filedata[2] = Convert.ToString(Triangle.firstX);
            filedata[3] = Convert.ToString(Triangle.firstY);
            filedata[4] = Convert.ToString(Triangle.secondX);
            filedata[5] = Convert.ToString(Triangle.secondY);
            filedata[6] = Convert.ToString(Triangle.thirdX);
            filedata[7] = Convert.ToString(Triangle.thirdY);
            // получаем выбранный файл
            string filename = saveFile.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllLines(filename, filedata);
            MessageBox.Show("Файл сохранен");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FileForm.ActiveForm.Hide();
            StartForm MyForm2 = new StartForm();
            MyForm2.ShowDialog();
            Close();

        }

        private void bt_result_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            string[] filedata = new string[9];
            filedata[0] = "Кордината X точки:" + Convert.ToString(Dot.dotX);
            filedata[1] = "Кордината Y точки:" + Convert.ToString(Dot.dotY);
            filedata[2] = "Кордината X первой точки треугольника:" + Convert.ToString(Triangle.firstX);
            filedata[3] = "Кордината Y первой точки треугольника:" + Convert.ToString(Triangle.firstY);
            filedata[4] = "Кордината X второй точки треугольнка:" + Convert.ToString(Triangle.secondX);
            filedata[5] = "Кордината Y второй точки треугольника:" + Convert.ToString(Triangle.secondY);
            filedata[6] = "Кордината X третьей точки треугольника:" + Convert.ToString(Triangle.thirdX);
            filedata[7] = "Кордината Y третьей точки треугольника:" + Convert.ToString(Triangle.thirdY);
            filedata[7] = "Результат"+Triangle.answerState;
            // получаем выбранный файл
            string filename = saveFile.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllLines(filename, filedata);
            MessageBox.Show("Файл сохранен");
        }
    }
}

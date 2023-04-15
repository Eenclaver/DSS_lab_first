using firstLab.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace firstLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Shown(Object sender, EventArgs e)
        {
            MessageBox.Show("Для заданной точки и треугольника на плоскости определить, принадлежит ли точка треугольнику.", "Сошнев Андрей 415а, работа номер 1, вариант 6", MessageBoxButtons.OK);
        }

        private void inputMask(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 43 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            if (e.KeyChar == 47) e.Handled = true;
            if (e.KeyChar == 46) e.Handled = true;
        }


        private void bt_answer_Click(object sender, EventArgs e)
        {
            double a = (Convert.ToDouble(tb_firstTriangleX.Text) - Convert.ToDouble(tb_dotX.Text)) * (Convert.ToDouble(tb_secondTriangleY.Text) - Convert.ToDouble(tb_firstTriangleY.Text)) - (Convert.ToDouble(tb_secondTriangleX.Text) - Convert.ToDouble(tb_firstTriangleX.Text)) * (Convert.ToDouble(tb_firstTriangleY.Text) - Convert.ToDouble(tb_dotY.Text));
            double b = (Convert.ToDouble(tb_secondTriangleX.Text) - Convert.ToDouble(tb_dotX.Text)) * (Convert.ToDouble(tb_thirdTriangleY.Text) - Convert.ToDouble(tb_secondTriangleY.Text)) - (Convert.ToDouble(tb_thirdTriangleX.Text) - Convert.ToDouble(tb_secondTriangleX.Text)) * (Convert.ToDouble(tb_secondTriangleY.Text) - Convert.ToDouble(tb_dotX.Text));
            double c = (Convert.ToDouble(tb_thirdTriangleX.Text) - Convert.ToDouble(tb_dotX.Text)) * (Convert.ToDouble(tb_firstTriangleY.Text) - Convert.ToDouble(tb_thirdTriangleY.Text)) - (Convert.ToDouble(tb_firstTriangleX.Text) - Convert.ToDouble(tb_thirdTriangleX.Text)) * (Convert.ToDouble(tb_thirdTriangleY.Text) - Convert.ToDouble(tb_dotY.Text));

            lb_answer.Visible = true;

            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
          
                lb_answer.Text="Принадлежит треугольнику";
            }
            else
            {
                lb_answer.Text = "Не принадлежит треугольнику";
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                double num = Convert.ToDouble(tb.Text);
            }
            catch
            {
                MessageBox.Show("Пожалуйста, введите верные данные", "Ахтунг!Ошибка", MessageBoxButtons.OK);
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                tb.Clear();
            }
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
                for (int i = 0;i < fileText.Length; i++){
                    filedata = Convert.ToDouble(fileText[i]);
                }
                tb_dotX.Text = fileText[0];
                tb_dotY.Text = fileText[1];
                tb_firstTriangleX.Text = fileText[2];
                tb_firstTriangleY.Text = fileText[3];
                tb_secondTriangleX.Text = fileText[4];
                tb_secondTriangleY.Text = fileText[5];
                tb_thirdTriangleX.Text = fileText[6];
                tb_thirdTriangleY.Text = fileText[7];
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
            string[] filedata=new string[8];
            filedata[0]= tb_dotX.Text;
            filedata[1]= tb_dotY.Text;
            filedata[2]= tb_firstTriangleX.Text;
            filedata[3]= tb_firstTriangleY.Text;
            filedata[4]= tb_secondTriangleX.Text;
            filedata[5]= tb_secondTriangleY.Text;
            filedata[6]= tb_thirdTriangleX.Text;
            filedata[7]= tb_thirdTriangleY.Text;
            // получаем выбранный файл
            string filename = saveFile.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllLines(filename, filedata);
            MessageBox.Show("Файл сохранен");
        }
    }
}

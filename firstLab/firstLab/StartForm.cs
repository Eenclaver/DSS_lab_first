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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            tb_firstTriangleX.Text = Triangle.firstX.ToString();
            tb_secondTriangleX.Text = Triangle.secondX.ToString();
            tb_thirdTriangleX.Text = Triangle.thirdX.ToString();
            tb_firstTriangleY.Text = Triangle.firstY.ToString();
            tb_secondTriangleY.Text= Triangle.secondY.ToString();
            tb_thirdTriangleY.Text= Triangle.thirdY.ToString();
            tb_dotX.Text= Dot.dotX.ToString();
            tb_dotY.Text= Dot.dotY.ToString();
            string welcomeState= System.IO.File.ReadAllText("Cache");
            if (welcomeState == "Welcome")
            {
                MessageBox.Show("Для заданной точки и треугольника на плоскости определить, принадлежит ли точка треугольнику.", "Сошнев Андрей 415а, работа номер 1, вариант 6", MessageBoxButtons.OK);
            }
            else
            {
                cb_welcome.Checked = true;
            }
        }
        private void Form1_Shown(Object sender, EventArgs e)
        {
            
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

        private void returnButton_Click(object sender, EventArgs e)
        {
            StartForm.ActiveForm.Hide();
            FileForm MyForm2 = new FileForm();
            MyForm2.ShowDialog();
            Close();
        }

        private void cb_Welcome_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_welcome.Checked == true)
            {
                System.IO.File.WriteAllText("Cache", "noWelcome");
            }
            else
            {
                System.IO.File.WriteAllText("Cache", "Welcome");
            }
        }
    }
}

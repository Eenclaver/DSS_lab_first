namespace firstLab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_answer = new System.Windows.Forms.Button();
            this.lb_triangle = new System.Windows.Forms.Label();
            this.tb_firstTriangleX = new System.Windows.Forms.TextBox();
            this.tb_secondTriangleX = new System.Windows.Forms.TextBox();
            this.tb_thirdTriangleX = new System.Windows.Forms.TextBox();
            this.lb_firstTriangle = new System.Windows.Forms.Label();
            this.lb_secondTriangle = new System.Windows.Forms.Label();
            this.lb_thirdTriangle = new System.Windows.Forms.Label();
            this.lb_dot = new System.Windows.Forms.Label();
            this.lb_xTriangle = new System.Windows.Forms.Label();
            this.lb_yTriangle = new System.Windows.Forms.Label();
            this.tb_thirdTriangleY = new System.Windows.Forms.TextBox();
            this.tb_secondTriangleY = new System.Windows.Forms.TextBox();
            this.tb_firstTriangleY = new System.Windows.Forms.TextBox();
            this.tb_dotY = new System.Windows.Forms.TextBox();
            this.lb_yDot = new System.Windows.Forms.Label();
            this.lb_xDot = new System.Windows.Forms.Label();
            this.tb_dotX = new System.Windows.Forms.TextBox();
            this.lb_answer = new System.Windows.Forms.Label();
            this.bt_upload = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bt_answer
            // 
            this.bt_answer.Location = new System.Drawing.Point(651, 182);
            this.bt_answer.Name = "bt_answer";
            this.bt_answer.Size = new System.Drawing.Size(108, 43);
            this.bt_answer.TabIndex = 0;
            this.bt_answer.Text = "Рассчитать";
            this.bt_answer.UseVisualStyleBackColor = true;
            this.bt_answer.Click += new System.EventHandler(this.bt_answer_Click);
            // 
            // lb_triangle
            // 
            this.lb_triangle.AutoSize = true;
            this.lb_triangle.Font = new System.Drawing.Font("Harlow Solid Italic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_triangle.Location = new System.Drawing.Point(12, 20);
            this.lb_triangle.Name = "lb_triangle";
            this.lb_triangle.Size = new System.Drawing.Size(115, 22);
            this.lb_triangle.TabIndex = 3;
            this.lb_triangle.Text = "Треугольник";
            // 
            // tb_firstTriangleX
            // 
            this.tb_firstTriangleX.Location = new System.Drawing.Point(116, 77);
            this.tb_firstTriangleX.Name = "tb_firstTriangleX";
            this.tb_firstTriangleX.Size = new System.Drawing.Size(100, 22);
            this.tb_firstTriangleX.TabIndex = 4;
            this.tb_firstTriangleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            this.tb_firstTriangleX.Leave += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_secondTriangleX
            // 
            this.tb_secondTriangleX.Location = new System.Drawing.Point(116, 105);
            this.tb_secondTriangleX.Name = "tb_secondTriangleX";
            this.tb_secondTriangleX.Size = new System.Drawing.Size(100, 22);
            this.tb_secondTriangleX.TabIndex = 5;
            this.tb_secondTriangleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            this.tb_secondTriangleX.Leave += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_thirdTriangleX
            // 
            this.tb_thirdTriangleX.Location = new System.Drawing.Point(116, 133);
            this.tb_thirdTriangleX.Name = "tb_thirdTriangleX";
            this.tb_thirdTriangleX.Size = new System.Drawing.Size(100, 22);
            this.tb_thirdTriangleX.TabIndex = 6;
            this.tb_thirdTriangleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            this.tb_thirdTriangleX.Leave += new System.EventHandler(this.tb_TextChanged);
            // 
            // lb_firstTriangle
            // 
            this.lb_firstTriangle.AutoSize = true;
            this.lb_firstTriangle.Location = new System.Drawing.Point(13, 77);
            this.lb_firstTriangle.Name = "lb_firstTriangle";
            this.lb_firstTriangle.Size = new System.Drawing.Size(97, 16);
            this.lb_firstTriangle.TabIndex = 7;
            this.lb_firstTriangle.Text = "Первая точка";
            // 
            // lb_secondTriangle
            // 
            this.lb_secondTriangle.AutoSize = true;
            this.lb_secondTriangle.Location = new System.Drawing.Point(13, 105);
            this.lb_secondTriangle.Name = "lb_secondTriangle";
            this.lb_secondTriangle.Size = new System.Drawing.Size(95, 16);
            this.lb_secondTriangle.TabIndex = 8;
            this.lb_secondTriangle.Text = "Вторая точка";
            // 
            // lb_thirdTriangle
            // 
            this.lb_thirdTriangle.AutoSize = true;
            this.lb_thirdTriangle.Location = new System.Drawing.Point(13, 133);
            this.lb_thirdTriangle.Name = "lb_thirdTriangle";
            this.lb_thirdTriangle.Size = new System.Drawing.Size(94, 16);
            this.lb_thirdTriangle.TabIndex = 9;
            this.lb_thirdTriangle.Text = "Третья точка";
            // 
            // lb_dot
            // 
            this.lb_dot.AutoSize = true;
            this.lb_dot.Font = new System.Drawing.Font("Harlow Solid Italic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dot.Location = new System.Drawing.Point(416, 20);
            this.lb_dot.Name = "lb_dot";
            this.lb_dot.Size = new System.Drawing.Size(59, 22);
            this.lb_dot.TabIndex = 10;
            this.lb_dot.Text = "Точка";
            // 
            // lb_xTriangle
            // 
            this.lb_xTriangle.AutoSize = true;
            this.lb_xTriangle.Font = new System.Drawing.Font("Agency FB", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xTriangle.Location = new System.Drawing.Point(158, 43);
            this.lb_xTriangle.Name = "lb_xTriangle";
            this.lb_xTriangle.Size = new System.Drawing.Size(18, 21);
            this.lb_xTriangle.TabIndex = 11;
            this.lb_xTriangle.Text = "X";
            // 
            // lb_yTriangle
            // 
            this.lb_yTriangle.AutoSize = true;
            this.lb_yTriangle.Font = new System.Drawing.Font("Agency FB", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_yTriangle.Location = new System.Drawing.Point(294, 43);
            this.lb_yTriangle.Name = "lb_yTriangle";
            this.lb_yTriangle.Size = new System.Drawing.Size(19, 21);
            this.lb_yTriangle.TabIndex = 12;
            this.lb_yTriangle.Text = "Y";
            // 
            // tb_thirdTriangleY
            // 
            this.tb_thirdTriangleY.Location = new System.Drawing.Point(252, 133);
            this.tb_thirdTriangleY.Name = "tb_thirdTriangleY";
            this.tb_thirdTriangleY.Size = new System.Drawing.Size(100, 22);
            this.tb_thirdTriangleY.TabIndex = 15;
            this.tb_thirdTriangleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            this.tb_thirdTriangleY.Leave += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_secondTriangleY
            // 
            this.tb_secondTriangleY.Location = new System.Drawing.Point(252, 105);
            this.tb_secondTriangleY.Name = "tb_secondTriangleY";
            this.tb_secondTriangleY.Size = new System.Drawing.Size(100, 22);
            this.tb_secondTriangleY.TabIndex = 14;
            this.tb_secondTriangleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            this.tb_secondTriangleY.Leave += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_firstTriangleY
            // 
            this.tb_firstTriangleY.Location = new System.Drawing.Point(252, 77);
            this.tb_firstTriangleY.Name = "tb_firstTriangleY";
            this.tb_firstTriangleY.Size = new System.Drawing.Size(100, 22);
            this.tb_firstTriangleY.TabIndex = 13;
            this.tb_firstTriangleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            this.tb_firstTriangleY.Leave += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_dotY
            // 
            this.tb_dotY.Location = new System.Drawing.Point(605, 77);
            this.tb_dotY.Name = "tb_dotY";
            this.tb_dotY.Size = new System.Drawing.Size(100, 22);
            this.tb_dotY.TabIndex = 19;
            this.tb_dotY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            this.tb_dotY.Leave += new System.EventHandler(this.tb_TextChanged);
            // 
            // lb_yDot
            // 
            this.lb_yDot.AutoSize = true;
            this.lb_yDot.Font = new System.Drawing.Font("Agency FB", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_yDot.Location = new System.Drawing.Point(647, 43);
            this.lb_yDot.Name = "lb_yDot";
            this.lb_yDot.Size = new System.Drawing.Size(19, 21);
            this.lb_yDot.TabIndex = 18;
            this.lb_yDot.Text = "Y";
            // 
            // lb_xDot
            // 
            this.lb_xDot.AutoSize = true;
            this.lb_xDot.Font = new System.Drawing.Font("Agency FB", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xDot.Location = new System.Drawing.Point(511, 43);
            this.lb_xDot.Name = "lb_xDot";
            this.lb_xDot.Size = new System.Drawing.Size(18, 21);
            this.lb_xDot.TabIndex = 17;
            this.lb_xDot.Text = "X";
            // 
            // tb_dotX
            // 
            this.tb_dotX.Location = new System.Drawing.Point(469, 77);
            this.tb_dotX.Name = "tb_dotX";
            this.tb_dotX.Size = new System.Drawing.Size(100, 22);
            this.tb_dotX.TabIndex = 16;
            this.tb_dotX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            this.tb_dotX.Leave += new System.EventHandler(this.tb_TextChanged);
            // 
            // lb_answer
            // 
            this.lb_answer.AutoSize = true;
            this.lb_answer.Location = new System.Drawing.Point(420, 110);
            this.lb_answer.Name = "lb_answer";
            this.lb_answer.Size = new System.Drawing.Size(0, 16);
            this.lb_answer.TabIndex = 20;
            this.lb_answer.Visible = false;
            // 
            // bt_upload
            // 
            this.bt_upload.Location = new System.Drawing.Point(12, 172);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(108, 53);
            this.bt_upload.TabIndex = 21;
            this.bt_upload.Text = "Загрузить данные";
            this.bt_upload.UseVisualStyleBackColor = true;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(126, 172);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(108, 53);
            this.bt_save.TabIndex = 22;
            this.bt_save.Text = "Сохранить данные";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "txt";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 237);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_upload);
            this.Controls.Add(this.lb_answer);
            this.Controls.Add(this.tb_dotY);
            this.Controls.Add(this.lb_yDot);
            this.Controls.Add(this.lb_xDot);
            this.Controls.Add(this.tb_dotX);
            this.Controls.Add(this.tb_thirdTriangleY);
            this.Controls.Add(this.tb_secondTriangleY);
            this.Controls.Add(this.tb_firstTriangleY);
            this.Controls.Add(this.lb_yTriangle);
            this.Controls.Add(this.lb_xTriangle);
            this.Controls.Add(this.lb_dot);
            this.Controls.Add(this.lb_thirdTriangle);
            this.Controls.Add(this.lb_secondTriangle);
            this.Controls.Add(this.lb_firstTriangle);
            this.Controls.Add(this.tb_thirdTriangleX);
            this.Controls.Add(this.tb_secondTriangleX);
            this.Controls.Add(this.tb_firstTriangleX);
            this.Controls.Add(this.lb_triangle);
            this.Controls.Add(this.bt_answer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_answer;
        private System.Windows.Forms.Label lb_triangle;
        private System.Windows.Forms.TextBox tb_firstTriangleX;
        private System.Windows.Forms.TextBox tb_secondTriangleX;
        private System.Windows.Forms.TextBox tb_thirdTriangleX;
        private System.Windows.Forms.Label lb_firstTriangle;
        private System.Windows.Forms.Label lb_secondTriangle;
        private System.Windows.Forms.Label lb_thirdTriangle;
        private System.Windows.Forms.Label lb_dot;
        private System.Windows.Forms.Label lb_xTriangle;
        private System.Windows.Forms.Label lb_yTriangle;
        private System.Windows.Forms.TextBox tb_thirdTriangleY;
        private System.Windows.Forms.TextBox tb_secondTriangleY;
        private System.Windows.Forms.TextBox tb_firstTriangleY;
        private System.Windows.Forms.TextBox tb_dotY;
        private System.Windows.Forms.Label lb_yDot;
        private System.Windows.Forms.Label lb_xDot;
        private System.Windows.Forms.TextBox tb_dotX;
        private System.Windows.Forms.Label lb_answer;
        private System.Windows.Forms.Button bt_upload;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}


namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sheet = new System.Windows.Forms.PictureBox();
            this.VertexB = new System.Windows.Forms.Button();
            this.SelectB = new System.Windows.Forms.Button();
            this.EdgeB = new System.Windows.Forms.Button();
            this.Shw = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.Control;
            this.sheet.Location = new System.Drawing.Point(274, 1);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(551, 596);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // VertexB
            // 
            this.VertexB.BackColor = System.Drawing.Color.SlateBlue;
            this.VertexB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.VertexB.Location = new System.Drawing.Point(12, 89);
            this.VertexB.Name = "VertexB";
            this.VertexB.Size = new System.Drawing.Size(213, 35);
            this.VertexB.TabIndex = 1;
            this.VertexB.Text = "Добавить город (вершина)";
            this.VertexB.UseVisualStyleBackColor = false;
            this.VertexB.Click += new System.EventHandler(this.VertexB_Click);
            // 
            // SelectB
            // 
            this.SelectB.BackColor = System.Drawing.Color.SlateBlue;
            this.SelectB.FlatAppearance.BorderColor = System.Drawing.Color.Ivory;
            this.SelectB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SelectB.Location = new System.Drawing.Point(12, 39);
            this.SelectB.Name = "SelectB";
            this.SelectB.Size = new System.Drawing.Size(213, 34);
            this.SelectB.TabIndex = 2;
            this.SelectB.Text = "Сброс кнопок";
            this.SelectB.UseVisualStyleBackColor = false;
            this.SelectB.Click += new System.EventHandler(this.SelectB_Click);
            // 
            // EdgeB
            // 
            this.EdgeB.BackColor = System.Drawing.Color.SlateBlue;
            this.EdgeB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.EdgeB.Location = new System.Drawing.Point(12, 139);
            this.EdgeB.Name = "EdgeB";
            this.EdgeB.Size = new System.Drawing.Size(213, 35);
            this.EdgeB.TabIndex = 3;
            this.EdgeB.Text = "Добавить дорогу (ребро)";
            this.EdgeB.UseVisualStyleBackColor = false;
            this.EdgeB.Click += new System.EventHandler(this.EdgeB_Click);
            // 
            // Shw
            // 
            this.Shw.BackColor = System.Drawing.Color.SlateBlue;
            this.Shw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Shw.Location = new System.Drawing.Point(12, 479);
            this.Shw.Name = "Shw";
            this.Shw.Size = new System.Drawing.Size(213, 74);
            this.Shw.TabIndex = 7;
            this.Shw.Text = "Найти путь";
            this.Shw.UseVisualStyleBackColor = false;
            this.Shw.Click += new System.EventHandler(this.Shw_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(881, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(878, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Исходная точка";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(878, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "О программе";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(878, 430);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(881, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(878, 362);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 22);
            this.textBox4.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(878, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Конечная точка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(875, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Длина пути";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(878, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Путь";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(878, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 42);
            this.button2.TabIndex = 18;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(879, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Промежуточная";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(878, 255);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 22);
            this.textBox5.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1022, 594);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Shw);
            this.Controls.Add(this.EdgeB);
            this.Controls.Add(this.SelectB);
            this.Controls.Add(this.VertexB);
            this.Controls.Add(this.sheet);
            this.Name = "Form1";
            this.Text = "Графы";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button VertexB;
        private System.Windows.Forms.Button SelectB;
        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button EdgeB;
        private System.Windows.Forms.Button Shw;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
    }
}


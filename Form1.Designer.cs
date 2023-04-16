namespace DataDZ
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
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_second_date = new System.Windows.Forms.Label();
            this.label_first_date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_vremya_sutok = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_vis_date2 = new System.Windows.Forms.Label();
            this.label_vis_date1 = new System.Windows.Forms.Label();
            this.label_raznitsa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_vremya = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar_EndDate = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar_StartDate = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Вторая дата:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Первая дата:";
            // 
            // label_second_date
            // 
            this.label_second_date.AutoSize = true;
            this.label_second_date.Location = new System.Drawing.Point(210, 200);
            this.label_second_date.Name = "label_second_date";
            this.label_second_date.Size = new System.Drawing.Size(69, 13);
            this.label_second_date.TabIndex = 42;
            this.label_second_date.Text = "Вторая дата";
            // 
            // label_first_date
            // 
            this.label_first_date.AutoSize = true;
            this.label_first_date.Location = new System.Drawing.Point(208, 175);
            this.label_first_date.Name = "label_first_date";
            this.label_first_date.Size = new System.Drawing.Size(71, 13);
            this.label_first_date.TabIndex = 41;
            this.label_first_date.Text = "Первая дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Формат дат:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Обычный",
            "День, месяц, год (цифрами)",
            "Дата и время",
            "День",
            "Месяц и год"});
            this.comboBox1.Location = new System.Drawing.Point(209, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // label_vremya_sutok
            // 
            this.label_vremya_sutok.AutoSize = true;
            this.label_vremya_sutok.Location = new System.Drawing.Point(651, 131);
            this.label_vremya_sutok.Name = "label_vremya_sutok";
            this.label_vremya_sutok.Size = new System.Drawing.Size(67, 13);
            this.label_vremya_sutok.TabIndex = 38;
            this.label_vremya_sutok.Text = "*Ожидание*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Время суток по указанному времени:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Введите время формата (00:00):";
            // 
            // label_vis_date2
            // 
            this.label_vis_date2.AutoSize = true;
            this.label_vis_date2.Location = new System.Drawing.Point(290, 103);
            this.label_vis_date2.Name = "label_vis_date2";
            this.label_vis_date2.Size = new System.Drawing.Size(67, 13);
            this.label_vis_date2.TabIndex = 35;
            this.label_vis_date2.Text = "*Ожидание*";
            // 
            // label_vis_date1
            // 
            this.label_vis_date1.AutoSize = true;
            this.label_vis_date1.Location = new System.Drawing.Point(290, 73);
            this.label_vis_date1.Name = "label_vis_date1";
            this.label_vis_date1.Size = new System.Drawing.Size(67, 13);
            this.label_vis_date1.TabIndex = 34;
            this.label_vis_date1.Text = "*Ожидание*";
            // 
            // label_raznitsa
            // 
            this.label_raznitsa.AutoSize = true;
            this.label_raznitsa.Location = new System.Drawing.Point(290, 44);
            this.label_raznitsa.Name = "label_raznitsa";
            this.label_raznitsa.Size = new System.Drawing.Size(67, 13);
            this.label_raznitsa.TabIndex = 33;
            this.label_raznitsa.Text = "*Ожидание*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Високосность второй даты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Високосность первой даты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(387, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Дата вторая:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(155, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Дата первая:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Разница между выбранными датами:";
            // 
            // textBox_vremya
            // 
            this.textBox_vremya.Location = new System.Drawing.Point(449, 96);
            this.textBox_vremya.Name = "textBox_vremya";
            this.textBox_vremya.Size = new System.Drawing.Size(138, 20);
            this.textBox_vremya.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Подсчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar_EndDate
            // 
            this.monthCalendar_EndDate.Location = new System.Drawing.Point(381, 245);
            this.monthCalendar_EndDate.MaxSelectionCount = 1;
            this.monthCalendar_EndDate.Name = "monthCalendar_EndDate";
            this.monthCalendar_EndDate.TabIndex = 25;
            // 
            // monthCalendar_StartDate
            // 
            this.monthCalendar_StartDate.Location = new System.Drawing.Point(158, 245);
            this.monthCalendar_StartDate.MaxSelectionCount = 1;
            this.monthCalendar_StartDate.Name = "monthCalendar_StartDate";
            this.monthCalendar_StartDate.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_second_date);
            this.Controls.Add(this.label_first_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_vremya_sutok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_vis_date2);
            this.Controls.Add(this.label_vis_date1);
            this.Controls.Add(this.label_raznitsa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_vremya);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar_EndDate);
            this.Controls.Add(this.monthCalendar_StartDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_second_date;
        private System.Windows.Forms.Label label_first_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_vremya_sutok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_vis_date2;
        private System.Windows.Forms.Label label_vis_date1;
        private System.Windows.Forms.Label label_raznitsa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_vremya;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar_EndDate;
        private System.Windows.Forms.MonthCalendar monthCalendar_StartDate;
    }
}


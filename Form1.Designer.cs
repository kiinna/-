namespace Калькулятор
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rost = new System.Windows.Forms.TextBox();
            this.ves = new System.Windows.Forms.TextBox();
            this.voz = new System.Windows.Forms.TextBox();
            this.zis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hel = new System.Windows.Forms.ComboBox();
            this.schet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mus = new System.Windows.Forms.CheckBox();
            this.zen = new System.Windows.Forms.CheckBox();
            this.lis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рост:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Возраст:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Оброз жизни:";
            // 
            // rost
            // 
            this.rost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rost.Location = new System.Drawing.Point(50, 12);
            this.rost.Margin = new System.Windows.Forms.Padding(2);
            this.rost.Name = "rost";
            this.rost.Size = new System.Drawing.Size(284, 25);
            this.rost.TabIndex = 4;
            this.rost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rost_KeyDown);
            // 
            // ves
            // 
            this.ves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ves.Location = new System.Drawing.Point(47, 40);
            this.ves.Margin = new System.Windows.Forms.Padding(2);
            this.ves.Name = "ves";
            this.ves.Size = new System.Drawing.Size(287, 25);
            this.ves.TabIndex = 5;
            this.ves.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ves_KeyDown);
            // 
            // voz
            // 
            this.voz.BackColor = System.Drawing.Color.Lime;
            this.voz.Location = new System.Drawing.Point(73, 67);
            this.voz.Margin = new System.Windows.Forms.Padding(2);
            this.voz.Name = "voz";
            this.voz.Size = new System.Drawing.Size(261, 25);
            this.voz.TabIndex = 6;
            this.voz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.voz_KeyDown);
            // 
            // zis
            // 
            this.zis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.zis.Font = new System.Drawing.Font("Book Antiqua", 9F);
            this.zis.FormattingEnabled = true;
            this.zis.Items.AddRange(new object[] {
            "Седячий, малоподвижный",
            "Легкая активность(упражнение  1-3 раза в неделю)",
            "Средняя активность(тренировка 3-5 раз в неделю)",
            "Высокая активность(высокие нагрузки каждый день)"});
            this.zis.Location = new System.Drawing.Point(95, 95);
            this.zis.Margin = new System.Windows.Forms.Padding(2);
            this.zis.Name = "zis";
            this.zis.Size = new System.Drawing.Size(239, 24);
            this.zis.TabIndex = 7;
            this.zis.SelectedIndexChanged += new System.EventHandler(this.zis_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цель:";
            // 
            // hel
            // 
            this.hel.AutoCompleteCustomSource.AddRange(new string[] {
            "Сбросить вес",
            "Набрать мышечную массу",
            "Поддержать вес "});
            this.hel.BackColor = System.Drawing.Color.Green;
            this.hel.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hel.FormattingEnabled = true;
            this.hel.Items.AddRange(new object[] {
            "Сбросить вес",
            "Набрать мышечную массу",
            "Поддержать вес"});
            this.hel.Location = new System.Drawing.Point(50, 125);
            this.hel.Margin = new System.Windows.Forms.Padding(2);
            this.hel.Name = "hel";
            this.hel.Size = new System.Drawing.Size(284, 24);
            this.hel.TabIndex = 9;
            this.hel.SelectedIndexChanged += new System.EventHandler(this.hel_SelectedIndexChanged);
            // 
            // schet
            // 
            this.schet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.schet.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schet.Location = new System.Drawing.Point(11, 182);
            this.schet.Margin = new System.Windows.Forms.Padding(2);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(323, 44);
            this.schet.TabIndex = 10;
            this.schet.Text = "Счет";
            this.schet.UseVisualStyleBackColor = false;
            this.schet.Click += new System.EventHandler(this.schet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Пол:";
            // 
            // mus
            // 
            this.mus.AutoSize = true;
            this.mus.ForeColor = System.Drawing.Color.SeaGreen;
            this.mus.Location = new System.Drawing.Point(50, 156);
            this.mus.Name = "mus";
            this.mus.Size = new System.Drawing.Size(77, 21);
            this.mus.TabIndex = 12;
            this.mus.Text = "Мужской";
            this.mus.UseVisualStyleBackColor = true;
            this.mus.CheckedChanged += new System.EventHandler(this.mus_CheckedChanged);
            // 
            // zen
            // 
            this.zen.AutoSize = true;
            this.zen.ForeColor = System.Drawing.Color.SeaGreen;
            this.zen.Location = new System.Drawing.Point(137, 156);
            this.zen.Name = "zen";
            this.zen.Size = new System.Drawing.Size(77, 21);
            this.zen.TabIndex = 13;
            this.zen.Text = "Женский";
            this.zen.UseVisualStyleBackColor = true;
            this.zen.CheckedChanged += new System.EventHandler(this.zen_CheckedChanged);
            // 
            // lis
            // 
            this.lis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lis.ForeColor = System.Drawing.Color.Green;
            this.lis.FormattingEnabled = true;
            this.lis.ItemHeight = 17;
            this.lis.Location = new System.Drawing.Point(349, 12);
            this.lis.Name = "lis";
            this.lis.Size = new System.Drawing.Size(318, 208);
            this.lis.TabIndex = 14;
            this.lis.SelectedIndexChanged += new System.EventHandler(this.lis_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(676, 237);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.lis);
            this.Controls.Add(this.zen);
            this.Controls.Add(this.mus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zis);
            this.Controls.Add(this.voz);
            this.Controls.Add(this.ves);
            this.Controls.Add(this.rost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Расчет суточной нормы калорий и БЖУ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rost;
        private System.Windows.Forms.TextBox ves;
        private System.Windows.Forms.TextBox voz;
        private System.Windows.Forms.ComboBox zis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox hel;
        private System.Windows.Forms.Button schet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox mus;
        private System.Windows.Forms.CheckBox zen;
        private System.Windows.Forms.ListBox lis;
    }
}


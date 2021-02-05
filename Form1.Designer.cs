namespace s4_oop_2
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
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.maskedTextBoxRoomAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelRoomAmount = new System.Windows.Forms.Label();
            this.checkBoxHasKitchen = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxHasBalcony = new System.Windows.Forms.CheckBox();
            this.checkBoxHasBasement = new System.Windows.Forms.CheckBox();
            this.checkBoxHasRestroom = new System.Windows.Forms.CheckBox();
            this.checkBoxHasBathroom = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonGoodsManual = new System.Windows.Forms.RadioButton();
            this.radioButtonGoodsDefault = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(174, 87);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(100, 22);
            this.textBoxOwner.TabIndex = 0;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(17, 87);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(73, 17);
            this.labelOwner.TabIndex = 1;
            this.labelOwner.Text = "Владелец";
            // 
            // maskedTextBoxRoomAmount
            // 
            this.maskedTextBoxRoomAmount.Location = new System.Drawing.Point(174, 116);
            this.maskedTextBoxRoomAmount.Mask = "0";
            this.maskedTextBoxRoomAmount.Name = "maskedTextBoxRoomAmount";
            this.maskedTextBoxRoomAmount.Size = new System.Drawing.Size(28, 22);
            this.maskedTextBoxRoomAmount.TabIndex = 0;
            this.maskedTextBoxRoomAmount.ValidatingType = typeof(int);
            // 
            // labelRoomAmount
            // 
            this.labelRoomAmount.AutoSize = true;
            this.labelRoomAmount.Location = new System.Drawing.Point(17, 119);
            this.labelRoomAmount.Name = "labelRoomAmount";
            this.labelRoomAmount.Size = new System.Drawing.Size(137, 17);
            this.labelRoomAmount.TabIndex = 2;
            this.labelRoomAmount.Text = "Количество комнат";
            // 
            // checkBoxHasKitchen
            // 
            this.checkBoxHasKitchen.AutoCheck = false;
            this.checkBoxHasKitchen.AutoSize = true;
            this.checkBoxHasKitchen.Checked = true;
            this.checkBoxHasKitchen.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxHasKitchen.Location = new System.Drawing.Point(20, 43);
            this.checkBoxHasKitchen.Name = "checkBoxHasKitchen";
            this.checkBoxHasKitchen.Size = new System.Drawing.Size(68, 21);
            this.checkBoxHasKitchen.TabIndex = 3;
            this.checkBoxHasKitchen.Text = "Кухня";
            this.checkBoxHasKitchen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBoxHasBalcony);
            this.panel2.Controls.Add(this.checkBoxHasBasement);
            this.panel2.Controls.Add(this.checkBoxHasRestroom);
            this.panel2.Controls.Add(this.checkBoxHasBathroom);
            this.panel2.Controls.Add(this.checkBoxHasKitchen);
            this.panel2.Controls.Add(this.radioButtonGoodsManual);
            this.panel2.Controls.Add(this.radioButtonGoodsDefault);
            this.panel2.Location = new System.Drawing.Point(20, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 137);
            this.panel2.TabIndex = 5;
            // 
            // checkBoxHasBalcony
            // 
            this.checkBoxHasBalcony.AutoCheck = false;
            this.checkBoxHasBalcony.AutoSize = true;
            this.checkBoxHasBalcony.Checked = true;
            this.checkBoxHasBalcony.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxHasBalcony.Location = new System.Drawing.Point(221, 70);
            this.checkBoxHasBalcony.Name = "checkBoxHasBalcony";
            this.checkBoxHasBalcony.Size = new System.Drawing.Size(78, 21);
            this.checkBoxHasBalcony.TabIndex = 10;
            this.checkBoxHasBalcony.Text = "Балкон";
            this.checkBoxHasBalcony.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasBasement
            // 
            this.checkBoxHasBasement.AutoCheck = false;
            this.checkBoxHasBasement.AutoSize = true;
            this.checkBoxHasBasement.Checked = true;
            this.checkBoxHasBasement.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxHasBasement.Location = new System.Drawing.Point(221, 43);
            this.checkBoxHasBasement.Name = "checkBoxHasBasement";
            this.checkBoxHasBasement.Size = new System.Drawing.Size(79, 21);
            this.checkBoxHasBasement.TabIndex = 9;
            this.checkBoxHasBasement.Text = "Подвал";
            this.checkBoxHasBasement.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasRestroom
            // 
            this.checkBoxHasRestroom.AutoCheck = false;
            this.checkBoxHasRestroom.AutoSize = true;
            this.checkBoxHasRestroom.Checked = true;
            this.checkBoxHasRestroom.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxHasRestroom.Location = new System.Drawing.Point(20, 97);
            this.checkBoxHasRestroom.Name = "checkBoxHasRestroom";
            this.checkBoxHasRestroom.Size = new System.Drawing.Size(77, 21);
            this.checkBoxHasRestroom.TabIndex = 8;
            this.checkBoxHasRestroom.Text = "Туалет";
            this.checkBoxHasRestroom.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasBathroom
            // 
            this.checkBoxHasBathroom.AutoCheck = false;
            this.checkBoxHasBathroom.AutoSize = true;
            this.checkBoxHasBathroom.Checked = true;
            this.checkBoxHasBathroom.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxHasBathroom.Location = new System.Drawing.Point(20, 70);
            this.checkBoxHasBathroom.Name = "checkBoxHasBathroom";
            this.checkBoxHasBathroom.Size = new System.Drawing.Size(79, 21);
            this.checkBoxHasBathroom.TabIndex = 7;
            this.checkBoxHasBathroom.Text = "Ванная";
            this.checkBoxHasBathroom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Удобства";
            // 
            // radioButtonGoodsManual
            // 
            this.radioButtonGoodsManual.AutoSize = true;
            this.radioButtonGoodsManual.Location = new System.Drawing.Point(221, 4);
            this.radioButtonGoodsManual.Name = "radioButtonGoodsManual";
            this.radioButtonGoodsManual.Size = new System.Drawing.Size(152, 21);
            this.radioButtonGoodsManual.TabIndex = 1;
            this.radioButtonGoodsManual.Text = "Отметить вручную";
            this.radioButtonGoodsManual.UseVisualStyleBackColor = true;
            // 
            // radioButtonGoodsDefault
            // 
            this.radioButtonGoodsDefault.AutoSize = true;
            this.radioButtonGoodsDefault.Checked = true;
            this.radioButtonGoodsDefault.Location = new System.Drawing.Point(20, 3);
            this.radioButtonGoodsDefault.Name = "radioButtonGoodsDefault";
            this.radioButtonGoodsDefault.Size = new System.Drawing.Size(170, 21);
            this.radioButtonGoodsDefault.TabIndex = 0;
            this.radioButtonGoodsDefault.TabStop = true;
            this.radioButtonGoodsDefault.Text = "Опции по умолчанию";
            this.radioButtonGoodsDefault.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(163, 148);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Загрузить данные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество жильцов";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Адрес";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата добавления";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(266, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Дополнить список";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 550);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 574);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelRoomAmount);
            this.Controls.Add(this.maskedTextBoxRoomAmount);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.textBoxOwner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRoomAmount;
        private System.Windows.Forms.Label labelRoomAmount;
        private System.Windows.Forms.CheckBox checkBoxHasKitchen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonGoodsManual;
        private System.Windows.Forms.RadioButton radioButtonGoodsDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxHasBasement;
        private System.Windows.Forms.CheckBox checkBoxHasRestroom;
        private System.Windows.Forms.CheckBox checkBoxHasBathroom;
        private System.Windows.Forms.CheckBox checkBoxHasBalcony;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


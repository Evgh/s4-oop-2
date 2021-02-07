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
            this.labelOwner = new System.Windows.Forms.Label();
            this.maskedTextBoxArea = new System.Windows.Forms.MaskedTextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.checkBoxHasKitchen = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxHasBalcony = new System.Windows.Forms.CheckBox();
            this.checkBoxHasBasement = new System.Windows.Forms.CheckBox();
            this.checkBoxHasRestroom = new System.Windows.Forms.CheckBox();
            this.checkBoxHasBathroom = new System.Windows.Forms.CheckBox();
            this.radioButtonGoodsManual = new System.Windows.Forms.RadioButton();
            this.radioButtonGoodsDefault = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarResidentAmount = new System.Windows.Forms.TrackBar();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDay = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAdressesMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxAdress = new System.Windows.Forms.ListBox();
            this.maskedTextBoxOwner = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarResidentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(15, 30);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(73, 17);
            this.labelOwner.TabIndex = 1;
            this.labelOwner.Text = "Владелец";
            // 
            // maskedTextBoxArea
            // 
            this.maskedTextBoxArea.BackColor = System.Drawing.SystemColors.Window;
            this.maskedTextBoxArea.BeepOnError = true;
            this.maskedTextBoxArea.Location = new System.Drawing.Point(172, 59);
            this.maskedTextBoxArea.Mask = "000";
            this.maskedTextBoxArea.Name = "maskedTextBoxArea";
            this.maskedTextBoxArea.Size = new System.Drawing.Size(28, 22);
            this.maskedTextBoxArea.TabIndex = 0;
            this.maskedTextBoxArea.ValidatingType = typeof(int);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(15, 62);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(68, 17);
            this.labelArea.TabIndex = 2;
            this.labelArea.Text = "Площадь";
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
            this.panel2.Location = new System.Drawing.Point(421, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 132);
            this.panel2.TabIndex = 5;
            // 
            // checkBoxHasBalcony
            // 
            this.checkBoxHasBalcony.AutoCheck = false;
            this.checkBoxHasBalcony.AutoSize = true;
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
            // radioButtonGoodsManual
            // 
            this.radioButtonGoodsManual.AutoSize = true;
            this.radioButtonGoodsManual.Location = new System.Drawing.Point(221, 4);
            this.radioButtonGoodsManual.Name = "radioButtonGoodsManual";
            this.radioButtonGoodsManual.Size = new System.Drawing.Size(152, 21);
            this.radioButtonGoodsManual.TabIndex = 1;
            this.radioButtonGoodsManual.Text = "Отметить вручную";
            this.radioButtonGoodsManual.UseVisualStyleBackColor = true;
            this.radioButtonGoodsManual.CheckedChanged += new System.EventHandler(this.radioButtonGoodsManual_CheckedChanged);
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
            this.radioButtonGoodsDefault.CheckedChanged += new System.EventHandler(this.radioButtonGoodsDefault_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Удобства";
            // 
            // trackBarResidentAmount
            // 
            this.trackBarResidentAmount.Location = new System.Drawing.Point(161, 91);
            this.trackBarResidentAmount.Name = "trackBarResidentAmount";
            this.trackBarResidentAmount.Size = new System.Drawing.Size(104, 56);
            this.trackBarResidentAmount.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1135, 240);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 12);
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
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество жильцов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Адрес";
            // 
            // dateTimePickerDay
            // 
            this.dateTimePickerDay.Location = new System.Drawing.Point(172, 140);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDay.TabIndex = 13;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(15, 140);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(116, 17);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "Дата заселения";
            // 
            // buttonAdressesMenu
            // 
            this.buttonAdressesMenu.Location = new System.Drawing.Point(852, 139);
            this.buttonAdressesMenu.Name = "buttonAdressesMenu";
            this.buttonAdressesMenu.Size = new System.Drawing.Size(151, 23);
            this.buttonAdressesMenu.TabIndex = 15;
            this.buttonAdressesMenu.Text = "Изменить адреса";
            this.buttonAdressesMenu.UseVisualStyleBackColor = true;
            this.buttonAdressesMenu.Click += new System.EventHandler(this.buttonAdressesMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 260);
            this.dataGridView1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listBoxAdress);
            this.panel1.Controls.Add(this.maskedTextBoxOwner);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelOwner);
            this.panel1.Controls.Add(this.buttonAdressesMenu);
            this.panel1.Controls.Add(this.maskedTextBoxArea);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelArea);
            this.panel1.Controls.Add(this.dateTimePickerDay);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.trackBarResidentAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 185);
            this.panel1.TabIndex = 17;
            // 
            // listBoxAdress
            // 
            this.listBoxAdress.FormattingEnabled = true;
            this.listBoxAdress.ItemHeight = 16;
            this.listBoxAdress.Items.AddRange(new object[] {
            ""});
            this.listBoxAdress.Location = new System.Drawing.Point(852, 30);
            this.listBoxAdress.Name = "listBoxAdress";
            this.listBoxAdress.Size = new System.Drawing.Size(397, 100);
            this.listBoxAdress.TabIndex = 18;
            // 
            // maskedTextBoxOwner
            // 
            this.maskedTextBoxOwner.Location = new System.Drawing.Point(172, 27);
            this.maskedTextBoxOwner.Mask = "L.L.LLL??????????????????????????????????";
            this.maskedTextBoxOwner.Name = "maskedTextBoxOwner";
            this.maskedTextBoxOwner.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBoxOwner.TabIndex = 17;
            this.maskedTextBoxOwner.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "м^2";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1125, 269);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(142, 23);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Очистить таблицу";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 570);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarResidentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxArea;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.CheckBox checkBoxHasKitchen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonGoodsManual;
        private System.Windows.Forms.RadioButton radioButtonGoodsDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxHasBasement;
        private System.Windows.Forms.CheckBox checkBoxHasRestroom;
        private System.Windows.Forms.CheckBox checkBoxHasBathroom;
        private System.Windows.Forms.CheckBox checkBoxHasBalcony;
        private System.Windows.Forms.TrackBar trackBarResidentAmount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAdressesMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOwner;
        private System.Windows.Forms.ListBox listBoxAdress;
    }
}


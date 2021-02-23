namespace s4_oop_2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonEditRow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьСтоимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пункут1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.площадиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествуКомнатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пункт1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типколичествоКомнатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годЗаселенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.районToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.городToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьНесколькоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.площадьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоКомнатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.xMLToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.xMLToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditObject = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEditRooms = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarResidentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripEditObject.SuspendLayout();
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
            this.trackBarResidentAmount.Size = new System.Drawing.Size(223, 56);
            this.trackBarResidentAmount.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1055, 139);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 38);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.dateTimePickerDay.MaxDate = new System.DateTime(2021, 2, 20, 12, 9, 34, 0);
            this.dateTimePickerDay.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDay.TabIndex = 13;
            this.dateTimePickerDay.Value = new System.DateTime(2021, 2, 20, 0, 0, 0, 0);
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
            this.buttonAdressesMenu.Size = new System.Drawing.Size(142, 23);
            this.buttonAdressesMenu.TabIndex = 15;
            this.buttonAdressesMenu.Text = "Изменить адреса";
            this.buttonAdressesMenu.UseVisualStyleBackColor = true;
            this.buttonAdressesMenu.Click += new System.EventHandler(this.buttonAdressesMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(19, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 273);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listBoxAdress);
            this.panel1.Controls.Add(this.maskedTextBoxOwner);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelOwner);
            this.panel1.Controls.Add(this.buttonAdressesMenu);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.maskedTextBoxArea);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelArea);
            this.panel1.Controls.Add(this.dateTimePickerDay);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.trackBarResidentAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 65);
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
            this.listBoxAdress.Size = new System.Drawing.Size(405, 100);
            this.listBoxAdress.TabIndex = 18;
            // 
            // maskedTextBoxOwner
            // 
            this.maskedTextBoxOwner.Location = new System.Drawing.Point(172, 27);
            this.maskedTextBoxOwner.Mask = "L.L.LLL???????????????????????";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonEditRow
            // 
            this.buttonEditRow.Location = new System.Drawing.Point(16, 259);
            this.buttonEditRow.Name = "buttonEditRow";
            this.buttonEditRow.Size = new System.Drawing.Size(167, 23);
            this.buttonEditRow.TabIndex = 19;
            this.buttonEditRow.Text = "Свойства";
            this.buttonEditRow.UseVisualStyleBackColor = true;
            this.buttonEditRow.Click += new System.EventHandler(this.buttonEditRow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.пункут1ToolStripMenuItem,
            this.пункт1ToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1295, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.рассчитатьСтоимостьToolStripMenuItem,
            this.очиститьТаблицуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.saveJSONToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.jSONToolStripMenuItem1});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.deserializeXMLToolStripMenuItem1_Click);
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem1.Text = "JSON";
            this.jSONToolStripMenuItem1.Click += new System.EventHandler(this.deserializejSONToolStripMenuItem1_Click);
            // 
            // рассчитатьСтоимостьToolStripMenuItem
            // 
            this.рассчитатьСтоимостьToolStripMenuItem.Name = "рассчитатьСтоимостьToolStripMenuItem";
            this.рассчитатьСтоимостьToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.рассчитатьСтоимостьToolStripMenuItem.Text = "Рассчитать стоимость";
            this.рассчитатьСтоимостьToolStripMenuItem.Click += new System.EventHandler(this.GetPriceToolStripMenuItem_Click);
            // 
            // очиститьТаблицуToolStripMenuItem
            // 
            this.очиститьТаблицуToolStripMenuItem.Name = "очиститьТаблицуToolStripMenuItem";
            this.очиститьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.очиститьТаблицуToolStripMenuItem.Text = "Очистить таблицу";
            this.очиститьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItem_Click);
            // 
            // пункут1ToolStripMenuItem
            // 
            this.пункут1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.площадиToolStripMenuItem,
            this.количествуКомнатToolStripMenuItem,
            this.ценеToolStripMenuItem});
            this.пункут1ToolStripMenuItem.Name = "пункут1ToolStripMenuItem";
            this.пункут1ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.пункут1ToolStripMenuItem.Text = "Сортировка";
            // 
            // площадиToolStripMenuItem
            // 
            this.площадиToolStripMenuItem.Name = "площадиToolStripMenuItem";
            this.площадиToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.площадиToolStripMenuItem.Text = "Площадь";
            this.площадиToolStripMenuItem.Click += new System.EventHandler(this.sortAreaToolStripMenuItem_Click);
            // 
            // количествуКомнатToolStripMenuItem
            // 
            this.количествуКомнатToolStripMenuItem.Name = "количествуКомнатToolStripMenuItem";
            this.количествуКомнатToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.количествуКомнатToolStripMenuItem.Text = "Количество комнат";
            this.количествуКомнатToolStripMenuItem.Click += new System.EventHandler(this.sortRoomAmountToolStripMenuItem_Click);
            // 
            // ценеToolStripMenuItem
            // 
            this.ценеToolStripMenuItem.Name = "ценеToolStripMenuItem";
            this.ценеToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ценеToolStripMenuItem.Text = "Цена";
            this.ценеToolStripMenuItem.Click += new System.EventHandler(this.sortPriceToolStripMenuItem_Click);
            // 
            // пункт1ToolStripMenuItem
            // 
            this.пункт1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типколичествоКомнатToolStripMenuItem,
            this.годЗаселенияToolStripMenuItem,
            this.районToolStripMenuItem,
            this.городToolStripMenuItem,
            this.выбратьНесколькоToolStripMenuItem});
            this.пункт1ToolStripMenuItem.Name = "пункт1ToolStripMenuItem";
            this.пункт1ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.пункт1ToolStripMenuItem.Text = "Поиск";
            // 
            // типколичествоКомнатToolStripMenuItem
            // 
            this.типколичествоКомнатToolStripMenuItem.Name = "типколичествоКомнатToolStripMenuItem";
            this.типколичествоКомнатToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.типколичествоКомнатToolStripMenuItem.Text = "Тип (количество комнат)";
            this.типколичествоКомнатToolStripMenuItem.Click += new System.EventHandler(this.seachRoomAmountToolStripMenuItem_Click);
            // 
            // годЗаселенияToolStripMenuItem
            // 
            this.годЗаселенияToolStripMenuItem.Name = "годЗаселенияToolStripMenuItem";
            this.годЗаселенияToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.годЗаселенияToolStripMenuItem.Text = "Год заселения";
            this.годЗаселенияToolStripMenuItem.Click += new System.EventHandler(this.searchYearToolStripMenuItem_Click);
            // 
            // районToolStripMenuItem
            // 
            this.районToolStripMenuItem.Name = "районToolStripMenuItem";
            this.районToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.районToolStripMenuItem.Text = "Район";
            this.районToolStripMenuItem.Click += new System.EventHandler(this.searchDistrictToolStripMenuItem_Click);
            // 
            // городToolStripMenuItem
            // 
            this.городToolStripMenuItem.Name = "городToolStripMenuItem";
            this.городToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.городToolStripMenuItem.Text = "Город";
            this.городToolStripMenuItem.Click += new System.EventHandler(this.searchCityStripMenuItem_Click);
            // 
            // выбратьНесколькоToolStripMenuItem
            // 
            this.выбратьНесколькоToolStripMenuItem.Name = "выбратьНесколькоToolStripMenuItem";
            this.выбратьНесколькоToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.выбратьНесколькоToolStripMenuItem.Text = "Выбрать несколько";
            this.выбратьНесколькоToolStripMenuItem.Click += new System.EventHandler(this.searchManualToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1,
            this.toolStripButton2,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(679, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(601, 34);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.searchManualToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.площадьToolStripMenuItem,
            this.количествоКомнатToolStripMenuItem,
            this.ценаToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(126, 31);
            this.toolStripDropDownButton1.Text = "Сортировка";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // площадьToolStripMenuItem
            // 
            this.площадьToolStripMenuItem.Name = "площадьToolStripMenuItem";
            this.площадьToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.площадьToolStripMenuItem.Text = "Площадь";
            this.площадьToolStripMenuItem.Click += new System.EventHandler(this.sortAreaToolStripMenuItem_Click);
            // 
            // количествоКомнатToolStripMenuItem
            // 
            this.количествоКомнатToolStripMenuItem.Name = "количествоКомнатToolStripMenuItem";
            this.количествоКомнатToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.количествоКомнатToolStripMenuItem.Text = "Количество комнат";
            this.количествоКомнатToolStripMenuItem.Click += new System.EventHandler(this.sortRoomAmountToolStripMenuItem_Click);
            // 
            // ценаToolStripMenuItem
            // 
            this.ценаToolStripMenuItem.Name = "ценаToolStripMenuItem";
            this.ценаToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ценаToolStripMenuItem.Text = "Цена";
            this.ценаToolStripMenuItem.Click += new System.EventHandler(this.sortPriceToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(149, 31);
            this.toolStripButton2.Text = "Очистить список";
            this.toolStripButton2.Click += new System.EventHandler(this.ClearAllToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem2,
            this.jSONToolStripMenuItem2});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(117, 31);
            this.toolStripDropDownButton2.Text = "Сохранить";
            // 
            // xMLToolStripMenuItem2
            // 
            this.xMLToolStripMenuItem2.Name = "xMLToolStripMenuItem2";
            this.xMLToolStripMenuItem2.Size = new System.Drawing.Size(127, 26);
            this.xMLToolStripMenuItem2.Text = "XML";
            this.xMLToolStripMenuItem2.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem2
            // 
            this.jSONToolStripMenuItem2.Name = "jSONToolStripMenuItem2";
            this.jSONToolStripMenuItem2.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem2.Text = "JSON";
            this.jSONToolStripMenuItem2.Click += new System.EventHandler(this.saveJSONToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem3,
            this.jSONToolStripMenuItem3});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(101, 31);
            this.toolStripDropDownButton3.Text = "Открыть";
            // 
            // xMLToolStripMenuItem3
            // 
            this.xMLToolStripMenuItem3.Name = "xMLToolStripMenuItem3";
            this.xMLToolStripMenuItem3.Size = new System.Drawing.Size(127, 26);
            this.xMLToolStripMenuItem3.Text = "XML";
            this.xMLToolStripMenuItem3.Click += new System.EventHandler(this.deserializeXMLToolStripMenuItem1_Click);
            // 
            // jSONToolStripMenuItem3
            // 
            this.jSONToolStripMenuItem3.Name = "jSONToolStripMenuItem3";
            this.jSONToolStripMenuItem3.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem3.Text = "JSON";
            this.jSONToolStripMenuItem3.Click += new System.EventHandler(this.deserializejSONToolStripMenuItem1_Click);
            // 
            // toolStripEditObject
            // 
            this.toolStripEditObject.AllowDrop = true;
            this.toolStripEditObject.AutoSize = false;
            this.toolStripEditObject.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEditObject.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEditObject.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEditObject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStripEditObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEditRooms,
            this.toolStripButtonDeleteRow});
            this.toolStripEditObject.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripEditObject.Location = new System.Drawing.Point(190, 248);
            this.toolStripEditObject.Name = "toolStripEditObject";
            this.toolStripEditObject.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripEditObject.Size = new System.Drawing.Size(432, 34);
            this.toolStripEditObject.TabIndex = 23;
            this.toolStripEditObject.Text = "toolStrip2";
            // 
            // toolStripButtonEditRooms
            // 
            this.toolStripButtonEditRooms.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditRooms.Image")));
            this.toolStripButtonEditRooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditRooms.Name = "toolStripButtonEditRooms";
            this.toolStripButtonEditRooms.Size = new System.Drawing.Size(200, 24);
            this.toolStripButtonEditRooms.Text = "Редактировать комнаты";
            this.toolStripButtonEditRooms.Click += new System.EventHandler(this.toolStripButtonEditRooms_Click);
            // 
            // toolStripButtonDeleteRow
            // 
            this.toolStripButtonDeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteRow.Image")));
            this.toolStripButtonDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteRow.Name = "toolStripButtonDeleteRow";
            this.toolStripButtonDeleteRow.Size = new System.Drawing.Size(138, 24);
            this.toolStripButtonDeleteRow.Text = "Удалить строку";
            this.toolStripButtonDeleteRow.Click += new System.EventHandler(this.toolStripButtonDeleteRow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 570);
            this.Controls.Add(this.toolStripEditObject);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonEditRow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarResidentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripEditObject.ResumeLayout(false);
            this.toolStripEditObject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAdressesMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOwner;
        private System.Windows.Forms.ListBox listBoxAdress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonEditRow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пункт1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пункут1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem площадиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествуКомнатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типколичествоКомнатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годЗаселенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem районToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem городToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьНесколькоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьСтоимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem площадьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоКомнатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценаToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem3;
        private System.Windows.Forms.ToolStrip toolStripEditObject;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditRooms;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteRow;
    }
}


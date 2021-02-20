
namespace s4_oop_2
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.checkBoxDistrict = new System.Windows.Forms.CheckBox();
            this.checkBoxCity = new System.Windows.Forms.CheckBox();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.trackBarRoomAmount = new System.Windows.Forms.TrackBar();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.panelC = new System.Windows.Forms.Panel();
            this.radioButtonSSimple = new System.Windows.Forms.RadioButton();
            this.radioButtonSPartly = new System.Windows.Forms.RadioButton();
            this.radioButtonSRepeats = new System.Windows.Forms.RadioButton();
            this.radioButtonSBegin = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxSRepeats = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSEnd = new System.Windows.Forms.RadioButton();
            this.panelD = new System.Windows.Forms.Panel();
            this.radioButtonDEnd = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxDRepeats = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonDBegin = new System.Windows.Forms.RadioButton();
            this.radioButtonDRepeats = new System.Windows.Forms.RadioButton();
            this.radioButtonDPartly = new System.Windows.Forms.RadioButton();
            this.radioButtonDSimple = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoomAmount)).BeginInit();
            this.panelC.SuspendLayout();
            this.panelD.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Location = new System.Drawing.Point(12, 46);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(196, 21);
            this.checkBoxType.TabIndex = 0;
            this.checkBoxType.Text = "Тип (количество комнат)";
            this.checkBoxType.UseVisualStyleBackColor = true;
            this.checkBoxType.CheckedChanged += new System.EventHandler(this.checkBoxType_CheckedChanged);
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Location = new System.Drawing.Point(12, 108);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(128, 21);
            this.checkBoxYear.TabIndex = 1;
            this.checkBoxYear.Text = "Год заселения";
            this.checkBoxYear.UseVisualStyleBackColor = true;
            this.checkBoxYear.CheckedChanged += new System.EventHandler(this.checkBoxYear_CheckedChanged);
            // 
            // checkBoxDistrict
            // 
            this.checkBoxDistrict.AutoSize = true;
            this.checkBoxDistrict.Location = new System.Drawing.Point(12, 140);
            this.checkBoxDistrict.Name = "checkBoxDistrict";
            this.checkBoxDistrict.Size = new System.Drawing.Size(71, 21);
            this.checkBoxDistrict.TabIndex = 2;
            this.checkBoxDistrict.Text = "Район";
            this.checkBoxDistrict.UseVisualStyleBackColor = true;
            this.checkBoxDistrict.CheckedChanged += new System.EventHandler(this.checkBoxDistrict_CheckedChanged);
            // 
            // checkBoxCity
            // 
            this.checkBoxCity.AutoSize = true;
            this.checkBoxCity.Location = new System.Drawing.Point(12, 263);
            this.checkBoxCity.Name = "checkBoxCity";
            this.checkBoxCity.Size = new System.Drawing.Size(70, 21);
            this.checkBoxCity.TabIndex = 3;
            this.checkBoxCity.Text = "Город";
            this.checkBoxCity.UseVisualStyleBackColor = true;
            this.checkBoxCity.CheckedChanged += new System.EventHandler(this.checkBoxCity_CheckedChanged);
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Enabled = false;
            this.textBoxDistrict.Location = new System.Drawing.Point(214, 138);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(478, 22);
            this.textBoxDistrict.TabIndex = 6;
            this.textBoxDistrict.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Enabled = false;
            this.textBoxCity.Location = new System.Drawing.Point(214, 261);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(478, 22);
            this.textBoxCity.TabIndex = 7;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 180);
            this.dataGridView1.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(711, 46);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(317, 320);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // trackBarRoomAmount
            // 
            this.trackBarRoomAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trackBarRoomAmount.Enabled = false;
            this.trackBarRoomAmount.Location = new System.Drawing.Point(214, 46);
            this.trackBarRoomAmount.Name = "trackBarRoomAmount";
            this.trackBarRoomAmount.Size = new System.Drawing.Size(478, 56);
            this.trackBarRoomAmount.TabIndex = 10;
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.Enabled = false;
            this.dateTimePickerYear.Location = new System.Drawing.Point(214, 108);
            this.dateTimePickerYear.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerYear.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(478, 22);
            this.dateTimePickerYear.TabIndex = 11;
            // 
            // panelCity
            // 
            this.panelC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC.Controls.Add(this.radioButtonSEnd);
            this.panelC.Controls.Add(this.label1);
            this.panelC.Controls.Add(this.maskedTextBoxSRepeats);
            this.panelC.Controls.Add(this.radioButtonSBegin);
            this.panelC.Controls.Add(this.radioButtonSRepeats);
            this.panelC.Controls.Add(this.radioButtonSPartly);
            this.panelC.Controls.Add(this.radioButtonSSimple);
            this.panelC.Enabled = false;
            this.panelC.Location = new System.Drawing.Point(214, 286);
            this.panelC.Name = "panelCity";
            this.panelC.Size = new System.Drawing.Size(478, 80);
            this.panelC.TabIndex = 12;
            // 
            // radioButtonSSimple
            // 
            this.radioButtonSSimple.AutoSize = true;
            this.radioButtonSSimple.Location = new System.Drawing.Point(3, 3);
            this.radioButtonSSimple.Name = "radioButtonSSimple";
            this.radioButtonSSimple.Size = new System.Drawing.Size(172, 21);
            this.radioButtonSSimple.TabIndex = 0;
            this.radioButtonSSimple.TabStop = true;
            this.radioButtonSSimple.Text = "Полное соответствие";
            this.radioButtonSSimple.UseVisualStyleBackColor = true;
            this.radioButtonSSimple.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSPartly
            // 
            this.radioButtonSPartly.AutoSize = true;
            this.radioButtonSPartly.Location = new System.Drawing.Point(213, 3);
            this.radioButtonSPartly.Name = "radioButtonSPartly";
            this.radioButtonSPartly.Size = new System.Drawing.Size(194, 21);
            this.radioButtonSPartly.TabIndex = 1;
            this.radioButtonSPartly.TabStop = true;
            this.radioButtonSPartly.Text = "Частичное соответствие";
            this.radioButtonSPartly.UseVisualStyleBackColor = true;
            // 
            // radioButtonSRepeats
            // 
            this.radioButtonSRepeats.AutoSize = true;
            this.radioButtonSRepeats.Location = new System.Drawing.Point(3, 56);
            this.radioButtonSRepeats.Name = "radioButtonSRepeats";
            this.radioButtonSRepeats.Size = new System.Drawing.Size(150, 21);
            this.radioButtonSRepeats.TabIndex = 2;
            this.radioButtonSRepeats.TabStop = true;
            this.radioButtonSRepeats.Text = "Повторение теста";
            this.radioButtonSRepeats.UseVisualStyleBackColor = true;
            // 
            // radioButtonSBegin
            // 
            this.radioButtonSBegin.AutoSize = true;
            this.radioButtonSBegin.Location = new System.Drawing.Point(3, 29);
            this.radioButtonSBegin.Name = "radioButtonSBegin";
            this.radioButtonSBegin.Size = new System.Drawing.Size(139, 21);
            this.radioButtonSBegin.TabIndex = 3;
            this.radioButtonSBegin.TabStop = true;
            this.radioButtonSBegin.Text = "В начале строки";
            this.radioButtonSBegin.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxSRepeats
            // 
            this.maskedTextBoxSRepeats.Enabled = false;
            this.maskedTextBoxSRepeats.Location = new System.Drawing.Point(150, 56);
            this.maskedTextBoxSRepeats.Mask = "0";
            this.maskedTextBoxSRepeats.Name = "maskedTextBoxSRepeats";
            this.maskedTextBoxSRepeats.Size = new System.Drawing.Size(13, 22);
            this.maskedTextBoxSRepeats.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "раз";
            // 
            // radioButtonSEnd
            // 
            this.radioButtonSEnd.AutoSize = true;
            this.radioButtonSEnd.Location = new System.Drawing.Point(213, 30);
            this.radioButtonSEnd.Name = "radioButtonSEnd";
            this.radioButtonSEnd.Size = new System.Drawing.Size(130, 21);
            this.radioButtonSEnd.TabIndex = 6;
            this.radioButtonSEnd.TabStop = true;
            this.radioButtonSEnd.Text = "В конце строки";
            this.radioButtonSEnd.UseVisualStyleBackColor = true;
            // 
            // panelDistrict
            // 
            this.panelD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelD.Controls.Add(this.radioButtonDEnd);
            this.panelD.Controls.Add(this.label2);
            this.panelD.Controls.Add(this.maskedTextBoxDRepeats);
            this.panelD.Controls.Add(this.radioButtonDBegin);
            this.panelD.Controls.Add(this.radioButtonDRepeats);
            this.panelD.Controls.Add(this.radioButtonDPartly);
            this.panelD.Controls.Add(this.radioButtonDSimple);
            this.panelD.Enabled = false;
            this.panelD.Location = new System.Drawing.Point(214, 166);
            this.panelD.Name = "panelDistrict";
            this.panelD.Size = new System.Drawing.Size(478, 80);
            this.panelD.TabIndex = 13;
            this.panelD.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // radioButtonDEnd
            // 
            this.radioButtonDEnd.AutoSize = true;
            this.radioButtonDEnd.Location = new System.Drawing.Point(213, 30);
            this.radioButtonDEnd.Name = "radioButtonDEnd";
            this.radioButtonDEnd.Size = new System.Drawing.Size(130, 21);
            this.radioButtonDEnd.TabIndex = 6;
            this.radioButtonDEnd.TabStop = true;
            this.radioButtonDEnd.Text = "В конце строки";
            this.radioButtonDEnd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "раз";
            // 
            // maskedTextBoxDRepeats
            // 
            this.maskedTextBoxDRepeats.Enabled = false;
            this.maskedTextBoxDRepeats.Location = new System.Drawing.Point(150, 56);
            this.maskedTextBoxDRepeats.Mask = "0";
            this.maskedTextBoxDRepeats.Name = "maskedTextBoxDRepeats";
            this.maskedTextBoxDRepeats.Size = new System.Drawing.Size(13, 22);
            this.maskedTextBoxDRepeats.TabIndex = 4;
            // 
            // radioButtonDBegin
            // 
            this.radioButtonDBegin.AutoSize = true;
            this.radioButtonDBegin.Location = new System.Drawing.Point(3, 29);
            this.radioButtonDBegin.Name = "radioButtonDBegin";
            this.radioButtonDBegin.Size = new System.Drawing.Size(139, 21);
            this.radioButtonDBegin.TabIndex = 3;
            this.radioButtonDBegin.TabStop = true;
            this.radioButtonDBegin.Text = "В начале строки";
            this.radioButtonDBegin.UseVisualStyleBackColor = true;
            // 
            // radioButtonDRepeats
            // 
            this.radioButtonDRepeats.AutoSize = true;
            this.radioButtonDRepeats.Location = new System.Drawing.Point(3, 56);
            this.radioButtonDRepeats.Name = "radioButtonDRepeats";
            this.radioButtonDRepeats.Size = new System.Drawing.Size(150, 21);
            this.radioButtonDRepeats.TabIndex = 2;
            this.radioButtonDRepeats.TabStop = true;
            this.radioButtonDRepeats.Text = "Повторение теста";
            this.radioButtonDRepeats.UseVisualStyleBackColor = true;
            // 
            // radioButtonDPartly
            // 
            this.radioButtonDPartly.AutoSize = true;
            this.radioButtonDPartly.Location = new System.Drawing.Point(213, 3);
            this.radioButtonDPartly.Name = "radioButtonDPartly";
            this.radioButtonDPartly.Size = new System.Drawing.Size(194, 21);
            this.radioButtonDPartly.TabIndex = 1;
            this.radioButtonDPartly.TabStop = true;
            this.radioButtonDPartly.Text = "Частичное соответствие";
            this.radioButtonDPartly.UseVisualStyleBackColor = true;
            // 
            // radioButtonDSimple
            // 
            this.radioButtonDSimple.AutoSize = true;
            this.radioButtonDSimple.Location = new System.Drawing.Point(3, 3);
            this.radioButtonDSimple.Name = "radioButtonDSimple";
            this.radioButtonDSimple.Size = new System.Drawing.Size(172, 21);
            this.radioButtonDSimple.TabIndex = 0;
            this.radioButtonDSimple.TabStop = true;
            this.radioButtonDSimple.Text = "Полное соответствие";
            this.radioButtonDSimple.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(711, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(317, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить результаты поиска";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 587);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelD);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.trackBarRoomAmount);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.checkBoxCity);
            this.Controls.Add(this.checkBoxDistrict);
            this.Controls.Add(this.checkBoxYear);
            this.Controls.Add(this.checkBoxType);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoomAmount)).EndInit();
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.panelD.ResumeLayout(false);
            this.panelD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxDistrict;
        private System.Windows.Forms.CheckBox checkBoxCity;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TrackBar trackBarRoomAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.RadioButton radioButtonSBegin;
        private System.Windows.Forms.RadioButton radioButtonSRepeats;
        private System.Windows.Forms.RadioButton radioButtonSPartly;
        private System.Windows.Forms.RadioButton radioButtonSSimple;
        private System.Windows.Forms.RadioButton radioButtonSEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSRepeats;
        private System.Windows.Forms.Panel panelD;
        private System.Windows.Forms.RadioButton radioButtonDEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDRepeats;
        private System.Windows.Forms.RadioButton radioButtonDBegin;
        private System.Windows.Forms.RadioButton radioButtonDRepeats;
        private System.Windows.Forms.RadioButton radioButtonDPartly;
        private System.Windows.Forms.RadioButton radioButtonDSimple;
        private System.Windows.Forms.Button buttonSave;
    }
}
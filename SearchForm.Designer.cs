
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
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.trackBarRoomAmount = new System.Windows.Forms.TrackBar();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.panelC = new System.Windows.Forms.Panel();
            this.maskedTextBoxRepeatsC = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonEndC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonBeginC = new System.Windows.Forms.RadioButton();
            this.radioButtonRepeatsC = new System.Windows.Forms.RadioButton();
            this.radioButtonPartlyC = new System.Windows.Forms.RadioButton();
            this.radioButtonSimpleC = new System.Windows.Forms.RadioButton();
            this.buttonSearchSaveJson = new System.Windows.Forms.Button();
            this.panelD = new System.Windows.Forms.Panel();
            this.maskedTextBoxRepeatsD = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonEndD = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonBeginD = new System.Windows.Forms.RadioButton();
            this.radioButtonRepeatsD = new System.Windows.Forms.RadioButton();
            this.radioButtonPartlyD = new System.Windows.Forms.RadioButton();
            this.radioButtonSimpleD = new System.Windows.Forms.RadioButton();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.buttonSearchSaveXml = new System.Windows.Forms.Button();
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
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(3, 3);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(470, 22);
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
            this.buttonSearch.Size = new System.Drawing.Size(317, 330);
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
            // panelC
            // 
            this.panelC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC.Controls.Add(this.maskedTextBoxRepeatsC);
            this.panelC.Controls.Add(this.radioButtonEndC);
            this.panelC.Controls.Add(this.label1);
            this.panelC.Controls.Add(this.radioButtonBeginC);
            this.panelC.Controls.Add(this.radioButtonRepeatsC);
            this.panelC.Controls.Add(this.radioButtonPartlyC);
            this.panelC.Controls.Add(this.radioButtonSimpleC);
            this.panelC.Controls.Add(this.textBoxCity);
            this.panelC.Enabled = false;
            this.panelC.Location = new System.Drawing.Point(214, 263);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(478, 113);
            this.panelC.TabIndex = 12;
            this.panelC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelS_Paint);
            // 
            // maskedTextBoxRepeatsC
            // 
            this.maskedTextBoxRepeatsC.Enabled = false;
            this.maskedTextBoxRepeatsC.Location = new System.Drawing.Point(166, 87);
            this.maskedTextBoxRepeatsC.Mask = "00";
            this.maskedTextBoxRepeatsC.Name = "maskedTextBoxRepeatsC";
            this.maskedTextBoxRepeatsC.Size = new System.Drawing.Size(17, 22);
            this.maskedTextBoxRepeatsC.TabIndex = 25;
            // 
            // radioButtonEndC
            // 
            this.radioButtonEndC.AutoSize = true;
            this.radioButtonEndC.Location = new System.Drawing.Point(213, 62);
            this.radioButtonEndC.Name = "radioButtonEndC";
            this.radioButtonEndC.Size = new System.Drawing.Size(130, 21);
            this.radioButtonEndC.TabIndex = 4;
            this.radioButtonEndC.TabStop = true;
            this.radioButtonEndC.Text = "В конце строки";
            this.radioButtonEndC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "раз";
            // 
            // radioButtonBeginC
            // 
            this.radioButtonBeginC.AutoSize = true;
            this.radioButtonBeginC.Location = new System.Drawing.Point(3, 61);
            this.radioButtonBeginC.Name = "radioButtonBeginC";
            this.radioButtonBeginC.Size = new System.Drawing.Size(139, 21);
            this.radioButtonBeginC.TabIndex = 3;
            this.radioButtonBeginC.TabStop = true;
            this.radioButtonBeginC.Text = "В начале строки";
            this.radioButtonBeginC.UseVisualStyleBackColor = true;
            // 
            // radioButtonRepeatsC
            // 
            this.radioButtonRepeatsC.AutoSize = true;
            this.radioButtonRepeatsC.Location = new System.Drawing.Point(3, 88);
            this.radioButtonRepeatsC.Name = "radioButtonRepeatsC";
            this.radioButtonRepeatsC.Size = new System.Drawing.Size(157, 21);
            this.radioButtonRepeatsC.TabIndex = 2;
            this.radioButtonRepeatsC.TabStop = true;
            this.radioButtonRepeatsC.Text = "Повторение текста";
            this.radioButtonRepeatsC.UseVisualStyleBackColor = true;
            this.radioButtonRepeatsC.CheckedChanged += new System.EventHandler(this.radioButtonSRepeats_CheckedChanged);
            // 
            // radioButtonPartlyC
            // 
            this.radioButtonPartlyC.AutoSize = true;
            this.radioButtonPartlyC.Location = new System.Drawing.Point(213, 35);
            this.radioButtonPartlyC.Name = "radioButtonPartlyC";
            this.radioButtonPartlyC.Size = new System.Drawing.Size(194, 21);
            this.radioButtonPartlyC.TabIndex = 1;
            this.radioButtonPartlyC.TabStop = true;
            this.radioButtonPartlyC.Text = "Частичное соответствие";
            this.radioButtonPartlyC.UseVisualStyleBackColor = true;
            // 
            // radioButtonSimpleC
            // 
            this.radioButtonSimpleC.AutoSize = true;
            this.radioButtonSimpleC.Location = new System.Drawing.Point(3, 35);
            this.radioButtonSimpleC.Name = "radioButtonSimpleC";
            this.radioButtonSimpleC.Size = new System.Drawing.Size(172, 21);
            this.radioButtonSimpleC.TabIndex = 0;
            this.radioButtonSimpleC.TabStop = true;
            this.radioButtonSimpleC.Text = "Полное соответствие";
            this.radioButtonSimpleC.UseVisualStyleBackColor = true;
            this.radioButtonSimpleC.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonSearchSaveJson
            // 
            this.buttonSearchSaveJson.Location = new System.Drawing.Point(711, 17);
            this.buttonSearchSaveJson.Name = "buttonSearchSaveJson";
            this.buttonSearchSaveJson.Size = new System.Drawing.Size(155, 23);
            this.buttonSearchSaveJson.TabIndex = 14;
            this.buttonSearchSaveJson.Text = "Сохранить JSON";
            this.buttonSearchSaveJson.UseVisualStyleBackColor = true;
            this.buttonSearchSaveJson.Click += new System.EventHandler(this.buttonSearchSaveJson_Click);
            // 
            // panelD
            // 
            this.panelD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelD.Controls.Add(this.maskedTextBoxRepeatsD);
            this.panelD.Controls.Add(this.radioButtonEndD);
            this.panelD.Controls.Add(this.label2);
            this.panelD.Controls.Add(this.radioButtonBeginD);
            this.panelD.Controls.Add(this.radioButtonRepeatsD);
            this.panelD.Controls.Add(this.radioButtonPartlyD);
            this.panelD.Controls.Add(this.radioButtonSimpleD);
            this.panelD.Controls.Add(this.textBoxDistrict);
            this.panelD.Enabled = false;
            this.panelD.Location = new System.Drawing.Point(214, 140);
            this.panelD.Name = "panelD";
            this.panelD.Size = new System.Drawing.Size(478, 113);
            this.panelD.TabIndex = 24;
            // 
            // maskedTextBoxRepeatsD
            // 
            this.maskedTextBoxRepeatsD.Enabled = false;
            this.maskedTextBoxRepeatsD.Location = new System.Drawing.Point(166, 88);
            this.maskedTextBoxRepeatsD.Mask = "00";
            this.maskedTextBoxRepeatsD.Name = "maskedTextBoxRepeatsD";
            this.maskedTextBoxRepeatsD.Size = new System.Drawing.Size(17, 22);
            this.maskedTextBoxRepeatsD.TabIndex = 24;
            // 
            // radioButtonEndD
            // 
            this.radioButtonEndD.AutoSize = true;
            this.radioButtonEndD.Location = new System.Drawing.Point(213, 62);
            this.radioButtonEndD.Name = "radioButtonEndD";
            this.radioButtonEndD.Size = new System.Drawing.Size(130, 21);
            this.radioButtonEndD.TabIndex = 4;
            this.radioButtonEndD.TabStop = true;
            this.radioButtonEndD.Text = "В конце строки";
            this.radioButtonEndD.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "раз";
            // 
            // radioButtonBeginD
            // 
            this.radioButtonBeginD.AutoSize = true;
            this.radioButtonBeginD.Location = new System.Drawing.Point(3, 61);
            this.radioButtonBeginD.Name = "radioButtonBeginD";
            this.radioButtonBeginD.Size = new System.Drawing.Size(139, 21);
            this.radioButtonBeginD.TabIndex = 3;
            this.radioButtonBeginD.TabStop = true;
            this.radioButtonBeginD.Text = "В начале строки";
            this.radioButtonBeginD.UseVisualStyleBackColor = true;
            this.radioButtonBeginD.CheckedChanged += new System.EventHandler(this.radioButtonBeginD_CheckedChanged);
            // 
            // radioButtonRepeatsD
            // 
            this.radioButtonRepeatsD.AutoSize = true;
            this.radioButtonRepeatsD.Location = new System.Drawing.Point(3, 88);
            this.radioButtonRepeatsD.Name = "radioButtonRepeatsD";
            this.radioButtonRepeatsD.Size = new System.Drawing.Size(157, 21);
            this.radioButtonRepeatsD.TabIndex = 2;
            this.radioButtonRepeatsD.TabStop = true;
            this.radioButtonRepeatsD.Text = "Повторение текста";
            this.radioButtonRepeatsD.UseVisualStyleBackColor = true;
            this.radioButtonRepeatsD.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonPartlyD
            // 
            this.radioButtonPartlyD.AutoSize = true;
            this.radioButtonPartlyD.Location = new System.Drawing.Point(213, 35);
            this.radioButtonPartlyD.Name = "radioButtonPartlyD";
            this.radioButtonPartlyD.Size = new System.Drawing.Size(194, 21);
            this.radioButtonPartlyD.TabIndex = 1;
            this.radioButtonPartlyD.TabStop = true;
            this.radioButtonPartlyD.Text = "Частичное соответствие";
            this.radioButtonPartlyD.UseVisualStyleBackColor = true;
            // 
            // radioButtonSimpleD
            // 
            this.radioButtonSimpleD.AutoSize = true;
            this.radioButtonSimpleD.Location = new System.Drawing.Point(3, 35);
            this.radioButtonSimpleD.Name = "radioButtonSimpleD";
            this.radioButtonSimpleD.Size = new System.Drawing.Size(172, 21);
            this.radioButtonSimpleD.TabIndex = 0;
            this.radioButtonSimpleD.TabStop = true;
            this.radioButtonSimpleD.Text = "Полное соответствие";
            this.radioButtonSimpleD.UseVisualStyleBackColor = true;
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Location = new System.Drawing.Point(3, 3);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(470, 22);
            this.textBoxDistrict.TabIndex = 7;
            // 
            // buttonSearchSaveXml
            // 
            this.buttonSearchSaveXml.Location = new System.Drawing.Point(872, 17);
            this.buttonSearchSaveXml.Name = "buttonSearchSaveXml";
            this.buttonSearchSaveXml.Size = new System.Drawing.Size(156, 23);
            this.buttonSearchSaveXml.TabIndex = 25;
            this.buttonSearchSaveXml.Text = "Сохранить XML";
            this.buttonSearchSaveXml.UseVisualStyleBackColor = true;
            this.buttonSearchSaveXml.Click += new System.EventHandler(this.buttonSearchSaveXml_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 587);
            this.Controls.Add(this.buttonSearchSaveXml);
            this.Controls.Add(this.panelD);
            this.Controls.Add(this.buttonSearchSaveJson);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.trackBarRoomAmount);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TrackBar trackBarRoomAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.RadioButton radioButtonBeginC;
        private System.Windows.Forms.RadioButton radioButtonRepeatsC;
        private System.Windows.Forms.RadioButton radioButtonPartlyC;
        private System.Windows.Forms.RadioButton radioButtonSimpleC;
        private System.Windows.Forms.RadioButton radioButtonEndC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchSaveJson;
        private System.Windows.Forms.Panel panelD;
        private System.Windows.Forms.RadioButton radioButtonEndD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonBeginD;
        private System.Windows.Forms.RadioButton radioButtonRepeatsD;
        private System.Windows.Forms.RadioButton radioButtonPartlyD;
        private System.Windows.Forms.RadioButton radioButtonSimpleD;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRepeatsD;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRepeatsC;
        private System.Windows.Forms.Button buttonSearchSaveXml;
    }
}
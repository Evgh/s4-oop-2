
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
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.maskedTextBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Location = new System.Drawing.Point(12, 12);
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
            this.checkBoxYear.Location = new System.Drawing.Point(12, 39);
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
            this.checkBoxDistrict.Location = new System.Drawing.Point(12, 66);
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
            this.checkBoxCity.Location = new System.Drawing.Point(12, 93);
            this.checkBoxCity.Name = "checkBoxCity";
            this.checkBoxCity.Size = new System.Drawing.Size(70, 21);
            this.checkBoxCity.TabIndex = 3;
            this.checkBoxCity.Text = "Город";
            this.checkBoxCity.UseVisualStyleBackColor = true;
            this.checkBoxCity.CheckedChanged += new System.EventHandler(this.checkBoxCity_CheckedChanged);
            // 
            // textBoxType
            // 
            this.textBoxType.Enabled = false;
            this.textBoxType.Location = new System.Drawing.Point(214, 12);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 22);
            this.textBoxType.TabIndex = 4;
            this.textBoxType.TextChanged += new System.EventHandler(this.textBoxDistrict_TextChanged);
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Enabled = false;
            this.maskedTextBoxYear.Location = new System.Drawing.Point(214, 39);
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxYear.TabIndex = 5;
            this.maskedTextBoxYear.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Enabled = false;
            this.textBoxDistrict.Location = new System.Drawing.Point(214, 68);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(100, 22);
            this.textBoxDistrict.TabIndex = 6;
            this.textBoxDistrict.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Enabled = false;
            this.textBoxCity.Location = new System.Drawing.Point(214, 96);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxCity.TabIndex = 7;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 362);
            this.dataGridView1.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(345, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 106);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 525);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.maskedTextBoxYear);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.checkBoxCity);
            this.Controls.Add(this.checkBoxDistrict);
            this.Controls.Add(this.checkBoxYear);
            this.Controls.Add(this.checkBoxType);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxDistrict;
        private System.Windows.Forms.CheckBox checkBoxCity;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYear;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
    }
}
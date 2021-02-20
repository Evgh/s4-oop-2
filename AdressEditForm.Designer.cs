namespace s4_oop_2
{
    partial class AdressEditForm
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
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxHouseNum = new System.Windows.Forms.TextBox();
            this.maskedTextBoxFlatNum = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewAdresses = new System.Windows.Forms.DataGridView();
            this.buttonAddAdress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdresses)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(141, 21);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountry.TabIndex = 0;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(141, 49);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxCity.TabIndex = 1;
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Location = new System.Drawing.Point(141, 77);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(100, 22);
            this.textBoxDistrict.TabIndex = 2;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(141, 105);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(100, 22);
            this.textBoxStreet.TabIndex = 3;
            // 
            // textBoxHouseNum
            // 
            this.textBoxHouseNum.Location = new System.Drawing.Point(141, 133);
            this.textBoxHouseNum.Name = "textBoxHouseNum";
            this.textBoxHouseNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxHouseNum.TabIndex = 4;
            // 
            // maskedTextBoxFlatNum
            // 
            this.maskedTextBoxFlatNum.Location = new System.Drawing.Point(141, 162);
            this.maskedTextBoxFlatNum.Mask = "000";
            this.maskedTextBoxFlatNum.Name = "maskedTextBoxFlatNum";
            this.maskedTextBoxFlatNum.Size = new System.Drawing.Size(28, 22);
            this.maskedTextBoxFlatNum.TabIndex = 5;
            this.maskedTextBoxFlatNum.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Район";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Улица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер дома";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Номер квартиры";
            // 
            // dataGridViewAdresses
            // 
            this.dataGridViewAdresses.AllowUserToDeleteRows = false;
            this.dataGridViewAdresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdresses.Location = new System.Drawing.Point(274, 21);
            this.dataGridViewAdresses.Name = "dataGridViewAdresses";
            this.dataGridViewAdresses.RowHeadersWidth = 51;
            this.dataGridViewAdresses.RowTemplate.Height = 24;
            this.dataGridViewAdresses.Size = new System.Drawing.Size(894, 232);
            this.dataGridViewAdresses.TabIndex = 12;
            this.dataGridViewAdresses.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridViewAdresses_CellStateChanged);
            // 
            // buttonAddAdress
            // 
            this.buttonAddAdress.Location = new System.Drawing.Point(20, 230);
            this.buttonAddAdress.Name = "buttonAddAdress";
            this.buttonAddAdress.Size = new System.Drawing.Size(149, 23);
            this.buttonAddAdress.TabIndex = 13;
            this.buttonAddAdress.Text = "Добавить адрес";
            this.buttonAddAdress.UseVisualStyleBackColor = true;
            this.buttonAddAdress.Click += new System.EventHandler(this.buttonAddAdress_Click);
            // 
            // AdressEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 265);
            this.Controls.Add(this.buttonAddAdress);
            this.Controls.Add(this.dataGridViewAdresses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxFlatNum);
            this.Controls.Add(this.textBoxHouseNum);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxCountry);
            this.Name = "AdressEditForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdresses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxHouseNum;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFlatNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewAdresses;
        private System.Windows.Forms.Button buttonAddAdress;
    }
}
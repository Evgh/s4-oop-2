using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;


namespace s4_oop_2
{
    public struct SearchFormArgs
    {
        public bool type;
        public bool year;
        public bool district;
        public bool city;
    }


    public partial class SearchForm : Form
    {
        MainForm _parent;
        MyBindingSourse selectedFlats;

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(SearchFormArgs sfa, MainForm parent)
        {
            InitializeComponent();
            _parent = parent;

            //_parent.Controls.Find("", false);

            selectedFlats = parent.Flats;

            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;

            if (sfa.type)
            {
                checkBoxType.CheckState = CheckState.Checked;
            }
            if (sfa.year)
            {
                checkBoxYear.CheckState = CheckState.Checked;
            }
            if (sfa.district)
            {
                checkBoxDistrict.CheckState = CheckState.Checked;
            }
            if (sfa.city)
            {
                checkBoxCity.CheckState = CheckState.Checked;
            }

            InitializeDataGridView1();
        }

        internal void InitializeDataGridView1()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = selectedFlats;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Columns["AdressId"].Visible = false;
            DataGridViewColumn columnAdressLast = dataGridView1.Columns[dataGridView1.Columns.Count - 1];
            DataGridViewColumn columnAdressFirst = dataGridView1.Columns[0];
            columnAdressLast.AutoSizeMode = columnAdressFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void checkBoxType_CheckedChanged(object sender, EventArgs e)
        {
            trackBarRoomAmount.Enabled = !trackBarRoomAmount.Enabled; 
        }

        private void checkBoxYear_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerYear.Enabled = !dateTimePickerYear.Enabled;
        }

        private void checkBoxDistrict_CheckedChanged(object sender, EventArgs e)
        {
            panelD.Enabled = !panelD.Enabled;
        }

        private void checkBoxCity_CheckedChanged(object sender, EventArgs e)
        {
            panelC.Enabled = !panelC.Enabled;
        }

        private void radioButtonSRepeats_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxRepeatsC.Enabled = !maskedTextBoxRepeatsC.Enabled;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
             maskedTextBoxRepeatsD.Enabled = !maskedTextBoxRepeatsD.Enabled;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //selectedFlats = _parent._flats;
            //if (checkBoxType.Checked)
            //{
            //    var searchResults = from flat in selectedFlats
            //                        where flat.RoomAmount == trackBarRoomAmount.Value
            //                        select flat;
            //    selectedFlats = searchResults.ToList();
            //}

            //if (checkBoxYear.Checked)
            //{
            //    var searchResults = from flat in selectedFlats
            //                        where flat.Day.Year == dateTimePickerYear.Value.Year
            //                        select flat;
            //    selectedFlats = searchResults.ToList();
            //}

            //if (checkBoxDistrict.Checked)
            //{
            //    var searchResults = from flat in selectedFlats
            //                        where textRegExValidation(flat.FlatAdress.District, panelD)
            //                        select flat;
            //    selectedFlats = searchResults.ToList();
            //}
            //if (checkBoxCity.Checked)
            //{
            //    var searchResults = from flat in selectedFlats
            //                        where textRegExValidation(flat.FlatAdress.City, panelC)
            //                        select flat;
            //    selectedFlats = searchResults.ToList();
            //}

            InitializeDataGridView1();
        }

        private bool textRegExValidation(string str, Panel panel)
        {
            int index = 100;
            IEnumerable<Control> panelControls = panel.Controls.OfType<Control>();

            TextBox text = (TextBox) panelControls.Where((c) => (c is TextBox)).ToList()[0];
            MaskedTextBox repeatsAmount = (MaskedTextBox) panelControls.Where((c) => (c is MaskedTextBox)).ToList()[0];           

            // Узнаем, какой тип сравнения выбран
            foreach (RadioButton rr in panelControls.Where((c) => (c is RadioButton)))
            {
                if (rr.Checked)
                {
                    index = rr.TabIndex; 
                    break;
                }
            }

            switch (index)
            {
                // Обычное сравнение
                case 0:
                    return str == text.Text;

                // Проверка на частичное соответствие
                case 1:
                    return Regex.IsMatch(str, text.Text);

                // Выражение встречается n количество раз
                case 2:
                    try
                    {
                        int repeats = int.Parse(repeatsAmount.Text);
                        Regex regex = new Regex(@"(\s*\w*" + text.Text + @"\w*\s*){" + repeats + "}");
                        repeatsAmount.BackColor = System.Drawing.SystemColors.Window;
                        return regex.IsMatch(str);
                    }
                    catch
                    {
                        MessageBox.Show("Format Error");
                        repeatsAmount.BackColor = System.Drawing.Color.Salmon;
                        return false;
                    }

                // В начале строки 
                case 3:
                    return Regex.IsMatch(str, $"^{text.Text}");

                // В конце строки
                case 4:
                    return Regex.IsMatch(str, $"{text.Text}$");

                default: 
                    return false;
            }
        }

        private void buttonSearchSaveJson_Click(object sender, EventArgs e)
        {
            _parent.SaveDialog.Filter = "Java Script Object Notation(*.json)|*.json|All files|*.*";
            if (_parent.SaveDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string path = _parent.SaveDialog.FileName;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(selectedFlats, Newtonsoft.Json.Formatting.Indented));
            }
            MessageBox.Show("Файл сохранен");
            // _parent.jSONToolStripMenuItem_Click(this, new EventArgs());
        }

        private void buttonSearchSaveXml_Click(object sender, EventArgs e)
        {
            _parent.SaveDialog.Filter = "XML files(*.xml)|*.xml|All files|*.*";
            if (_parent.SaveDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string path = _parent.SaveDialog.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Flat>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, selectedFlats);
            }
            MessageBox.Show("Файл сохранен");
        }


        ///
        private void textBoxDistrict_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioButtonBeginD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelS_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

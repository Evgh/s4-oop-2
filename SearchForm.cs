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

    public partial class SearchForm : Form, IBindingForm
    {
        MainForm _parent;
        IBindingListPrototype primary;
        IBindingListPrototype parentList;
        public IBindingListPrototype PrimarySource => primary;
        public IBindingListPrototype SecondarySource => parentList;

        public Form ToForm()
        {
            return this;
        }

        public void InitializePrimarySource(IBindingListPrototype source)
        {
            primary = source;
            dataGridView1.DataSource = PrimarySource;
            dataGridView1.Columns["AdressId"].Visible = false;
            DataGridViewColumn columnAdressLast = dataGridView1.Columns[dataGridView1.Columns.Count - 1];
            DataGridViewColumn columnAdressFirst = dataGridView1.Columns[0];
            columnAdressLast.AutoSizeMode = columnAdressFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        public void InitializeSecondarySource(IBindingListPrototype source)
        {
            parentList = source;
        }

        public SearchForm(SearchFormArgs sfa, MainForm parent)
        {
            InitializeComponent();
            _parent = parent;

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
            var selected = parentList.OfType<IFlat>();
            if (checkBoxType.Checked)
            {
                var searchResults = from flat in selected
                                    where flat.RoomAmount == trackBarRoomAmount.Value
                                    select flat;

                selected = searchResults;
            }

            if (checkBoxYear.Checked)
            {
                var searchResults = from flat in selected
                                    where flat.Day.Year == dateTimePickerYear.Value.Year
                                    select flat;
                selected = searchResults;
            }

            if (checkBoxDistrict.Checked)
            {
                var searchResults = from flat in selected
                                    where textRegExValidation(flat.FlatAdress.District, panelD)
                                    select flat;
                selected = searchResults;
            }
            if (checkBoxCity.Checked)
            {
                var searchResults = from flat in selected
                                    where textRegExValidation(flat.FlatAdress.City, panelC)
                                    select flat;
                selected = searchResults;
            }

            PrimarySource.Clear();
            foreach (var el in selected)
            {
                PrimarySource.Add(el);
            }
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

            //string path = _parent.SaveDialog.FileName;
            //using (StreamWriter sw = new StreamWriter(path, false))
            //{
            //    sw.WriteLine(JsonConvert.SerializeObject(selectedFlats, Newtonsoft.Json.Formatting.Indented));
            //}
            //MessageBox.Show("Файл сохранен");


            string path = _parent.SaveDialog.FileName;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(PrimarySource, Newtonsoft.Json.Formatting.Indented));
            }
            MessageBox.Show("Файл сохранен");
        }
    }
}

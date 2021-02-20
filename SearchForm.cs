using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        List<Flat> selectedFlats;

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(SearchFormArgs sfa, MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
            selectedFlats = parent._flats;

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
            textBoxDistrict.Enabled = !textBoxDistrict.Enabled;
            panelD.Enabled = !panelD.Enabled;
        }

        private void checkBoxCity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCity.Enabled = !textBoxCity.Enabled;
            panelC.Enabled = !panelC.Enabled;
        }



        private bool textRegExValidation(string str, char symbol)
        {
            // если controls["radioButton + Первая буква + св-во"].Checked 

            //MessageBox.Show(Controls["radioButton" + symbol + "Simple"].Text);
            MessageBox.Show(panelD.Controls["radioButtonDSimple"].Text);

/*            if ((Controls["radioButton" + symbol + "Simple"] as RadioButton).Checked)
            {
                MessageBox.Show("");
            }
*/
            return true;
        } 

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            selectedFlats = _parent._flats;
            if (checkBoxType.Checked)
            {
                var searchResults = from flat in selectedFlats
                                    where flat.RoomAmount == trackBarRoomAmount.Value
                                    select flat;
                selectedFlats = searchResults.ToList();
            }

            if (checkBoxYear.Checked)
            {
                var searchResults = from flat in selectedFlats
                                    where flat.Day.Year == dateTimePickerYear.Value.Year
                                    select flat;
                selectedFlats = searchResults.ToList();
            }

            if (checkBoxDistrict.Checked)
            {
                var searchResults = from flat in selectedFlats
                                    where textRegExValidation(flat.FlatAdress.District, 'D')
                                    select flat;
                selectedFlats = searchResults.ToList();
            }
            if (checkBoxCity.Checked)
            {
                var searchResults = from flat in selectedFlats
                                    where flat.FlatAdress.City == textBoxCity.Text
                                    select flat;
                selectedFlats = searchResults.ToList();
            }

            InitializeDataGridView1();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

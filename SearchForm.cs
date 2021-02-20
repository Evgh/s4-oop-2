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

        //System.Collections.Generic.Ienumerable<Flat>
        internal void InitializeDataGridView1()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = selectedFlats;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Columns["AdressId"].Visible = false;
            DataGridViewColumn columnAdressLast = dataGridView1.Columns[dataGridView1.Columns.Count - 1];
            DataGridViewColumn columnAdressFirst = dataGridView1.Columns[0];
            columnAdressLast.AutoSizeMode = columnAdressFirst.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            // попытка сделать редактирование адреса через выпадающий список Combobox  

            //DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            //column.HeaderText = "Adress";
            //column.Width = 300;

            //BindingSource comboboxSource = new BindingSource();
            //comboboxSource.DataSource = Adress.adressPool;
            //column.DataSource = comboboxSource;

            //column.DisplayMember = "MyToString";
            //column.ValueMember = "Id";

            //for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            //{
            //    dataGridView1.Rows[i].Cells[7].Value = Adress.adressPool[0].MyToString;
            //}
            //dataGridView1.Columns.Add(column);

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
        //

        private void checkBoxType_CheckedChanged(object sender, EventArgs e)
        {
            textBoxType.Enabled = !textBoxType.Enabled; 
        }

        private void checkBoxYear_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxYear.Enabled = !maskedTextBoxYear.Enabled;
        }

        private void checkBoxDistrict_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDistrict.Enabled = !textBoxDistrict.Enabled;
        }

        private void checkBoxCity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCity.Enabled = !textBoxCity.Enabled;
        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchRresults = from a in _parent._flats
                            where a.Owner == "Владелец"
                            select a;

            selectedFlats = searchRresults.ToList();
            InitializeDataGridView1();
        }
    }
}

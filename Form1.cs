using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace s4_oop_2
{

    public partial class Form1 : Form
    {
        List<Flat> _flats;
        List<Adress> _adresses;

        public Form1()
        {
            InitializeComponent();
            _flats = new List<Flat> {};
            _adresses = new List<Adress> { };

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _flats;
            dataGridView1.DataSource = bindingSource;
        }

        public Form1(object flats, object adresses)
        {
            InitializeComponent();

            try 
            {
                _flats = (List<Flat>) flats;
                _adresses = (List<Adress>)adresses;
            } 
            catch (InvalidCastException e)
            {
                MessageBox.Show("Не удалось получить список квартир и перечень адресов\n" + e.Message);
                _flats = new List<Flat> { };
                _adresses = new List<Adress> { };
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _flats;
            dataGridView1.DataSource = bindingSource;
        }


        FlatArgs MyFlatArgs
        {
            get
            {
                return new FlatArgs
                {
                    owner = maskedTextBoxOwner.Text,
                    residentAmount = trackBarResidentAmount.Value,
                    area = int.Parse(maskedTextBoxArea.Text),
                    roomAmount = 1,
                    day = dateTimePickerDay.Value,
                    hasKitchen = checkBoxHasKitchen.Checked,
                    hasBathroom = checkBoxHasBathroom.Checked,
                    hasRestroom = checkBoxHasRestroom.Checked,
                    hasBasement = checkBoxHasBasement.Checked,
                    hasBalcony = checkBoxHasBalcony.Checked,
                    adress = new Adress()
                };
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonGoodsDefault_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in panel2.Controls)
            {
                if (control is CheckBox)
                {
                    var checkBox = control as CheckBox;
                    checkBox.AutoCheck = false;

                    if (checkBox.Name == "checkBoxHasBasement" || checkBox.Name == "checkBoxHasBalcony")
                    {
                        checkBox.CheckState = CheckState.Unchecked;
                    }
                    else
                    {
                        checkBox.CheckState = CheckState.Indeterminate;
                    }
                }
            }
        }

        private void radioButtonGoodsManual_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in panel2.Controls)
            {
                if (control is CheckBox)
                {
                    var checkBox = control as CheckBox;
                    checkBox.AutoCheck = true;

                    if (checkBox.CheckState == CheckState.Indeterminate)
                    {
                        checkBox.CheckState = CheckState.Checked;
                    }

                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                _flats.Add(new Flat(MyFlatArgs));
                maskedTextBoxArea.BackColor = System.Drawing.SystemColors.Window;
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
                maskedTextBoxArea.BackColor = System.Drawing.Color.Salmon;
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _flats;
            dataGridView1.DataSource = bindingSource;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _flats.Clear();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _flats;
            dataGridView1.DataSource = bindingSource;
        }
    }
}



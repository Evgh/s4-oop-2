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
            _flats = new List<Flat> { };
            _adresses = new List<Adress> { };

            InitializeDataGridView1();
            InitializeListBoxAdress();
        }

        public Form1(List<Flat> flats, List<Adress> adresses)
        {
            InitializeComponent();
            _flats = flats;
            _adresses = adresses;

            InitializeDataGridView1();
            InitializeListBoxAdress();
        }

        internal void InitializeDataGridView1()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _flats;
            dataGridView1.DataSource = bindingSource;
        }

        internal void InitializeListBoxAdress()
        {

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _adresses;
            listBoxAdress.DataSource = bindingSource;
            listBoxAdress.DisplayMember = "MyToString";
            listBoxAdress.ValueMember = "FlatNumber";
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
                    adress = listBoxAdress.SelectedItem as Adress
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

            InitializeDataGridView1();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _flats.Clear();
            InitializeDataGridView1();
        }

        private void buttonAdressesMenu_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this, _adresses);
            form.Show();
        }
    }
}



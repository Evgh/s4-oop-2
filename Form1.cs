using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace s4_oop_2
{

    public partial class Form1 : Form
    {
        List<Flat> _flats;

        public Form1() : this (new List<Flat> { })
        {
        }

        public Form1(List<Flat> flats)
        {
            InitializeComponent();
            _flats = flats;
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
            bindingSource.DataSource = Adress.adressPool;
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
            Form2 form = new Form2(this);
            form.Show();
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(_flats.GetType());
            using (FileStream fs = new FileStream("serialize.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, _flats);
            }
        }
        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(_flats.GetType());
            using (FileStream fs = new FileStream("serialize.xml", FileMode.Open))
            {
                _flats = (List<Flat>)serializer.Deserialize(fs);
            }

            InitializeDataGridView1();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace s4_oop_2
{

    public partial class Form1 : Form
    {
        public List<Flat> _flats;

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
            // try/catch обрабатывает случай, если площадь не введена
            try
            {
                var flat = new Flat(MyFlatArgs);
                var results = new List<ValidationResult> { };
                var context = new ValidationContext(flat);
                // валидация 
                if (!Validator.TryValidateObject(flat, context, results, true))
                {
                    List<int> invalidIndexex = new List<int> { };
                    StringBuilder message = new StringBuilder("");
                    
                    foreach (var error in results)
                    {
                        message.Append(error.ErrorMessage);
                        message.Append('\n');
                        // получаем таб-индекс элемента из сообщения об ошибке (индексы прописаны вручную)
                        invalidIndexex.Add(int.Parse(error.ErrorMessage.Substring(0, 1)));
                    }

                    //// перекрашиваем поля ввода с некорректными данными
                    foreach (Control control in panel1.Controls)
                    {
                        for (int i = 0; i < invalidIndexex.Count; i++)
                        {
                            if (control.TabIndex == invalidIndexex[i])
                            {
                                control.BackColor = System.Drawing.Color.Salmon;
                                break;
                            }
                            control.BackColor = System.Drawing.SystemColors.Window;
                        }                        
                    }

                    MessageBox.Show(message.ToString());
                }
                else
                {
                    _flats.Add(flat);
                    maskedTextBoxArea.BackColor = maskedTextBoxOwner.BackColor = System.Drawing.SystemColors.Window;

                    Form3 roomEditor = new Form3(_flats[_flats.Count - 1].Id, this);
                    roomEditor.Show();
                }
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

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = saveFileDialog1.FileName;
            XmlSerializer serializer = new XmlSerializer(_flats.GetType());
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, _flats);
            }
            MessageBox.Show("Файл сохранен");
        }
        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = openFileDialog1.FileName;
            XmlSerializer serializer = new XmlSerializer(_flats.GetType());
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                _flats = (List<Flat>)serializer.Deserialize(fs);
            }

            // костыль, поскольку я усложнила себе жизнь и сделала адреса хранящимися в пуле
            // собственно, объекты-адреса не сериализуются, они просто хранятся в памяти, а каждая квартира получает даже не ссылку на свой адрес, а id адреса
            // и по этому id квартира работает со ссылкой на адрес через пул адресов
            // возможна ситуация, когда объект десериализуется, и у него будет ид на адрес, которого не существует
            foreach (var flat in _flats)
            {
                if (flat.AdressId > Adress.adressPool.Count - 1)
                {
                    flat.AdressId = 0;
                }
            }

            InitializeDataGridView1();
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Form3 form = new Form3(int.Parse(row.Cells[0].Value.ToString()), this);
                form.Show();
            }
        }

        private void buttonСount_Click(object sender, EventArgs e)
        {
            string message = "";
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Flat theFlat = _flats.Find((f) => { return f.Id == id; });

                message = $"Стоимость квартиры {theFlat?.Count()} белорусских рублей";
            }
            else
            {
                message = "Выделите 1 строку в таблице";
            }

            MessageBox.Show(message);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}